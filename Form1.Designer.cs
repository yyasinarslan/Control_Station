namespace Control_Station
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblObstacle = new System.Windows.Forms.Label();
            this.btnGO = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.radiobtnManuel = new System.Windows.Forms.RadioButton();
            this.radiobtnAuto = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Lime;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForward.Location = new System.Drawing.Point(204, 25);
            this.btnForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(161, 63);
            this.btnForward.TabIndex = 0;
            this.btnForward.Text = "FORWARD";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackward.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackward.Location = new System.Drawing.Point(204, 212);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(161, 63);
            this.btnBackward.TabIndex = 1;
            this.btnBackward.Text = "BACKWARD";
            this.btnBackward.UseVisualStyleBackColor = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Location = new System.Drawing.Point(204, 118);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(161, 63);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Target Angle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Target Distance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Last Command Given:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Current Mode:";
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLeft.Location = new System.Drawing.Point(15, 118);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(161, 63);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRight.Location = new System.Drawing.Point(389, 118);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(161, 63);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblObstacle);
            this.groupBox1.Controls.Add(this.btnGO);
            this.groupBox1.Controls.Add(this.btnForward);
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnBackward);
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(53, 316);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(565, 310);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ControlCommands";
            this.groupBox1.Visible = false;
            // 
            // lblObstacle
            // 
            this.lblObstacle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObstacle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblObstacle.Location = new System.Drawing.Point(119, 192);
            this.lblObstacle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObstacle.Name = "lblObstacle";
            this.lblObstacle.Size = new System.Drawing.Size(336, 82);
            this.lblObstacle.TabIndex = 15;
            this.lblObstacle.Text = "An obstacle has been detected, \r\nthe halt mechanism activated! \r\nWaiting for a ne" +
    "w command..";
            this.lblObstacle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGO
            // 
            this.btnGO.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGO.Location = new System.Drawing.Point(204, 118);
            this.btnGO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(161, 63);
            this.btnGO.TabIndex = 14;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblHumidity);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblTemperature);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(624, 316);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(309, 310);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 16);
            this.label18.TabIndex = 19;
            this.label18.Text = "Humidity:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(188, 107);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(14, 16);
            this.lblHumidity.TabIndex = 18;
            this.lblHumidity.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Temperature:";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(188, 71);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(14, 16);
            this.lblTemperature.TabIndex = 16;
            this.lblTemperature.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Speed:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(188, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "CPU Temperature:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(1023, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 59);
            this.button1.TabIndex = 16;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // radiobtnManuel
            // 
            this.radiobtnManuel.AutoSize = true;
            this.radiobtnManuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtnManuel.Location = new System.Drawing.Point(123, 23);
            this.radiobtnManuel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiobtnManuel.Name = "radiobtnManuel";
            this.radiobtnManuel.Size = new System.Drawing.Size(142, 28);
            this.radiobtnManuel.TabIndex = 29;
            this.radiobtnManuel.TabStop = true;
            this.radiobtnManuel.Text = "Manuel Drive";
            this.radiobtnManuel.UseVisualStyleBackColor = true;
            this.radiobtnManuel.CheckedChanged += new System.EventHandler(this.radiobtnManuel_CheckedChanged);
            // 
            // radiobtnAuto
            // 
            this.radiobtnAuto.AutoSize = true;
            this.radiobtnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtnAuto.Location = new System.Drawing.Point(305, 23);
            this.radiobtnAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiobtnAuto.Name = "radiobtnAuto";
            this.radiobtnAuto.Size = new System.Drawing.Size(187, 28);
            this.radiobtnAuto.TabIndex = 30;
            this.radiobtnAuto.TabStop = true;
            this.radiobtnAuto.Text = "Autonomous Drive";
            this.radiobtnAuto.UseVisualStyleBackColor = true;
            this.radiobtnAuto.CheckedChanged += new System.EventHandler(this.radiobtnAuto_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "\"Slower\"",
            "\"Slow\"",
            "\"Normal\"",
            "\"Fast\"",
            "\"Faster\""});
            this.listBox1.Location = new System.Drawing.Point(41, 64);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(117, 112);
            this.listBox1.TabIndex = 31;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radiobtnAuto);
            this.groupBox3.Controls.Add(this.radiobtnManuel);
            this.groupBox3.Location = new System.Drawing.Point(53, 47);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(611, 66);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode Selection";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(36, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Speed Setting";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(212, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 18);
            this.label13.TabIndex = 35;
            this.label13.Text = "Target Distance (cm)";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Control;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "20",
            "40"});
            this.listBox2.Location = new System.Drawing.Point(247, 64);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(117, 112);
            this.listBox2.TabIndex = 34;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.listBox3);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Location = new System.Drawing.Point(53, 121);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(644, 190);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(416, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 18);
            this.label16.TabIndex = 37;
            this.label16.Text = "Target Angle (degrees)";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.Control;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 18;
            this.listBox3.Items.AddRange(new object[] {
            "-90",
            "-30",
            "0",
            "30",
            "90"});
            this.listBox3.Location = new System.Drawing.Point(460, 64);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(117, 112);
            this.listBox3.TabIndex = 36;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1468, 709);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    //    private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.RadioButton radiobtnManuel;
        private System.Windows.Forms.RadioButton radiobtnAuto;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Label lblObstacle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTemperature;
    }
}

