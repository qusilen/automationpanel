using System.Windows.Forms;

namespace lastpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.homePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.pullDataPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.caseLabel = new System.Windows.Forms.Label();
            this.caseButton = new System.Windows.Forms.Button();
            this.switchButton = new System.Windows.Forms.Button();
            this.pushButton = new System.Windows.Forms.Button();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.motorLabel = new System.Windows.Forms.Label();
            this.sendDataPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shortTextBox = new System.Windows.Forms.TextBox();
            this.shortLabel = new System.Windows.Forms.Label();
            this.floatLabel = new System.Windows.Forms.Label();
            this.floatTextBox = new System.Windows.Forms.TextBox();
            this.pullDataTimer = new System.Windows.Forms.Timer(this.components);
            this.shortTimer = new System.Windows.Forms.Timer(this.components);
            this.floatTimer = new System.Windows.Forms.Timer(this.components);
            this.switchTimer = new System.Windows.Forms.Timer(this.components);
            this.pushTimer = new System.Windows.Forms.Timer(this.components);
            this.caseTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pullDataScreen = new System.Windows.Forms.Button();
            this.sendDataScreen = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.alarmPanel = new System.Windows.Forms.Panel();
            this.alarmLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.receteButton = new System.Windows.Forms.Button();
            this.recipePanel = new System.Windows.Forms.Panel();
            this.recipeDelButton = new System.Windows.Forms.Button();
            this.newRecipeButton = new System.Windows.Forms.Button();
            this.dbDataSendButton = new System.Windows.Forms.Button();
            this.dbDataPullButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dbTimer = new System.Windows.Forms.Timer(this.components);
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pullDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.sendDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.alarmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.recipePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.label2);
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(this.pictureBox2);
            this.homePanel.Controls.Add(this.pictureBox1);
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1920, 923);
            this.homePanel.TabIndex = 0;
            this.homePanel.Click += new System.EventHandler(this.homePanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(940, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "ANA SAYFA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(878, 813);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Lütfen ekrana dokunun!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1019, 746);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(983, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connectionLabel.Location = new System.Drawing.Point(195, 937);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(122, 32);
            this.connectionLabel.TabIndex = 5;
            this.connectionLabel.Text = "DURUM";
            // 
            // pullDataPanel
            // 
            this.pullDataPanel.Controls.Add(this.pictureBox4);
            this.pullDataPanel.Controls.Add(this.label3);
            this.pullDataPanel.Controls.Add(this.caseLabel);
            this.pullDataPanel.Controls.Add(this.caseButton);
            this.pullDataPanel.Controls.Add(this.switchButton);
            this.pullDataPanel.Controls.Add(this.pushButton);
            this.pullDataPanel.Controls.Add(this.temperatureTextBox);
            this.pullDataPanel.Controls.Add(this.temperatureLabel);
            this.pullDataPanel.Controls.Add(this.motorLabel);
            this.pullDataPanel.Location = new System.Drawing.Point(0, 0);
            this.pullDataPanel.Name = "pullDataPanel";
            this.pullDataPanel.Size = new System.Drawing.Size(1920, 923);
            this.pullDataPanel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(357, 200);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1013, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 41;
            this.label3.Text = "VERİ ÇEK";
            // 
            // caseLabel
            // 
            this.caseLabel.AutoSize = true;
            this.caseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.caseLabel.Location = new System.Drawing.Point(1377, 446);
            this.caseLabel.Name = "caseLabel";
            this.caseLabel.Size = new System.Drawing.Size(131, 32);
            this.caseLabel.TabIndex = 40;
            this.caseLabel.Text = "DURUM:";
            // 
            // caseButton
            // 
            this.caseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.caseButton.Location = new System.Drawing.Point(1383, 480);
            this.caseButton.Name = "caseButton";
            this.caseButton.Size = new System.Drawing.Size(125, 48);
            this.caseButton.TabIndex = 39;
            this.caseButton.Text = "button";
            this.caseButton.UseVisualStyleBackColor = true;
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(974, 481);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(175, 59);
            this.switchButton.TabIndex = 38;
            this.switchButton.Text = "SWITCH";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // pushButton
            // 
            this.pushButton.Location = new System.Drawing.Point(974, 416);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(175, 59);
            this.pushButton.TabIndex = 37;
            this.pushButton.Text = "PUSH";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            this.pushButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pushButton_MouseDown);
            this.pushButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pushButton_MouseUp);
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temperatureTextBox.Location = new System.Drawing.Point(520, 416);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(171, 38);
            this.temperatureTextBox.TabIndex = 36;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temperatureLabel.Location = new System.Drawing.Point(357, 422);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(157, 32);
            this.temperatureLabel.TabIndex = 34;
            this.temperatureLabel.Text = "SICAKLIK:";
            // 
            // motorLabel
            // 
            this.motorLabel.AutoSize = true;
            this.motorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motorLabel.Location = new System.Drawing.Point(544, 367);
            this.motorLabel.Name = "motorLabel";
            this.motorLabel.Size = new System.Drawing.Size(123, 32);
            this.motorLabel.TabIndex = 33;
            this.motorLabel.Text = "MOTOR";
            // 
            // sendDataPanel
            // 
            this.sendDataPanel.Controls.Add(this.pictureBox3);
            this.sendDataPanel.Controls.Add(this.label4);
            this.sendDataPanel.Controls.Add(this.shortTextBox);
            this.sendDataPanel.Controls.Add(this.shortLabel);
            this.sendDataPanel.Controls.Add(this.floatLabel);
            this.sendDataPanel.Controls.Add(this.floatTextBox);
            this.sendDataPanel.Location = new System.Drawing.Point(0, 0);
            this.sendDataPanel.Name = "sendDataPanel";
            this.sendDataPanel.Size = new System.Drawing.Size(1920, 923);
            this.sendDataPanel.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(357, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(900, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "VERİ GÖNDER";
            // 
            // shortTextBox
            // 
            this.shortTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.shortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shortTextBox.Location = new System.Drawing.Point(637, 353);
            this.shortTextBox.Name = "shortTextBox";
            this.shortTextBox.Size = new System.Drawing.Size(171, 38);
            this.shortTextBox.TabIndex = 30;
            this.shortTextBox.Click += new System.EventHandler(this.shortTextBox_Click);
            this.shortTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shortTextBox_KeyDown);
            // 
            // shortLabel
            // 
            this.shortLabel.AutoSize = true;
            this.shortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shortLabel.Location = new System.Drawing.Point(575, 309);
            this.shortLabel.Name = "shortLabel";
            this.shortLabel.Size = new System.Drawing.Size(345, 32);
            this.shortLabel.TabIndex = 31;
            this.shortLabel.Text = "SHORT DEĞER GİRİNİZ";
            // 
            // floatLabel
            // 
            this.floatLabel.AutoSize = true;
            this.floatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floatLabel.Location = new System.Drawing.Point(1098, 309);
            this.floatLabel.Name = "floatLabel";
            this.floatLabel.Size = new System.Drawing.Size(338, 32);
            this.floatLabel.TabIndex = 34;
            this.floatLabel.Text = "FLOAT DEĞER GİRİNİZ";
            // 
            // floatTextBox
            // 
            this.floatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.floatTextBox.Location = new System.Drawing.Point(1160, 353);
            this.floatTextBox.Name = "floatTextBox";
            this.floatTextBox.Size = new System.Drawing.Size(171, 38);
            this.floatTextBox.TabIndex = 33;
            this.floatTextBox.Click += new System.EventHandler(this.floatTextBox_Click);
            this.floatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.floatTextBox_KeyDown);
            // 
            // pullDataTimer
            // 
            this.pullDataTimer.Interval = 1000;
            this.pullDataTimer.Tick += new System.EventHandler(this.pull_data_timer_Tick);
            // 
            // shortTimer
            // 
            this.shortTimer.Interval = 1000;
            this.shortTimer.Tick += new System.EventHandler(this.short_timer_Tick);
            // 
            // floatTimer
            // 
            this.floatTimer.Interval = 1000;
            this.floatTimer.Tick += new System.EventHandler(this.float_timer_Tick);
            // 
            // switchTimer
            // 
            this.switchTimer.Interval = 1000;
            this.switchTimer.Tick += new System.EventHandler(this.switchTimer_Tick);
            // 
            // pushTimer
            // 
            this.pushTimer.Interval = 1000;
            this.pushTimer.Tick += new System.EventHandler(this.pushTimer_Tick);
            // 
            // caseTimer
            // 
            this.caseTimer.Interval = 1000;
            this.caseTimer.Tick += new System.EventHandler(this.caseTimer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(750, 943);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 76);
            this.button1.TabIndex = 33;
            this.button1.Text = "ANA SAYFA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pullDataScreen
            // 
            this.pullDataScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pullDataScreen.Location = new System.Drawing.Point(1178, 943);
            this.pullDataScreen.Name = "pullDataScreen";
            this.pullDataScreen.Size = new System.Drawing.Size(208, 76);
            this.pullDataScreen.TabIndex = 33;
            this.pullDataScreen.Text = "VERİ ÇEK";
            this.pullDataScreen.UseVisualStyleBackColor = true;
            this.pullDataScreen.Click += new System.EventHandler(this.button2_Click);
            // 
            // sendDataScreen
            // 
            this.sendDataScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendDataScreen.Location = new System.Drawing.Point(1392, 943);
            this.sendDataScreen.Name = "sendDataScreen";
            this.sendDataScreen.Size = new System.Drawing.Size(208, 76);
            this.sendDataScreen.TabIndex = 33;
            this.sendDataScreen.Text = "VERİ GÖNDER";
            this.sendDataScreen.UseVisualStyleBackColor = true;
            this.sendDataScreen.Click += new System.EventHandler(this.sendDataScreen_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(1682, 943);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 76);
            this.button4.TabIndex = 33;
            this.button4.Text = "ALARM RESET";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ipBox
            // 
            this.ipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipBox.Location = new System.Drawing.Point(190, 972);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(221, 38);
            this.ipBox.TabIndex = 34;
            this.ipBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ipBox_KeyDown);
            // 
            // alarmPanel
            // 
            this.alarmPanel.Controls.Add(this.alarmLabel);
            this.alarmPanel.Controls.Add(this.dataGridView1);
            this.alarmPanel.Location = new System.Drawing.Point(0, 0);
            this.alarmPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.alarmPanel.Name = "alarmPanel";
            this.alarmPanel.Size = new System.Drawing.Size(1920, 200);
            this.alarmPanel.TabIndex = 36;
            // 
            // alarmLabel
            // 
            this.alarmLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alarmLabel.BackColor = System.Drawing.Color.Yellow;
            this.alarmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alarmLabel.ForeColor = System.Drawing.Color.Black;
            this.alarmLabel.Location = new System.Drawing.Point(3, 0);
            this.alarmLabel.Name = "alarmLabel";
            this.alarmLabel.Size = new System.Drawing.Size(362, 200);
            this.alarmLabel.TabIndex = 37;
            this.alarmLabel.Text = "ALARM";
            this.alarmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(363, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1557, 200);
            this.dataGridView1.TabIndex = 36;
            // 
            // alarmTimer
            // 
            this.alarmTimer.Interval = 500;
            this.alarmTimer.Tick += new System.EventHandler(this.alarm_Tick);
            // 
            // receteButton
            // 
            this.receteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.receteButton.Location = new System.Drawing.Point(964, 943);
            this.receteButton.Name = "receteButton";
            this.receteButton.Size = new System.Drawing.Size(208, 76);
            this.receteButton.TabIndex = 37;
            this.receteButton.Text = "REÇETELER";
            this.receteButton.UseVisualStyleBackColor = true;
            this.receteButton.Click += new System.EventHandler(this.receteButton_Click);
            // 
            // recipePanel
            // 
            this.recipePanel.Controls.Add(this.recipeDelButton);
            this.recipePanel.Controls.Add(this.newRecipeButton);
            this.recipePanel.Controls.Add(this.dbDataSendButton);
            this.recipePanel.Controls.Add(this.dbDataPullButton);
            this.recipePanel.Controls.Add(this.groupBox1);
            this.recipePanel.Controls.Add(this.label5);
            this.recipePanel.Controls.Add(this.pictureBox5);
            this.recipePanel.Location = new System.Drawing.Point(0, 0);
            this.recipePanel.Name = "recipePanel";
            this.recipePanel.Size = new System.Drawing.Size(1920, 923);
            this.recipePanel.TabIndex = 38;
            // 
            // recipeDelButton
            // 
            this.recipeDelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recipeDelButton.Location = new System.Drawing.Point(1280, 619);
            this.recipeDelButton.Name = "recipeDelButton";
            this.recipeDelButton.Size = new System.Drawing.Size(130, 80);
            this.recipeDelButton.TabIndex = 48;
            this.recipeDelButton.Text = "Reçete Sil";
            this.recipeDelButton.UseVisualStyleBackColor = true;
            this.recipeDelButton.Click += new System.EventHandler(this.recipeDelButton_Click);
            // 
            // newRecipeButton
            // 
            this.newRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newRecipeButton.Location = new System.Drawing.Point(1280, 538);
            this.newRecipeButton.Name = "newRecipeButton";
            this.newRecipeButton.Size = new System.Drawing.Size(130, 75);
            this.newRecipeButton.TabIndex = 46;
            this.newRecipeButton.Text = "Yeni Reçete Oluştur";
            this.newRecipeButton.UseVisualStyleBackColor = true;
            this.newRecipeButton.Click += new System.EventHandler(this.newReceteButton_Click);
            // 
            // dbDataSendButton
            // 
            this.dbDataSendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dbDataSendButton.Location = new System.Drawing.Point(1280, 453);
            this.dbDataSendButton.Name = "dbDataSendButton";
            this.dbDataSendButton.Size = new System.Drawing.Size(130, 80);
            this.dbDataSendButton.TabIndex = 45;
            this.dbDataSendButton.Text = "Parametreleri Makineye Gönder";
            this.dbDataSendButton.UseVisualStyleBackColor = true;
            this.dbDataSendButton.Click += new System.EventHandler(this.dbDataSendButton_Click);
            // 
            // dbDataPullButton
            // 
            this.dbDataPullButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dbDataPullButton.Location = new System.Drawing.Point(1280, 367);
            this.dbDataPullButton.Name = "dbDataPullButton";
            this.dbDataPullButton.Size = new System.Drawing.Size(130, 80);
            this.dbDataPullButton.TabIndex = 44;
            this.dbDataPullButton.Text = "Parametreleri Makineden Çek";
            this.dbDataPullButton.UseVisualStyleBackColor = true;
            this.dbDataPullButton.Click += new System.EventHandler(this.dbDataPullButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(540, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 438);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(665, 274);
            this.dataGridView2.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Veri Kümesinin Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(615, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "No:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(572, 24);
            this.comboBox1.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(619, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 22);
            this.textBox1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(918, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "REÇETE SAYFASI";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(357, 200);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // dbTimer
            // 
            this.dbTimer.Interval = 1000;
            this.dbTimer.Tick += new System.EventHandler(this.dbTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.receteButton);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pullDataScreen);
            this.Controls.Add(this.sendDataScreen);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.recipePanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.alarmPanel);
            this.Controls.Add(this.sendDataPanel);
            this.Controls.Add(this.pullDataPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pullDataPanel.ResumeLayout(false);
            this.pullDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.sendDataPanel.ResumeLayout(false);
            this.sendDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.alarmPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.recipePanel.ResumeLayout(false);
            this.recipePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel pullDataPanel;
        private System.Windows.Forms.Panel sendDataPanel;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Timer pullDataTimer;
        private System.Windows.Forms.Timer shortTimer;
        private System.Windows.Forms.Timer floatTimer;
        private System.Windows.Forms.Timer switchTimer;
        private System.Windows.Forms.Timer pushTimer;
        private System.Windows.Forms.Timer caseTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pullDataScreen;
        private System.Windows.Forms.Button sendDataScreen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label caseLabel;
        private System.Windows.Forms.Button caseButton;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label motorLabel;
        private System.Windows.Forms.Label shortLabel;
        private System.Windows.Forms.Label floatLabel;
        private System.Windows.Forms.TextBox floatTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox shortTextBox;
        private TextBox ipBox;
        private Panel alarmPanel;
        private DataGridView dataGridView1;
        private Timer alarmTimer;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label alarmLabel;
        private Button receteButton;
        private Panel recipePanel;
        private PictureBox pictureBox5;
        private ComboBox comboBox1;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Button recipeDelButton;
        private Button newRecipeButton;
        private Button dbDataSendButton;
        private Button dbDataPullButton;
        private Timer dbTimer;
    }
}

