using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// win32api
using System.Runtime.InteropServices;

namespace YYSTool
{
    public partial class YYSToolForm : Form
    {
        //private IntPtr yysHWnd;
        // 定时器
        private System.Timers.Timer timer;
        // 任务参数
        private int yysX;
        private int yysY;
        private double yysTime;
        private int yysSpan;
        private double yysTotalTime;
        private double yysCostTime;
        private int yysTotalCount;
        private int yysCostCount;
        // 随机点击次数
        private Random random;
        private int randomTimes;
        private int secondClick;

        public YYSToolForm()
        {
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            textBox_app.Text = "阴阳师-网易游戏";
            textBox_top.Text = "189";
            textBox_left.Text = "384";
            textBox_bottom.Text = "868";
            textBox_right.Text = "1536";
            textBox_x.Text = "1435";
            textBox_y.Text = "780";
            textBox_time.Text = "11";
            textBox_span.Text = "30";
            textBox_mode1.Text = "1";
            textBox_mode2.Text = "1000";
            radioButton_mode1.Checked = true;
            radioButton_mode1_unit_h.Checked = true;
            button_stop.Enabled = false;
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            string appText = textBox_app.Text;
            if (appText == "")
            {
                return;
            }
            IntPtr hWnd = Win32Api.FindWindow(null, appText);
            if (hWnd == IntPtr.Zero)
            {
                MessageBox.Show("没有找到程序" + appText);
                return;
            }
            //yysHWnd = hWnd;
            Win32Api.Rect lpRect = new Win32Api.Rect();
            Win32Api.GetWindowRect(hWnd, out lpRect);
            textBox_top.Text = Convert.ToString(lpRect.Top);
            textBox_left.Text = Convert.ToString(lpRect.Left);
            textBox_bottom.Text = Convert.ToString(lpRect.Bottom);
            textBox_right.Text = Convert.ToString(lpRect.Right);
        }

        private void button_move_Click(object sender, EventArgs e)
        {
            string xText = textBox_x.Text;
            string yText = textBox_y.Text;
            if (xText.Trim() == "" || yText.Trim() == "")
            {
                return;
            }
            int x = Convert.ToInt32(xText);
            int y = Convert.ToInt32(yText);
            Win32Api.SetCursorPos(x, y);
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            string xText = textBox_x.Text;
            string yText = textBox_y.Text;
            if (xText.Trim() == "" || yText.Trim() == "")
            {
                return;
            }
            int x = Convert.ToInt32(xText);
            int y = Convert.ToInt32(yText);
            click(x, y);
        }

        private void click(int x, int y)
        {
            Win32Api.SetCursorPos(x, y);
            Win32Api.mouse_event(0x0002, 0, 0, 0, 0);
            Win32Api.mouse_event(0x0004, 0, 0, 0, 0);
            //int point = y << 16 | x;
            //Win32Api.SendMessage(yysHWnd, 0x0201, 0x0001, point);
            //Win32Api.SendMessage(yysHWnd, 0x0202, 0x0001, point);
        }

        private void randClick()
        {
            int dx = random.Next(-yysSpan, yysSpan);
            int ySpan = yysSpan - System.Math.Abs(dx);
            int dy = random.Next(-ySpan, ySpan);
            click(yysX + dx, yysY + dy);
        }

        private void initTaskArgs()
        {
            if (textBox_x.Text != "")
            {
                yysX = Convert.ToInt32(textBox_x.Text);
            }
            if (textBox_y.Text != "")
            {
                yysY = Convert.ToInt32(textBox_y.Text);
            }
            if (textBox_time.Text != "")
            {
                yysTime = Convert.ToDouble(textBox_time.Text) * 1000;
            }
            if (textBox_span.Text != "")
            {
                yysSpan = Convert.ToInt32(textBox_span.Text);
            }
            random = new Random();
            randomTimes = 1;
            secondClick = 1;
        }

