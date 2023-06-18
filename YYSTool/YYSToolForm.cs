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
        private int randomTimes;

        public YYSToolForm()
        {
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            textBox_app.Text = "阴阳师-网易游戏";
            textBox_top.Text = "81";
            textBox_left.Text = "192";
            textBox_bottom.Text = "760";
            textBox_right.Text = "1344";
            textBox_x.Text = "1235";
            textBox_y.Text = "630";
            textBox_time.Text = "1000";
            textBox_span.Text = "30";
            textBox_mode1.Text = "3600000";
            textBox_mode2.Text = "1000";
            radioButton_mode2.Checked = true;
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
            Win32Api.SetCursorPos(x, y);
            click();
        }

        private void click()
        {
            Win32Api.mouse_event(0x0002, 0, 0, 0, 0);
            Win32Api.mouse_event(0x0004, 0, 0, 0, 0);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = Win32Api.FindWindow(null, textBox_app.Text);
            if (hWnd == IntPtr.Zero)
            {
                MessageBox.Show("没有找到程序" + textBox_app.Text);
                return;
            }
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
                if (yysTotalTime == 0)
                {
                    return;
                }
                timer.Elapsed += new System.Timers.ElapsedEventHandler(mode1Task);
                timer.Start();
                return;
            }
            // 模式二
            if (radioButton_mode2.Checked)
            {
                // 次数
                if (yysTotalCount == 0)
                {
                    return;
                }
                timer.Elapsed += new System.Timers.ElapsedEventHandler(mode2Task);
                timer.Start();
                return;
            }
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
                yysTime = Convert.ToDouble(textBox_time.Text);
            }
            if (textBox_span.Text != "")
            {
                yysSpan = Convert.ToInt32(textBox_span.Text);
            }
            if (textBox_mode1.Text != "")
            {
                yysTotalTime = Convert.ToDouble(textBox_mode1.Text);
            }
            if (textBox_mode2.Text != "")
            {
                yysTotalCount = Convert.ToInt32(textBox_mode2.Text);
            }
            yysCostTime = 0;
            yysCostCount = 0;
            randomTimes = 1;
        }

        private void mode1Task(object sender, System.Timers.ElapsedEventArgs e)
        {
            randClick();
            yysCostTime += timer.Interval;
            Random random = new Random();
            if (randomTimes == 0)
            {
                randomTimes = random.Next(4, 7);  // 随机点击4-7次
                timer.Interval = yysTime + random.Next(-250, 250);
            }
            else
            {
                timer.Interval = random.Next(100, 300);
                randomTimes--;
            }
            if (yysCostTime >= yysTotalTime)
            {
                timer.Stop();
            }
        }

        private void mode2Task(object sender, System.Timers.ElapsedEventArgs e)
        {
            randClick();
            yysCostCount++;
            Random random = new Random();
            if (randomTimes == 0)
            {
                randomTimes = random.Next(4, 7);  // 随机点击4-7次
                timer.Interval = yysTime + random.Next(-250, 250);
            }
            else
            {
                timer.Interval = random.Next(100, 300);
                randomTimes--;
            }
            if (yysCostCount >= yysTotalCount)
            {
                timer.Stop();
            }
        }

        private void randClick()
        {
            Random random = new Random();
            int dx = random.Next(-yysSpan, yysSpan);
            int ySpan = yysSpan - System.Math.Abs(dx);
            int dy = random.Next(-ySpan, ySpan);
            Win32Api.SetCursorPos(yysX + dx, yysY + dy);
            click();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
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
