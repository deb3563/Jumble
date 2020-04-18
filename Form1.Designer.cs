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
            this.answer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sizeGroup = new System.Windows.Forms.GroupBox();
            this.sixButton = new System.Windows.Forms.RadioButton();
            this.fiveButton = new System.Windows.Forms.RadioButton();
            this.player1Box = new System.Windows.Forms.TextBox();
            this.player2Box = new System.Windows.Forms.TextBox();
            this.player1AddButto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sizeGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // letters
            // 
            this.letters.AutoSize = true;
            this.letters.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letters.Location = new System.Drawing.Point(393, 125);
            this.letters.Name = "letters";
            this.letters.Size = new System.Drawing.Size(1137, 378);
            this.letters.TabIndex = 0;
            this.letters.Text = "           ";
            // 
            // answerBox
            // 
            this.answerBox.AutoSize = true;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.Location = new System.Drawing.Point(437, 550);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(369, 180);
            this.answerBox.TabIndex = 1;
            this.answerBox.Text = "       ";
            this.answerBox.Visible = false;
            // 
            // getJumble
            // 
            this.getJumble.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getJumble.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getJumble.Location = new System.Drawing.Point(357, 32);
            this.getJumble.Name = "getJumble";
            this.getJumble.Padding = new System.Windows.Forms.Padding(10);
            this.getJumble.Size = new System.Drawing.Size(295, 82);
            this.getJumble.TabIndex = 2;
            this.getJumble.Text = "Get Jumble";
            this.getJumble.UseVisualStyleBackColor = false;
            this.getJumble.Click += new System.EventHandler(this.getJumble_Click);
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(895, 36);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(271, 74);
            this.answer.TabIndex = 3;
            this.answer.Text = "ANSWER";
            this.answer.UseVisualStyleBackColor = false;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // sizeGroup
            // 
            this.sizeGroup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sizeGroup.Controls.Add(this.sixButton);
            this.sizeGroup.Controls.Add(this.fiveButton);
            this.sizeGroup.Location = new System.Drawing.Point(10, 11);
            this.sizeGroup.Name = "sizeGroup";
            this.sizeGroup.Size = new System.Drawing.Size(178, 80);
            this.sizeGroup.TabIndex = 5;
            this.sizeGroup.TabStop = false;
            this.sizeGroup.Text = "Select Size";
            // 
            // sixButton
            // 
            this.sixButton.AutoSize = true;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(97, 21);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(48, 33);
            this.sixButton.TabIndex = 1;
            this.sixButton.TabStop = true;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            // 
            // fiveButton
            // 
            this.fiveButton.AutoSize = true;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(30, 21);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(48, 33);
            this.fiveButton.TabIndex = 0;
            this.fiveButton.TabStop = true;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            // 
            // player1Box
            // 
            this.player1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Box.Location = new System.Drawing.Point(14, 27);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(135, 36);
            this.player1Box.TabIndex = 6;
            this.player1Box.Text = "PLAYER 1";
            // 
            // player2Box
            // 
            this.player2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Box.Location = new System.Drawing.Point(175, 27);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(137, 36);
            this.player2Box.TabIndex = 7;
            this.player2Box.Text = "PLAYER 2";
            // 
            // player1AddButto
            // 
            this.player1AddButto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.player1AddButto.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1AddButto.Location = new System.Drawing.Point(14, 189);
            this.player1AddButto.Name = "player1AddButto";
            this.player1AddButto.Size = new System.Drawing.Size(131, 72);
            this.player1AddButto.TabIndex = 8;
            this.player1AddButto.Text = "+";
            this.player1AddButto.UseVisualStyleBackColor = false;
            this.player1AddButto.Click += new System.EventHandler(this.player1AddButto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(175, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(53, 98);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(62, 67);
            this.player1Label.TabIndex = 10;
            this.player1Label.Text = "0";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(203, 98);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(62, 67);
            this.player2Label.TabIndex = 11;
            this.player2Label.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.player2Label);
            this.panel1.Controls.Add(this.player1Label);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.player1AddButto);
            this.panel1.Controls.Add(this.player2Box);
            this.panel1.Controls.Add(this.player1Box);
            this.panel1.Location = new System.Drawing.Point(46, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 354);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.sizeGroup);
            this.panel2.Location = new System.Drawing.Point(671, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 99);
            this.panel2.TabIndex = 13;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(89, 267);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 72);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1741, 815);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.getJumble);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.letters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sizeGroup.ResumeLayout(false);
            this.sizeGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label letters;
        private System.Windows.Forms.Label answerBox;
        private System.Windows.Forms.Button getJumble;
        private System.Windows.Forms.Button answer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox sizeGroup;
        private System.Windows.Forms.RadioButton sixButton;
        private System.Windows.Forms.RadioButton fiveButton;
        private System.Windows.Forms.TextBox player1Box;
        private System.Windows.Forms.TextBox player2Box;
        private System.Windows.Forms.Button player1AddButto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearButton;
    }
}