        private void mode1Task(object sender, System.Timers.ElapsedEventArgs e)
        {
            randClick();
            yysCostTime += timer.Interval;
            if (randomTimes == 0)
            {
                randomTimes = random.Next(4, 7);  // 随机点击4-7次
                if (secondClick == 0)
                {
                    timer.Interval = yysTime + random.Next(0, 500);
                    secondClick = 1;
                }
                else
                {
                    timer.Interval = random.Next(700, 1000);
                    secondClick = 0;
                }
            }
            else
            {
                timer.Interval = random.Next(300, 500);
                randomTimes--;
            }
            if (yysCostTime >= yysTotalTime)
            {
                timer.Stop();
                timer.Close();
                timer = null;
                button_start.Text = "开始";
                button_start.Enabled = true;
                button_stop.Enabled = false;
            }
        }

        private void mode2Task(object sender, System.Timers.ElapsedEventArgs e)
        {
            randClick();
            yysCostCount++;
            if (randomTimes == 0)
            {
                randomTimes = random.Next(4, 7);  // 随机点击4-7次
                timer.Interval = yysTime + random.Next(0, 500);
            }
            else
            {
                timer.Interval = random.Next(300, 500);
                randomTimes--;
            }
            if (yysCostCount >= yysTotalCount)
            {
                timer.Stop();
                timer.Close();
                timer = null;
                button_start.Text = "开始";
                button_start.Enabled = true;
                button_stop.Enabled = false;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            button_stop.Text = "暂停";
            button_stop.Enabled = true;
            IntPtr hWnd = Win32Api.FindWindow(null, textBox_app.Text);
            if (hWnd == IntPtr.Zero)
            {
                MessageBox.Show("没有找到程序" + textBox_app.Text);
                return;
            }
            //yysHWnd = hWnd;
            Win32Api.SetForegroundWindow(hWnd);
            // 初始化定时器
            if (timer == null)
            {
                // 初始化任务参数
                initTaskArgs();
                timer = new System.Timers.Timer();
                timer.AutoReset = true;
                timer.Interval = yysTime;
            }
            else
            {
                timer.Start();
                return;
            }
            // 模式一
            if (radioButton_mode1.Checked)
            {
                // 时间
                if (textBox_mode1.Text != "")
                {
                    double time = Convert.ToDouble(textBox_mode1.Text);
                    if (radioButton_mode1_unit_h.Checked)
                    {
                        yysTotalTime = time * 3600000;
                    }
                    if (radioButton_mode1_unit_m.Checked)
                    {
                        yysTotalTime = time * 60000;
                    }
                    if (radioButton_mode1_unit_s.Checked)
                    {
                        yysTotalTime = time * 1000;
                    }
                }
                if (yysTotalTime == 0)
                {
                    return;
                }
                yysCostTime = 0;
                timer.Elapsed += new System.Timers.ElapsedEventHandler(mode1Task);
                timer.Start();
                return;
            }
            // 模式二
            if (radioButton_mode2.Checked)
            {
                // 次数
                if (textBox_mode2.Text != "")
                {
                    yysTotalCount = Convert.ToInt32(textBox_mode2.Text);
                }
                if (yysTotalCount == 0)
                {
                    return;
                }
                yysCostCount = 0;
                timer.Elapsed += new System.Timers.ElapsedEventHandler(mode2Task);
                timer.Start();
                return;
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                if (timer.Enabled)
                {
                    button_start.Text = "继续";
                    button_start.Enabled = true;
                    button_stop.Text = "结束";
                    timer.Stop();
                }
                else
                {
                    button_start.Text = "开始";
                    button_stop.Enabled = false;
                    timer.Close();
                    timer = null;
                }
            }
        }

        // 窗口关闭事件
        private void YYSToolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                if (timer.Enabled)
                {
                    timer.Stop();
                }
                timer.Close();
            }
        }
    }

    // win32api封装
    public static class Win32Api
    {
        // 寻找窗口
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // 获取窗口坐标
        [DllImport("user32.dll")]
        public static extern int GetWindowRect(IntPtr hWnd, out Rect lpRect);

        public struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        // 获取子窗口
        [DllImport("user32.dll")]
        public static extern bool EnumChildWindows(IntPtr hWndParent, EnumWindowsProc lpEnumProc, IntPtr lParam);

        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        // 设置到前台
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);

        // 移动鼠标
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        // 发送指令
        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        // 鼠标点击
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
    }
}
