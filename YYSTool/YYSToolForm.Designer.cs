
namespace YYSTool
{
    partial class YYSToolForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_app = new System.Windows.Forms.Label();
            this.textBox_app = new System.Windows.Forms.TextBox();
            this.textBox_top = new System.Windows.Forms.TextBox();
            this.textBox_bottom = new System.Windows.Forms.TextBox();
            this.textBox_left = new System.Windows.Forms.TextBox();
            this.textBox_right = new System.Windows.Forms.TextBox();
            this.button_get = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.button_test = new System.Windows.Forms.Button();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            this.textBox_span = new System.Windows.Forms.TextBox();
            this.label_span = new System.Windows.Forms.Label();
            this.radioButton_mode1 = new System.Windows.Forms.RadioButton();
            this.radioButton_mode2 = new System.Windows.Forms.RadioButton();
            this.label_mode1 = new System.Windows.Forms.Label();
            this.textBox_mode1 = new System.Windows.Forms.TextBox();
            this.label_mode2 = new System.Windows.Forms.Label();
            this.textBox_mode2 = new System.Windows.Forms.TextBox();
            this.label_mode2_unit = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.label_time_unit = new System.Windows.Forms.Label();
            this.radioButton_mode1_unit_h = new System.Windows.Forms.RadioButton();
            this.radioButton_mode1_unit_m = new System.Windows.Forms.RadioButton();
            this.radioButton_mode1_unit_s = new System.Windows.Forms.RadioButton();
            this.groupBox_mode = new System.Windows.Forms.GroupBox();
            this.groupBox_mode1_unit = new System.Windows.Forms.GroupBox();
            this.label_x_from = new System.Windows.Forms.Label();
            this.label_x_to = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_y_to = new System.Windows.Forms.Label();
            this.groupBox_mode.SuspendLayout();
            this.groupBox_mode1_unit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_app
            // 
            this.label_app.AutoSize = true;
            this.label_app.Location = new System.Drawing.Point(20, 29);
            this.label_app.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_app.Name = "label_app";
            this.label_app.Size = new System.Drawing.Size(53, 12);
            this.label_app.TabIndex = 0;
            this.label_app.Text = "应用名称";
            // 
            // textBox_app
            // 
            this.textBox_app.Location = new System.Drawing.Point(82, 26);
            this.textBox_app.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_app.Name = "textBox_app";
            this.textBox_app.Size = new System.Drawing.Size(159, 21);
            this.textBox_app.TabIndex = 1;
            // 
            // textBox_top
            // 
            this.textBox_top.Location = new System.Drawing.Point(330, 68);
            this.textBox_top.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_top.Name = "textBox_top";
            this.textBox_top.Size = new System.Drawing.Size(80, 21);
            this.textBox_top.TabIndex = 2;
            // 
            // textBox_bottom
            // 
            this.textBox_bottom.Location = new System.Drawing.Point(431, 68);
            this.textBox_bottom.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_bottom.Name = "textBox_bottom";
            this.textBox_bottom.Size = new System.Drawing.Size(80, 21);
            this.textBox_bottom.TabIndex = 3;
            // 
            // textBox_left
            // 
            this.textBox_left.Location = new System.Drawing.Point(330, 26);
            this.textBox_left.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_left.Name = "textBox_left";
            this.textBox_left.Size = new System.Drawing.Size(80, 21);
            this.textBox_left.TabIndex = 4;
            // 
            // textBox_right
            // 
            this.textBox_right.Location = new System.Drawing.Point(431, 26);
            this.textBox_right.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_right.Name = "textBox_right";
            this.textBox_right.Size = new System.Drawing.Size(80, 21);
            this.textBox_right.TabIndex = 5;
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(116, 68);
            this.button_get.Margin = new System.Windows.Forms.Padding(2);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(74, 18);
            this.button_get.TabIndex = 6;
            this.button_get.Text = "获取范围";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(194, 123);
            this.button_move.Margin = new System.Windows.Forms.Padding(2);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(56, 18);
            this.button_move.TabIndex = 7;
            this.button_move.Text = "移动";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(72, 124);
            this.textBox_x.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(76, 21);
            this.textBox_x.TabIndex = 8;
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(72, 166);
            this.textBox_y.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(76, 21);
            this.textBox_y.TabIndex = 9;
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(194, 167);
            this.button_test.Margin = new System.Windows.Forms.Padding(2);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(56, 18);
            this.button_test.TabIndex = 10;
            this.button_test.Text = "测试";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(36, 126);
            this.label_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(11, 12);
            this.label_x.TabIndex = 11;
            this.label_x.Text = "x";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(36, 170);
            this.label_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(11, 12);
            this.label_y.TabIndex = 12;
            this.label_y.Text = "y";
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(354, 124);
            this.textBox_time.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(112, 21);
            this.textBox_time.TabIndex = 13;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(290, 127);
            this.label_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(53, 12);
            this.label_time.TabIndex = 14;
            this.label_time.Text = "时间间隔";
            // 
            // textBox_span
            // 
            this.textBox_span.Location = new System.Drawing.Point(356, 161);
            this.textBox_span.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_span.Name = "textBox_span";
            this.textBox_span.Size = new System.Drawing.Size(110, 21);
            this.textBox_span.TabIndex = 15;
            // 
            // label_span
            // 
            this.label_span.AutoSize = true;
            this.label_span.Location = new System.Drawing.Point(290, 167);
            this.label_span.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_span.Name = "label_span";
            this.label_span.Size = new System.Drawing.Size(53, 12);
            this.label_span.TabIndex = 16;
            this.label_span.Text = "点击范围";
            // 
            // radioButton_mode1
            // 
            this.radioButton_mode1.AutoSize = true;
            this.radioButton_mode1.Location = new System.Drawing.Point(5, 23);
            this.radioButton_mode1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_mode1.Name = "radioButton_mode1";
            this.radioButton_mode1.Size = new System.Drawing.Size(59, 16);
            this.radioButton_mode1.TabIndex = 17;
            this.radioButton_mode1.TabStop = true;
            this.radioButton_mode1.Text = "模式一";
            this.radioButton_mode1.UseVisualStyleBackColor = true;
            // 
            // radioButton_mode2
            // 
            this.radioButton_mode2.AutoSize = true;
            this.radioButton_mode2.Location = new System.Drawing.Point(5, 54);
            this.radioButton_mode2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_mode2.Name = "radioButton_mode2";
            this.radioButton_mode2.Size = new System.Drawing.Size(59, 16);
            this.radioButton_mode2.TabIndex = 18;
            this.radioButton_mode2.TabStop = true;
            this.radioButton_mode2.Text = "模式二";
            this.radioButton_mode2.UseVisualStyleBackColor = true;
            // 
            // label_mode1
            // 
            this.label_mode1.AutoSize = true;
            this.label_mode1.Location = new System.Drawing.Point(119, 233);
            this.label_mode1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mode1.Name = "label_mode1";
            this.label_mode1.Size = new System.Drawing.Size(29, 12);
            this.label_mode1.TabIndex = 19;
            this.label_mode1.Text = "执行";
            // 
            // textBox_mode1
            // 
            this.textBox_mode1.Location = new System.Drawing.Point(162, 230);
            this.textBox_mode1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_mode1.Name = "textBox_mode1";
            this.textBox_mode1.Size = new System.Drawing.Size(76, 21);
            this.textBox_mode1.TabIndex = 20;
            // 
            // label_mode2
            // 
            this.label_mode2.AutoSize = true;
            this.label_mode2.Location = new System.Drawing.Point(119, 266);
            this.label_mode2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mode2.Name = "label_mode2";
            this.label_mode2.Size = new System.Drawing.Size(29, 12);
            this.label_mode2.TabIndex = 22;
            this.label_mode2.Text = "执行";
            // 
            // textBox_mode2
            // 
            this.textBox_mode2.Location = new System.Drawing.Point(162, 264);
            this.textBox_mode2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_mode2.Name = "textBox_mode2";
            this.textBox_mode2.Size = new System.Drawing.Size(184, 21);
            this.textBox_mode2.TabIndex = 23;
            // 
            // label_mode2_unit
            // 
            this.label_mode2_unit.AutoSize = true;
            this.label_mode2_unit.Location = new System.Drawing.Point(361, 266);
            this.label_mode2_unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mode2_unit.Name = "label_mode2_unit";
            this.label_mode2_unit.Size = new System.Drawing.Size(17, 12);
            this.label_mode2_unit.TabIndex = 24;
            this.label_mode2_unit.Text = "次";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(457, 227);
            this.button_start.Margin = new System.Windows.Forms.Padding(2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(56, 18);
            this.button_start.TabIndex = 25;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(457, 260);
            this.button_stop.Margin = new System.Windows.Forms.Padding(2);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(56, 18);
            this.button_stop.TabIndex = 26;
            this.button_stop.Text = "结束(&q)";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label_time_unit
            // 
            this.label_time_unit.AutoSize = true;
            this.label_time_unit.Location = new System.Drawing.Point(483, 127);
            this.label_time_unit.Name = "label_time_unit";
            this.label_time_unit.Size = new System.Drawing.Size(17, 12);
            this.label_time_unit.TabIndex = 27;
            this.label_time_unit.Text = "秒";
            // 
            // radioButton_mode1_unit_h
            // 
            this.radioButton_mode1_unit_h.AutoSize = true;
            this.radioButton_mode1_unit_h.Location = new System.Drawing.Point(6, 20);
            this.radioButton_mode1_unit_h.Name = "radioButton_mode1_unit_h";
            this.radioButton_mode1_unit_h.Size = new System.Drawing.Size(47, 16);
            this.radioButton_mode1_unit_h.TabIndex = 28;
            this.radioButton_mode1_unit_h.TabStop = true;
            this.radioButton_mode1_unit_h.Text = "小时";
            this.radioButton_mode1_unit_h.UseVisualStyleBackColor = true;
            // 
            // radioButton_mode1_unit_m
            // 
            this.radioButton_mode1_unit_m.AutoSize = true;
            this.radioButton_mode1_unit_m.Location = new System.Drawing.Point(59, 20);
            this.radioButton_mode1_unit_m.Name = "radioButton_mode1_unit_m";
            this.radioButton_mode1_unit_m.Size = new System.Drawing.Size(47, 16);
            this.radioButton_mode1_unit_m.TabIndex = 29;
            this.radioButton_mode1_unit_m.TabStop = true;
            this.radioButton_mode1_unit_m.Text = "分钟";
            this.radioButton_mode1_unit_m.UseVisualStyleBackColor = true;
            // 
            // radioButton_mode1_unit_s
            // 
            this.radioButton_mode1_unit_s.AutoSize = true;
            this.radioButton_mode1_unit_s.Location = new System.Drawing.Point(112, 20);
            this.radioButton_mode1_unit_s.Name = "radioButton_mode1_unit_s";
            this.radioButton_mode1_unit_s.Size = new System.Drawing.Size(35, 16);
            this.radioButton_mode1_unit_s.TabIndex = 30;
            this.radioButton_mode1_unit_s.TabStop = true;
            this.radioButton_mode1_unit_s.Text = "秒";
            this.radioButton_mode1_unit_s.UseVisualStyleBackColor = true;
            // 
            // groupBox_mode
            // 
            this.groupBox_mode.Controls.Add(this.radioButton_mode1);
            this.groupBox_mode.Controls.Add(this.radioButton_mode2);
            this.groupBox_mode.Location = new System.Drawing.Point(27, 210);
            this.groupBox_mode.Name = "groupBox_mode";
            this.groupBox_mode.Size = new System.Drawing.Size(87, 88);
            this.groupBox_mode.TabIndex = 31;
            this.groupBox_mode.TabStop = false;
            // 
            // groupBox_mode1_unit
            // 
            this.groupBox_mode1_unit.Controls.Add(this.radioButton_mode1_unit_h);
            this.groupBox_mode1_unit.Controls.Add(this.radioButton_mode1_unit_m);
            this.groupBox_mode1_unit.Controls.Add(this.radioButton_mode1_unit_s);
            this.groupBox_mode1_unit.Location = new System.Drawing.Point(243, 213);
            this.groupBox_mode1_unit.Name = "groupBox_mode1_unit";
            this.groupBox_mode1_unit.Size = new System.Drawing.Size(158, 46);
            this.groupBox_mode1_unit.TabIndex = 32;
            this.groupBox_mode1_unit.TabStop = false;
            // 
            // label_x_from
            // 
            this.label_x_from.AutoSize = true;
            this.label_x_from.Location = new System.Drawing.Point(280, 29);
            this.label_x_from.Name = "label_x_from";
            this.label_x_from.Size = new System.Drawing.Size(35, 12);
            this.label_x_from.TabIndex = 33;
            this.label_x_from.Text = "x范围";
            // 
            // label_x_to
            // 
            this.label_x_to.AutoSize = true;
            this.label_x_to.Location = new System.Drawing.Point(415, 32);
            this.label_x_to.Name = "label_x_to";
            this.label_x_to.Size = new System.Drawing.Size(11, 12);
            this.label_x_to.TabIndex = 34;
            this.label_x_to.Text = "-";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(280, 74);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(35, 12);
            this.label_from.TabIndex = 35;
            this.label_from.Text = "y范围";
            // 
            // label_y_to
            // 
            this.label_y_to.AutoSize = true;
            this.label_y_to.Location = new System.Drawing.Point(415, 71);
            this.label_y_to.Name = "label_y_to";
            this.label_y_to.Size = new System.Drawing.Size(11, 12);
            this.label_y_to.TabIndex = 36;
            this.label_y_to.Text = "-";
            // 
            // YYSToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 310);
            this.Controls.Add(this.label_y_to);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.label_x_to);
            this.Controls.Add(this.label_x_from);
            this.Controls.Add(this.groupBox_mode1_unit);
            this.Controls.Add(this.groupBox_mode);
            this.Controls.Add(this.label_time_unit);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_mode2_unit);
            this.Controls.Add(this.textBox_mode2);
            this.Controls.Add(this.label_mode2);
            this.Controls.Add(this.textBox_mode1);
            this.Controls.Add(this.label_mode1);
            this.Controls.Add(this.label_span);
            this.Controls.Add(this.textBox_span);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.button_move);
            this.Controls.Add(this.button_get);
            this.Controls.Add(this.textBox_right);
            this.Controls.Add(this.textBox_left);
            this.Controls.Add(this.textBox_bottom);
            this.Controls.Add(this.textBox_top);
            this.Controls.Add(this.textBox_app);
            this.Controls.Add(this.label_app);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "YYSToolForm";
            this.Text = "YYSTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YYSToolForm_FormClosing);
            this.groupBox_mode.ResumeLayout(false);
            this.groupBox_mode.PerformLayout();
            this.groupBox_mode1_unit.ResumeLayout(false);
            this.groupBox_mode1_unit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_app;
        private System.Windows.Forms.TextBox textBox_app;
        private System.Windows.Forms.TextBox textBox_top;
        private System.Windows.Forms.TextBox textBox_bottom;
        private System.Windows.Forms.TextBox textBox_left;
        private System.Windows.Forms.TextBox textBox_right;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.TextBox textBox_span;
        private System.Windows.Forms.Label label_span;
        private System.Windows.Forms.RadioButton radioButton_mode1;
        private System.Windows.Forms.RadioButton radioButton_mode2;
        private System.Windows.Forms.Label label_mode1;
        private System.Windows.Forms.TextBox textBox_mode1;
        private System.Windows.Forms.Label label_mode2;
        private System.Windows.Forms.TextBox textBox_mode2;
        private System.Windows.Forms.Label label_mode2_unit;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label_time_unit;
        private System.Windows.Forms.RadioButton radioButton_mode1_unit_h;
        private System.Windows.Forms.RadioButton radioButton_mode1_unit_m;
        private System.Windows.Forms.RadioButton radioButton_mode1_unit_s;
        private System.Windows.Forms.GroupBox groupBox_mode;
        private System.Windows.Forms.GroupBox groupBox_mode1_unit;
        private System.Windows.Forms.Label label_x_from;
        private System.Windows.Forms.Label label_x_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_y_to;
    }
}

