using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace My_dream_is_owner
{
    public partial class Form1 : Form
    {
        //유니티 연결
        [DllImport("User32.dll")]
        static extern bool MoveWindow(IntPtr handle, int x, int y, int width, int height, bool redraw);

        internal delegate int WindowEnumProc(IntPtr hwnd, IntPtr lparam);
        [DllImport("user32.dll")]
        internal static extern bool EnumChildWindows(IntPtr hwnd, WindowEnumProc func, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        static extern bool SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        const int SWP_DRAWFRAME = 0x20;
        const int SWP_NOMOVE = 0x2;
        const int SWP_NOSIZE = 0x1;
        const int SWP_NOZORDER = 0x4;

        public static string game;
        public static int stage_data;
        public static int click_stage;
        public string data;
        private Process process;
        private IntPtr unityHWND = IntPtr.Zero;

        private const int WM_ACTIVATE = 0x0006;
        private readonly IntPtr WA_ACTIVE = new IntPtr(1);
        private readonly IntPtr WA_INACTIVE = new IntPtr(0);
        private StageForm stageForm;

        //network 연결
        TcpListener Server; // 소켓 서버
        TcpClient Client; // 클라이언트
        byte[] recevBuffer;
        int port = 8080;

        Thread ListenThread; // 서버 Thread

        public string value1 { get; set; }
        public void sss()
        {
            game = value1;
        }
        delegate void SetFormCloseCallback();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(StageForm stageForm)
        {
            InitializeComponent();
            this.stageForm = stageForm;
        }
        private void ActivateUnityWindow()
        {
            SendMessage(unityHWND, WM_ACTIVATE, WA_ACTIVE, IntPtr.Zero);
        }
        private void DeactivateUnityWindow()
        {
            SendMessage(unityHWND, WM_ACTIVATE, WA_INACTIVE, IntPtr.Zero);
        }
        private int WindowEnum(IntPtr hwnd, IntPtr lparam)
        {
            unityHWND = hwnd;
            ActivateUnityWindow();
            return 0;
        }
        private void selectablePanel1_Resize(object sender, EventArgs e)
        {
            MoveWindow(unityHWND, 0, 0, selectablePanel.Width, selectablePanel.Height, true);
            ActivateUnityWindow();
        }
        // Close Unity application
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                process.CloseMainWindow();
                Thread.Sleep(1000);
                while (process.HasExited == false)
                    process.Kill();
            }
            catch (Exception)
            {
            }
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            ActivateUnityWindow();
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            DeactivateUnityWindow();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                process = new Process();
                process.StartInfo.FileName = game;

                process.StartInfo.Arguments = "-parentHWND " + selectablePanel.Handle.ToInt32() + " " + Environment.CommandLine;
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();

                process.WaitForInputIdle();

                // 실행이 되지 않는다면 아래 sleep 주어 Unity Game 가 로드되는 시간을 늘려 주면됩니다.
                // 시간을 주어야 실행이 가능하다.
                Thread.Sleep(5000);
                EnumChildWindows(selectablePanel.Handle, WindowEnum, IntPtr.Zero);
                SetWindowPos(process.MainWindowHandle.ToInt32(), this.Handle.ToInt32(), 0, 0, 50, 50, SWP_NOZORDER | SWP_DRAWFRAME);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ".\nCheck if Container.exe is placed next to Child.exe.");
            }
            ListenThread = new Thread(new ThreadStart(Listen));
            ListenThread.IsBackground = true;
            ListenThread.Start(); // 서버 시작
        }
        private void Listen()
        {
            Server = new TcpListener(IPAddress.Any, port); // 지정된 port로 오는 모든 IP 허용
            Client = default(TcpClient);
            try
            {
                Server.Start(); // 서버 스타트
                Console.WriteLine("Start Server");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Client = Server.AcceptTcpClient();
            NetworkStream stream = Client.GetStream(); // Client에서 GetStream
            //클라이언트에서 받아오기
            recevBuffer = new byte[2];
            stream.Read(recevBuffer, 0, recevBuffer.Length); // stream에 있던 바이트배열 내려서 새로 선언한 바이트배열에 넣기
            string cmsg = Encoding.UTF8.GetString(recevBuffer, 0, recevBuffer.Length); // byte[] to string
            Console.WriteLine("cmsg:" + cmsg);

            if (click_stage == 4 && (String.Compare("c2", cmsg) == 0))
            {
                //normal
                string data = "c2";
                MainForm.insert_ending(MainForm.loginId, MainForm.loginpw, data);
            }
            else if (click_stage == 4 && (String.Compare("cl", cmsg) == 0))
            {
                //happy
                string data = "cl";
                MainForm.insert_ending(MainForm.loginId, MainForm.loginpw, data);
            }
            if ((String.Compare("cl", cmsg) == 0) || (String.Compare("c2", cmsg) == 0))
            {
                MainForm login = new MainForm();
                login.gameclear(StageForm.data);
            }

            Server.Stop();
            Client.Close();
            stream.Close();
            SetClose();
        }
        private void SetClose()
        {
            if (this.InvokeRequired)
            {
                SetFormCloseCallback d = new SetFormCloseCallback(SetClose);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.Visible = false;
                stageForm.Closemainform();              
                this.Close();
            }
        }


        internal class FormSendDataHandler
        {
            private Action<object> dieaseUpdateEventMethod;

            public FormSendDataHandler(Action<object> dieaseUpdateEventMethod)
            {
                this.dieaseUpdateEventMethod = dieaseUpdateEventMethod;
            }
        }
    }
}