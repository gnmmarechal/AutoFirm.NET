namespace AutoFIRM.NET
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
            this.nandPathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.firm104TextBox = new System.Windows.Forms.TextBox();
            this.firmxTextBox = new System.Windows.Forms.TextBox();
            this.checker = new System.Windows.Forms.Timer(this.components);
            this.firm104CheckColor = new System.Windows.Forms.PictureBox();
            this.firmxCheckColor = new System.Windows.Forms.PictureBox();
            this.firm104StatusLabel = new System.Windows.Forms.Label();
            this.firmxStatusLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firm104CheckColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmxCheckColor)).BeginInit();
            this.SuspendLayout();
            // 
            // nandPathTextBox
            // 
            this.nandPathTextBox.Location = new System.Drawing.Point(12, 42);
            this.nandPathTextBox.Name = "nandPathTextBox";
            this.nandPathTextBox.ReadOnly = true;
            this.nandPathTextBox.Size = new System.Drawing.Size(281, 20);
            this.nandPathTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAND Image:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // firmComboBox
            // 
            this.firmComboBox.FormattingEnabled = true;
            this.firmComboBox.Items.AddRange(new object[] {
            "11.0.0",
            "11.1.0",
            "11.2.0"});
            this.firmComboBox.Location = new System.Drawing.Point(12, 100);
            this.firmComboBox.Name = "firmComboBox";
            this.firmComboBox.Size = new System.Drawing.Size(121, 21);
            this.firmComboBox.TabIndex = 4;
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Items.AddRange(new object[] {
            "Old 3DS/3DS XL/2DS",
            "New 3DS/3DS XL"});
            this.modelComboBox.Location = new System.Drawing.Point(156, 100);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(168, 21);
            this.modelComboBox.TabIndex = 5;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Firmware Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Console Model:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(480, 306);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(99, 41);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 306);
            this.progressBar.Maximum = 9;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(468, 41);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 9;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(12, 287);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(43, 13);
            this.progressLabel.TabIndex = 10;
            this.progressLabel.Text = "Waiting";
            // 
            // firm104TextBox
            // 
            this.firm104TextBox.Location = new System.Drawing.Point(12, 168);
            this.firm104TextBox.Name = "firm104TextBox";
            this.firm104TextBox.ReadOnly = true;
            this.firm104TextBox.Size = new System.Drawing.Size(281, 20);
            this.firm104TextBox.TabIndex = 11;
            // 
            // firmxTextBox
            // 
            this.firmxTextBox.Location = new System.Drawing.Point(12, 223);
            this.firmxTextBox.Name = "firmxTextBox";
            this.firmxTextBox.ReadOnly = true;
            this.firmxTextBox.Size = new System.Drawing.Size(281, 20);
            this.firmxTextBox.TabIndex = 12;
            // 
            // checker
            // 
            this.checker.Enabled = true;
            this.checker.Tick += new System.EventHandler(this.checker_Tick);
            // 
            // firm104CheckColor
            // 
            this.firm104CheckColor.Location = new System.Drawing.Point(299, 168);
            this.firm104CheckColor.Name = "firm104CheckColor";
            this.firm104CheckColor.Size = new System.Drawing.Size(45, 20);
            this.firm104CheckColor.TabIndex = 13;
            this.firm104CheckColor.TabStop = false;
            // 
            // firmxCheckColor
            // 
            this.firmxCheckColor.Location = new System.Drawing.Point(299, 223);
            this.firmxCheckColor.Name = "firmxCheckColor";
            this.firmxCheckColor.Size = new System.Drawing.Size(45, 20);
            this.firmxCheckColor.TabIndex = 14;
            this.firmxCheckColor.TabStop = false;
            // 
            // firm104StatusLabel
            // 
            this.firm104StatusLabel.AutoSize = true;
            this.firm104StatusLabel.Location = new System.Drawing.Point(350, 171);
            this.firm104StatusLabel.Name = "firm104StatusLabel";
            this.firm104StatusLabel.Size = new System.Drawing.Size(87, 13);
            this.firm104StatusLabel.TabIndex = 15;
            this.firm104StatusLabel.Text = "Status FIRM10.4";
            this.firm104StatusLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // firmxStatusLabel
            // 
            this.firmxStatusLabel.AutoSize = true;
            this.firmxStatusLabel.Location = new System.Drawing.Point(350, 226);
            this.firmxStatusLabel.Name = "firmxStatusLabel";
            this.firmxStatusLabel.Size = new System.Drawing.Size(73, 13);
            this.firmxStatusLabel.TabIndex = 16;
            this.firmxStatusLabel.Text = "Status FIRMX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 359);
            this.Controls.Add(this.firmxStatusLabel);
            this.Controls.Add(this.firm104StatusLabel);
            this.Controls.Add(this.firmxCheckColor);
            this.Controls.Add(this.firm104CheckColor);
            this.Controls.Add(this.firmxTextBox);
            this.Controls.Add(this.firm104TextBox);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.firmComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nandPathTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AutoFIRM.NET - vX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firm104CheckColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmxCheckColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nandPathTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox firmComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.TextBox firm104TextBox;
        private System.Windows.Forms.TextBox firmxTextBox;
        private System.Windows.Forms.Timer checker;
        private System.Windows.Forms.PictureBox firm104CheckColor;
        private System.Windows.Forms.PictureBox firmxCheckColor;
        private System.Windows.Forms.Label firm104StatusLabel;
        private System.Windows.Forms.Label firmxStatusLabel;
    }
}

