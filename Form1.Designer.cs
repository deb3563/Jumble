namespace Jumble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.letters = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.Label();
            this.getJumble = new System.Windows.Forms.Button();
            this.player1AddButto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.sizeGroup = new System.Windows.Forms.GroupBox();
            this.fiveButton = new System.Windows.Forms.RadioButton();
            this.sixButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sizeGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // letters
            // 
            this.letters.AutoSize = true;
            this.letters.BackColor = System.Drawing.Color.Transparent;
            this.letters.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letters.Location = new System.Drawing.Point(210, 2);
            this.letters.Name = "letters";
            this.letters.Size = new System.Drawing.Size(1137, 378);
            this.letters.TabIndex = 0;
            this.letters.Text = "           ";
            // 
            // answerBox
            // 
            this.answerBox.AutoSize = true;
            this.answerBox.BackColor = System.Drawing.Color.Transparent;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.Location = new System.Drawing.Point(444, 380);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(369, 180);
            this.answerBox.TabIndex = 1;
            this.answerBox.Text = "       ";
            // 
            // getJumble
            // 
            this.getJumble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.getJumble.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getJumble.Location = new System.Drawing.Point(13, 12);
            this.getJumble.Name = "getJumble";
            this.getJumble.Padding = new System.Windows.Forms.Padding(10);
            this.getJumble.Size = new System.Drawing.Size(539, 82);
            this.getJumble.TabIndex = 2;
            this.getJumble.Text = "Get Jumble";
            this.getJumble.UseVisualStyleBackColor = false;
            this.getJumble.Click += new System.EventHandler(this.getJumble_Click);
            // 
            // player1AddButto
            // 
            this.player1AddButto.BackColor = System.Drawing.Color.Transparent;
            this.player1AddButto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player1AddButto.BackgroundImage")));
            this.player1AddButto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player1AddButto.FlatAppearance.BorderSize = 0;
            this.player1AddButto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.player1AddButto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.player1AddButto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player1AddButto.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1AddButto.ForeColor = System.Drawing.Color.Transparent;
            this.player1AddButto.Location = new System.Drawing.Point(273, 553);
            this.player1AddButto.Name = "player1AddButto";
            this.player1AddButto.Size = new System.Drawing.Size(218, 218);
            this.player1AddButto.TabIndex = 8;
            this.player1AddButto.UseVisualStyleBackColor = false;
            this.player1AddButto.Click += new System.EventHandler(this.player1AddButto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1069, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 228);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.BackColor = System.Drawing.Color.Transparent;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(355, 793);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(62, 67);
            this.player1Label.TabIndex = 10;
            this.player1Label.Text = "0";
            this.player1Label.Click += new System.EventHandler(this.player1Label_Click);
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.BackColor = System.Drawing.Color.Transparent;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(1134, 793);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(62, 67);
            this.player2Label.TabIndex = 11;
            this.player2Label.Text = "0";
            this.player2Label.Click += new System.EventHandler(this.player2Label_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(3, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 72);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Reset Points";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sizeGroup
            // 
            this.sizeGroup.BackColor = System.Drawing.Color.Transparent;
            this.sizeGroup.Controls.Add(this.sixButton);
            this.sizeGroup.Controls.Add(this.fiveButton);
            this.sizeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeGroup.Location = new System.Drawing.Point(535, 793);
            this.sizeGroup.Name = "sizeGroup";
            this.sizeGroup.Size = new System.Drawing.Size(246, 80);
            this.sizeGroup.TabIndex = 5;
            this.sizeGroup.TabStop = false;
            this.sizeGroup.Text = "Select Word Size";
            // 
            // fiveButton
            // 
            this.fiveButton.AutoSize = true;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(61, 35);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(48, 33);
            this.fiveButton.TabIndex = 0;
            this.fiveButton.TabStop = true;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            // 
            // sixButton
            // 
            this.sixButton.AutoSize = true;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(124, 35);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(48, 33);
            this.sixButton.TabIndex = 1;
            this.sixButton.TabStop = true;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Location = new System.Drawing.Point(810, 793);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 82);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.getJumble);
            this.panel1.Location = new System.Drawing.Point(474, 646);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 109);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1741, 1047);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sizeGroup);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.player1AddButto);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.letters);
            this.Name = "Form1";
            this.Text = "Jumble";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sizeGroup.ResumeLayout(false);
            this.sizeGroup.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label letters;
        private System.Windows.Forms.Label answerBox;
        private System.Windows.Forms.Button getJumble;
        private System.Windows.Forms.Button player1AddButto;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox sizeGroup;
        private System.Windows.Forms.RadioButton sixButton;
        private System.Windows.Forms.RadioButton fiveButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

