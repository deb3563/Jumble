namespace Jumble_Generator
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
            this.wordText = new System.Windows.Forms.Label();
            this.getJumble = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sizeGroup = new System.Windows.Forms.GroupBox();
            this.sixButton = new System.Windows.Forms.RadioButton();
            this.fiveButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sizeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // letters
            // 
            this.letters.AutoSize = true;
            this.letters.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letters.Location = new System.Drawing.Point(322, 133);
            this.letters.Name = "letters";
            this.letters.Size = new System.Drawing.Size(1137, 378);
            this.letters.TabIndex = 0;
            this.letters.Text = "           ";
            this.letters.Click += new System.EventHandler(this.letters_Click);
            // 
            // wordText
            // 
            this.wordText.AutoSize = true;
            this.wordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordText.Location = new System.Drawing.Point(349, 606);
            this.wordText.Name = "wordText";
            this.wordText.Size = new System.Drawing.Size(369, 180);
            this.wordText.TabIndex = 1;
            this.wordText.Text = "       ";
            this.wordText.Visible = false;
            this.wordText.Click += new System.EventHandler(this.wordText_Click);
            // 
            // getJumble
            // 
            this.getJumble.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getJumble.Location = new System.Drawing.Point(357, 32);
            this.getJumble.Name = "getJumble";
            this.getJumble.Padding = new System.Windows.Forms.Padding(10);
            this.getJumble.Size = new System.Drawing.Size(295, 82);
            this.getJumble.TabIndex = 2;
            this.getJumble.Text = "Get Jumble";
            this.getJumble.UseVisualStyleBackColor = true;
            this.getJumble.Click += new System.EventHandler(this.getJumble_Click);
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(3, 293);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(271, 74);
            this.answer.TabIndex = 3;
            this.answer.Text = "ANSWER";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // sizeGroup
            // 
            this.sizeGroup.Controls.Add(this.sixButton);
            this.sizeGroup.Controls.Add(this.fiveButton);
            this.sizeGroup.Location = new System.Drawing.Point(670, 34);
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
            this.sixButton.CheckedChanged += new System.EventHandler(this.sixButton_CheckedChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 815);
            this.Controls.Add(this.sizeGroup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.getJumble);
            this.Controls.Add(this.wordText);
            this.Controls.Add(this.letters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sizeGroup.ResumeLayout(false);
            this.sizeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label letters;
        private System.Windows.Forms.Label wordText;
        private System.Windows.Forms.Button getJumble;
        private System.Windows.Forms.Button answer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox sizeGroup;
        private System.Windows.Forms.RadioButton sixButton;
        private System.Windows.Forms.RadioButton fiveButton;
    }
}

