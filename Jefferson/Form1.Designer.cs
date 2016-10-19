namespace Jefferson {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ctlModernBlack1 = new jSkin.ctlModernBlack();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tab = new System.Windows.Forms.TabControl();
            this.encPage = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fastLoadTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EncMessage = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.CodeNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CylinerPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CylinersNumber = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DecPage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.RealMessage = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.DecCode = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EncMessageToDec = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EncMessageToDece = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Upper = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ctlModernBlack1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Tab.SuspendLayout();
            this.encPage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DecPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Upper.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlModernBlack1
            // 
            this.ctlModernBlack1.Controls.Add(this.panel1);
            this.ctlModernBlack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlModernBlack1.FixedSingle = false;
            this.ctlModernBlack1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctlModernBlack1.Location = new System.Drawing.Point(0, 0);
            this.ctlModernBlack1.Name = "ctlModernBlack1";
            this.ctlModernBlack1.Size = new System.Drawing.Size(797, 561);
            this.ctlModernBlack1.Stretch = false;
            this.ctlModernBlack1.TabIndex = 0;
            this.ctlModernBlack1.Load += new System.EventHandler(this.ctlModernBlack1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Tab);
            this.panel1.Controls.Add(this.Upper);
            this.panel1.Location = new System.Drawing.Point(10, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 518);
            this.panel1.TabIndex = 3;
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.encPage);
            this.Tab.Controls.Add(this.DecPage);
            this.Tab.Location = new System.Drawing.Point(69, 3);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(703, 512);
            this.Tab.TabIndex = 3;
            // 
            // encPage
            // 
            this.encPage.BackColor = System.Drawing.Color.White;
            this.encPage.ContextMenuStrip = this.contextMenuStrip1;
            this.encPage.Controls.Add(this.label11);
            this.encPage.Controls.Add(this.groupBox7);
            this.encPage.Controls.Add(this.groupBox3);
            this.encPage.Controls.Add(this.groupBox2);
            this.encPage.Controls.Add(this.CylinerPanel);
            this.encPage.Controls.Add(this.groupBox1);
            this.encPage.Controls.Add(this.panel2);
            this.encPage.Location = new System.Drawing.Point(4, 22);
            this.encPage.Name = "encPage";
            this.encPage.Padding = new System.Windows.Forms.Padding(3);
            this.encPage.Size = new System.Drawing.Size(695, 486);
            this.encPage.TabIndex = 0;
            this.encPage.Text = "tabPage1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastLoadTextToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // fastLoadTextToolStripMenuItem
            // 
            this.fastLoadTextToolStripMenuItem.Name = "fastLoadTextToolStripMenuItem";
            this.fastLoadTextToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fastLoadTextToolStripMenuItem.Text = "Fast Load Text";
            this.fastLoadTextToolStripMenuItem.Click += new System.EventHandler(this.fastLoadTextToolStripMenuItem_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Location = new System.Drawing.Point(247, 100);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(402, 92);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Fast Load Text";
            this.groupBox7.Visible = false;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(370, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(24, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "X";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(298, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "Load";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 30);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Location = new System.Drawing.Point(195, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 153);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.EncMessage);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.Message);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 134);
            this.panel4.TabIndex = 14;
            // 
            // EncMessage
            // 
            this.EncMessage.AutoSize = true;
            this.EncMessage.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncMessage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.EncMessage.Location = new System.Drawing.Point(106, 52);
            this.EncMessage.Name = "EncMessage";
            this.EncMessage.Size = new System.Drawing.Size(120, 24);
            this.EncMessage.TabIndex = 12;
            this.EncMessage.Text = "EncMessage ";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(358, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "Send";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(260, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 29);
            this.button7.TabIndex = 13;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Message.Location = new System.Drawing.Point(106, 12);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(121, 24);
            this.Message.TabIndex = 11;
            this.Message.Text = "RealMessage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 35);
            this.label6.TabIndex = 9;
            this.label6.Text = "Message :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 35);
            this.label7.TabIndex = 10;
            this.label7.Text = "Encyript :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.CodeNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(7, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 150);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decription";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(9, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CodeNumber
            // 
            this.CodeNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeNumber.Location = new System.Drawing.Point(70, 59);
            this.CodeNumber.Name = "CodeNumber";
            this.CodeNumber.Size = new System.Drawing.Size(36, 30);
            this.CodeNumber.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Code :";
            // 
            // CylinerPanel
            // 
            this.CylinerPanel.AutoScroll = true;
            this.CylinerPanel.Location = new System.Drawing.Point(7, 198);
            this.CylinerPanel.Name = "CylinerPanel";
            this.CylinerPanel.Size = new System.Drawing.Size(679, 82);
            this.CylinerPanel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CylinersNumber);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(7, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cylinders :";
            // 
            // CylinersNumber
            // 
            this.CylinersNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylinersNumber.Location = new System.Drawing.Point(135, 22);
            this.CylinersNumber.Name = "CylinersNumber";
            this.CylinersNumber.Size = new System.Drawing.Size(46, 30);
            this.CylinersNumber.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(55, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 58);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tekton Pro Ext", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "  Jefferson Encryption";
            // 
            // DecPage
            // 
            this.DecPage.BackColor = System.Drawing.Color.White;
            this.DecPage.Controls.Add(this.groupBox6);
            this.DecPage.Controls.Add(this.groupBox5);
            this.DecPage.Controls.Add(this.groupBox4);
            this.DecPage.Controls.Add(this.panel3);
            this.DecPage.Controls.Add(this.label1);
            this.DecPage.Location = new System.Drawing.Point(4, 22);
            this.DecPage.Name = "DecPage";
            this.DecPage.Padding = new System.Windows.Forms.Padding(3);
            this.DecPage.Size = new System.Drawing.Size(695, 486);
            this.DecPage.TabIndex = 1;
            this.DecPage.Text = "tabPage2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel6);
            this.groupBox6.Location = new System.Drawing.Point(15, 368);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(671, 76);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Real Message";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.RealMessage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(665, 57);
            this.panel6.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 27);
            this.label9.TabIndex = 5;
            this.label9.Text = "The Real Message";
            // 
            // RealMessage
            // 
            this.RealMessage.AutoSize = true;
            this.RealMessage.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealMessage.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.RealMessage.Location = new System.Drawing.Point(185, 11);
            this.RealMessage.Name = "RealMessage";
            this.RealMessage.Size = new System.Drawing.Size(107, 23);
            this.RealMessage.TabIndex = 4;
            this.RealMessage.Text = "RealMessage";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.DecCode);
            this.groupBox5.Location = new System.Drawing.Point(15, 205);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(165, 112);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Converter";
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(11, 67);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(129, 29);
            this.button8.TabIndex = 7;
            this.button8.Text = "Convert";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 27);
            this.label10.TabIndex = 8;
            this.label10.Text = "Code";
            // 
            // DecCode
            // 
            this.DecCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecCode.Location = new System.Drawing.Point(71, 32);
            this.DecCode.Name = "DecCode";
            this.DecCode.Size = new System.Drawing.Size(58, 27);
            this.DecCode.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel5);
            this.groupBox4.Location = new System.Drawing.Point(15, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(674, 105);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.EncMessageToDec);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.EncMessageToDece);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(668, 86);
            this.panel5.TabIndex = 6;
            // 
            // EncMessageToDec
            // 
            this.EncMessageToDec.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncMessageToDec.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.EncMessageToDec.Location = new System.Drawing.Point(206, 10);
            this.EncMessageToDec.Multiline = true;
            this.EncMessageToDec.Name = "EncMessageToDec";
            this.EncMessageToDec.Size = new System.Drawing.Size(459, 59);
            this.EncMessageToDec.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 27);
            this.label8.TabIndex = 5;
            this.label8.Text = "Encyripted Message :";
            // 
            // EncMessageToDece
            // 
            this.EncMessageToDece.AutoSize = true;
            this.EncMessageToDece.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.EncMessageToDece.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.EncMessageToDece.Location = new System.Drawing.Point(83, 47);
            this.EncMessageToDece.Name = "EncMessageToDece";
            this.EncMessageToDece.Size = new System.Drawing.Size(54, 22);
            this.EncMessageToDece.TabIndex = 4;
            this.EncMessageToDece.Text = "label8";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 58);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tekton Pro Ext", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(199, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "  Jefferson Decryption";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tekton Pro Ext", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jefferson Encryption";
            // 
            // Upper
            // 
            this.Upper.BackColor = System.Drawing.Color.Transparent;
            this.Upper.Controls.Add(this.panel7);
            this.Upper.Controls.Add(this.button1);
            this.Upper.Controls.Add(this.button2);
            this.Upper.Dock = System.Windows.Forms.DockStyle.Left;
            this.Upper.Location = new System.Drawing.Point(0, 0);
            this.Upper.Name = "Upper";
            this.Upper.Size = new System.Drawing.Size(63, 518);
            this.Upper.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(54, 214);
            this.panel7.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Jefferson.Properties.Resources.enc;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 51);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Jefferson.Properties.Resources.dec;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 53);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(324, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(363, 14);
            this.label11.TabIndex = 13;
            this.label11.Text = "محمد علي عبد الحميد محمد - سكشن 3 - قسم علوم الحاسب";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 561);
            this.Controls.Add(this.ctlModernBlack1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "  Jefferson Encryption";
            this.ctlModernBlack1.ResumeLayout(false);
            this.ctlModernBlack1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.encPage.ResumeLayout(false);
            this.encPage.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.DecPage.ResumeLayout(false);
            this.DecPage.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Upper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private jSkin.ctlModernBlack ctlModernBlack1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel Upper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage encPage;
        private System.Windows.Forms.TabPage DecPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox CodeNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel CylinerPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CylinersNumber;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label EncMessage;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label RealMessage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DecCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EncMessageToDece;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fastLoadTextToolStripMenuItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox EncMessageToDec;
        private System.Windows.Forms.Label label11;
    }
}

