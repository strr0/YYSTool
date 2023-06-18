
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
            this.label_mode1_prefix = new System.Windows.Forms.Label();
            this.textBox_mode1 = new System.Windows.Forms.TextBox();
            this.label_mode1_suffix = new System.Windows.Forms.Label();
            this.label_mode2_prefix = new System.Windows.Forms.Label();
            this.textBox_mode2 = new System.Windows.Forms.TextBox();
            this.label_mode2_suffix = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_app
            // 
            this.label_app.AutoSize = true;
            this.label_app.Location = new System.Drawing.Point(35, 36);
            this.label_app.Name = "label_app";
            this.label_app.Size = new System.Drawing.Size(67, 15);
            this.label_app.TabIndex = 0;
            this.label_app.Text = "应用名称";
            // 
            // textBox_app
            // 
            this.textBox_app.Location = new System.Drawing.Point(118, 33);
            this.textBox_app.Name = "textBox_app";
            this.textBox_app.Size = new System.Drawing.Size(211, 25);
            this.textBox_app.TabIndex = 1;
            // 
            // textBox_top
            // 
            this.textBox_top.Location = new System.Drawing.Point(537, 11);
            this.textBox_top.Name = "textBox_top";
            this.textBox_top.Size = new System.Drawing.Size(100, 25);
            this.textBox_top.TabIndex = 2;
            // 
            // textBox_bottom
            // 
            this.textBox_bottom.Location = new System.Drawing.Point(537, 126);
            this.textBox_bottom.Name = "textBox_bottom";
            this.textBox_bottom.Size = new System.Drawing.Size(100, 25);
            this.textBox_bottom.TabIndex = 3;
            // 
            // textBox_left
            // 
            this.textBox_left.Location = new System.Drawing.Point(399, 69);
            this.textBox_left.Name = "textBox_left";
            this.textBox_left.Size = new System.Drawing.Size(100, 25);
            this.textBox_left.TabIndex = 4;
            // 
            // textBox_right
            // 
            this.textBox_right.Location = new System.Drawing.Point(669, 69);
            this.textBox_right.Name = "textBox_right";
            this.textBox_right.Size = new System.Drawing.Size(100, 25);
            this.textBox_right.TabIndex = 5;
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(163, 85);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(98, 23);
            this.button_get.TabIndex = 6;
            this.button_get.Text = "获取位置";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(260, 184);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(75, 23);
            this.button_move.TabIndex = 7;
            this.button_move.Text = "移动";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(97, 185);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(100, 25);
            this.textBox_x.TabIndex = 8;
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(97, 237);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(100, 25);
            this.textBox_y.TabIndex = 9;
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(260, 239);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(75, 23);
            this.button_test.TabIndex = 10;
            this.button_test.Text = "测试";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(49, 188);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(15, 15);
            this.label_x.TabIndex = 11;
            this.label_x.Text = "x";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(49, 243);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(15, 15);
            this.label_y.TabIndex = 12;
            this.label_y.Text = "y";
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(467, 212);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(100, 25);
            this.textBox_time.TabIndex = 13;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(396, 216);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(37, 15);
            this.label_time.TabIndex = 14;
            this.label_time.Text = "时间";
            // 
            // textBox_span
            // 
            this.textBox_span.Location = new System.Drawing.Point(669, 213);
            this.textBox_span.Name = "textBox_span";
            this.textBox_span.Size = new System.Drawing.Size(100, 25);
            this.textBox_span.TabIndex = 15;
            // 
            // label_span
            // 
            this.label_span.AutoSize = true;
            this.label_span.Location = new System.Drawing.Point(606, 216);
            this.label_span.Name = "label_span";
            this.label_span.Size = new System.Drawing.Size(37, 15);
            this.label_span.TabIndex = 16;
            this.label_span.Text = "范围";
            // 
            // radioButton_mode1
            // 
            this.radioButton_mode1.AutoSize = true;
            this.radioButton_mode1.Location = new System.Drawing.Point(80, 323);
            this.radioButton_mode1.Name = "radioButton_mode1";
            this.radioButton_mode1.Size = new System.Drawing.Size(73, 19);
            this.radioButton_mode1.TabIndex = 17;
            this.radioButton_mode1.TabStop = true;
            this.radioButton_mode1.Text = "模式一";
            this.radioButton_mode1.UseVisualStyleBackColor = true;
            // 
            // radioButton_mode2
            // 
            this.radioButton_mode2.AutoSize = true;
            this.radioButton_mode2.Location = new System.Drawing.Point(80, 366);
            this.radioButton_mode2.Name = "radioButton_mode2";
            this.radioButton_mode2.Size = new System.Drawing.Size(73, 19);
            this.radioButton_mode2.TabIndex = 18;
            this.radioButton_mode2.TabStop = true;
            this.radioButton_mode2.Text = "模式二";
            this.radioButton_mode2.UseVisualStyleBackColor = true;
            // 
            // label_mode1_prefix
            // 
            this.label_mode1_prefix.AutoSize = true;
            this.label_mode1_prefix.Location = new System.Drawing.Point(209, 326);
            this.label_mode1_prefix.Name = "label_mode1_prefix";
            this.label_mode1_prefix.Size = new System.Drawing.Size(52, 15);
            this.label_mode1_prefix.TabIndex = 19;
            this.label_mode1_prefix.Text = "在执行";
            // 
            // textBox_mode1
            // 
            this.textBox_mode1.Location = new System.Drawing.Point(267, 322);
            this.textBox_mode1.Name = "textBox_mode1";
            this.textBox_mode1.Size = new System.Drawing.Size(100, 25);
            this.textBox_mode1.TabIndex = 20;
            // 
            // label_mode1_suffix
            // 
            this.label_mode1_suffix.AutoSize = true;
            this.label_mode1_suffix.Location = new System.Drawing.Point(373, 326);
            this.label_mode1_suffix.Name = "label_mode1_suffix";
            this.label_mode1_suffix.Size = new System.Drawing.Size(82, 15);
            this.label_mode1_suffix.TabIndex = 21;
            this.label_mode1_suffix.Text = "分钟后结束";
            // 
            // label_mode2_prefix
            // 
            this.label_mode2_prefix.AutoSize = true;
            this.label_mode2_prefix.Location = new System.Drawing.Point(209, 368);
            this.label_mode2_prefix.Name = "label_mode2_prefix";
            this.label_mode2_prefix.Size = new System.Drawing.Size(52, 15);
            this.label_mode2_prefix.TabIndex = 22;
            this.label_mode2_prefix.Text = "在执行";
            // 
            // textBox_mode2
            // 
            this.textBox_mode2.Location = new System.Drawing.Point(267, 365);
            this.textBox_mode2.Name = "textBox_mode2";
            this.textBox_mode2.Size = new System.Drawing.Size(100, 25);
            this.textBox_mode2.TabIndex = 23;
            // 
            // label_mode2_suffix
            // 
            this.label_mode2_suffix.AutoSize = true;
            this.label_mode2_suffix.Location = new System.Drawing.Point(376, 368);
            this.label_mode2_suffix.Name = "label_mode2_suffix";
            this.label_mode2_suffix.Size = new System.Drawing.Size(67, 15);
            this.label_mode2_suffix.TabIndex = 24;
            this.label_mode2_suffix.Text = "次后结束";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(520, 342);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 25;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(654, 341);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 26;
            this.button_stop.Text = "结束(&q)";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // YYSToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_mode2_suffix);
            this.Controls.Add(this.textBox_mode2);
            this.Controls.Add(this.label_mode2_prefix);
            this.Controls.Add(this.label_mode1_suffix);
            this.Controls.Add(this.textBox_mode1);
            this.Controls.Add(this.label_mode1_prefix);
            this.Controls.Add(this.radioButton_mode2);
            this.Controls.Add(this.radioButton_mode1);
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
            this.Name = "YYSToolForm";
            this.Text = "YYSTool";
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
        private System.Windows.Forms.Label label_mode1_prefix;
        private System.Windows.Forms.TextBox textBox_mode1;
        private System.Windows.Forms.Label label_mode1_suffix;
        private System.Windows.Forms.Label label_mode2_prefix;
        private System.Windows.Forms.TextBox textBox_mode2;
        private System.Windows.Forms.Label label_mode2_suffix;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
    }
}

