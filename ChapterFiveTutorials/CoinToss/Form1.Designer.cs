namespace CoinToss
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
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.btnToss = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.displayText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tailsPictureBox.Image = global::CoinToss.Properties.Resources.quartertials;
            this.tailsPictureBox.Location = new System.Drawing.Point(55, 12);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(156, 154);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tailsPictureBox.TabIndex = 0;
            this.tailsPictureBox.TabStop = false;
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(94, 214);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(75, 23);
            this.btnToss.TabIndex = 2;
            this.btnToss.Text = "Toss";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(187, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = global::CoinToss.Properties.Resources.quarter_heads;
            this.headsPictureBox.Location = new System.Drawing.Point(55, 12);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(156, 154);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headsPictureBox.TabIndex = 4;
            this.headsPictureBox.TabStop = false;
            // 
            // displayText
            // 
            this.displayText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayText.Location = new System.Drawing.Point(12, 179);
            this.displayText.Name = "displayText";
            this.displayText.Size = new System.Drawing.Size(241, 23);
            this.displayText.TabIndex = 5;
            this.displayText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayText);
            this.Controls.Add(this.headsPictureBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToss);
            this.Controls.Add(this.tailsPictureBox);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.Label displayText;
        private System.Windows.Forms.Button button1;
    }
}

