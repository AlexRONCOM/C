﻿namespace Main
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.sipSUPanel = new System.Windows.Forms.Panel();
            this.sipEmailIcon = new System.Windows.Forms.PictureBox();
            this.sipPassIcon = new System.Windows.Forms.PictureBox();
            this.sipEmailBox = new System.Windows.Forms.TextBox();
            this.sipPassBox = new System.Windows.Forms.TextBox();
            this.sipLabelButtonSignUP = new System.Windows.Forms.Panel();
            this.sipMessageErrorEmail = new System.Windows.Forms.Label();
            this.sipEmailMinCharError = new System.Windows.Forms.Label();
            this.sipPassMinError = new System.Windows.Forms.Label();
            this.sipPassInvalidChar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sipEmailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipPassIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // sipSUPanel
            // 
            this.sipSUPanel.BackColor = System.Drawing.Color.Transparent;
            this.sipSUPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sipSUPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sipSUPanel.Location = new System.Drawing.Point(390, 480);
            this.sipSUPanel.Name = "sipSUPanel";
            this.sipSUPanel.Size = new System.Drawing.Size(72, 13);
            this.sipSUPanel.TabIndex = 0;
            this.sipSUPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sipSUPanel_Paint);
            // 
            // sipEmailIcon
            // 
            this.sipEmailIcon.Image = ((System.Drawing.Image)(resources.GetObject("sipEmailIcon.Image")));
            this.sipEmailIcon.Location = new System.Drawing.Point(249, 314);
            this.sipEmailIcon.Name = "sipEmailIcon";
            this.sipEmailIcon.Size = new System.Drawing.Size(17, 17);
            this.sipEmailIcon.TabIndex = 1;
            this.sipEmailIcon.TabStop = false;
            this.sipEmailIcon.Click += new System.EventHandler(this.sipEmailIcon_Click);
            // 
            // sipPassIcon
            // 
            this.sipPassIcon.Image = ((System.Drawing.Image)(resources.GetObject("sipPassIcon.Image")));
            this.sipPassIcon.Location = new System.Drawing.Point(249, 358);
            this.sipPassIcon.Name = "sipPassIcon";
            this.sipPassIcon.Size = new System.Drawing.Size(17, 19);
            this.sipPassIcon.TabIndex = 2;
            this.sipPassIcon.TabStop = false;
            this.sipPassIcon.Click += new System.EventHandler(this.sipPassIcon_Click);
            // 
            // sipEmailBox
            // 
            this.sipEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sipEmailBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sipEmailBox.Location = new System.Drawing.Point(271, 311);
            this.sipEmailBox.MaxLength = 64;
            this.sipEmailBox.Name = "sipEmailBox";
            this.sipEmailBox.Size = new System.Drawing.Size(208, 18);
            this.sipEmailBox.TabIndex = 3;
            this.sipEmailBox.TextChanged += new System.EventHandler(this.sipEmailBox_TextChanged);
            // 
            // sipPassBox
            // 
            this.sipPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sipPassBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sipPassBox.Location = new System.Drawing.Point(271, 359);
            this.sipPassBox.Name = "sipPassBox";
            this.sipPassBox.PasswordChar = '*';
            this.sipPassBox.Size = new System.Drawing.Size(208, 18);
            this.sipPassBox.TabIndex = 4;
            this.sipPassBox.TextChanged += new System.EventHandler(this.sipPassBox_TextChanged);
            // 
            // sipLabelButtonSignUP
            // 
            this.sipLabelButtonSignUP.BackColor = System.Drawing.Color.Transparent;
            this.sipLabelButtonSignUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sipLabelButtonSignUP.Location = new System.Drawing.Point(241, 423);
            this.sipLabelButtonSignUP.Name = "sipLabelButtonSignUP";
            this.sipLabelButtonSignUP.Size = new System.Drawing.Size(250, 20);
            this.sipLabelButtonSignUP.TabIndex = 5;
            this.sipLabelButtonSignUP.Paint += new System.Windows.Forms.PaintEventHandler(this.sipLabelButtonSignUP_Paint);
            // 
            // sipMessageErrorEmail
            // 
            this.sipMessageErrorEmail.AutoSize = true;
            this.sipMessageErrorEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sipMessageErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sipMessageErrorEmail.ForeColor = System.Drawing.Color.DeepPink;
            this.sipMessageErrorEmail.Location = new System.Drawing.Point(245, 337);
            this.sipMessageErrorEmail.Name = "sipMessageErrorEmail";
            this.sipMessageErrorEmail.Size = new System.Drawing.Size(181, 13);
            this.sipMessageErrorEmail.TabIndex = 6;
            this.sipMessageErrorEmail.Text = "The e-mail address entered is invalid.";
            this.sipMessageErrorEmail.Visible = false;
            this.sipMessageErrorEmail.Click += new System.EventHandler(this.sipMessageErrorEmail_Click);
            // 
            // sipEmailMinCharError
            // 
            this.sipEmailMinCharError.AutoSize = true;
            this.sipEmailMinCharError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sipEmailMinCharError.ForeColor = System.Drawing.Color.DeepPink;
            this.sipEmailMinCharError.Location = new System.Drawing.Point(246, 337);
            this.sipEmailMinCharError.Name = "sipEmailMinCharError";
            this.sipEmailMinCharError.Size = new System.Drawing.Size(237, 13);
            this.sipEmailMinCharError.TabIndex = 7;
            this.sipEmailMinCharError.Text = "Email address must be at least 3 characters long.";
            this.sipEmailMinCharError.Visible = false;
            this.sipEmailMinCharError.Click += new System.EventHandler(this.sipEmailMinCharError_Click);
            // 
            // sipPassMinError
            // 
            this.sipPassMinError.AutoSize = true;
            this.sipPassMinError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sipPassMinError.ForeColor = System.Drawing.Color.DeepPink;
            this.sipPassMinError.Location = new System.Drawing.Point(246, 385);
            this.sipPassMinError.Name = "sipPassMinError";
            this.sipPassMinError.Size = new System.Drawing.Size(218, 13);
            this.sipPassMinError.TabIndex = 8;
            this.sipPassMinError.Text = "Password must contain at least 5 characters.";
            this.sipPassMinError.Visible = false;
            this.sipPassMinError.Click += new System.EventHandler(this.sipPassMinError_Click);
            // 
            // sipPassInvalidChar
            // 
            this.sipPassInvalidChar.AutoSize = true;
            this.sipPassInvalidChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sipPassInvalidChar.ForeColor = System.Drawing.Color.DeepPink;
            this.sipPassInvalidChar.Location = new System.Drawing.Point(246, 385);
            this.sipPassInvalidChar.Name = "sipPassInvalidChar";
            this.sipPassInvalidChar.Size = new System.Drawing.Size(245, 13);
            this.sipPassInvalidChar.TabIndex = 9;
            this.sipPassInvalidChar.Text = "The entered password contains invalid characters.";
            this.sipPassInvalidChar.Visible = false;
            this.sipPassInvalidChar.Click += new System.EventHandler(this.sipPassInvalidChar_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.sipPassInvalidChar);
            this.Controls.Add(this.sipPassMinError);
            this.Controls.Add(this.sipEmailMinCharError);
            this.Controls.Add(this.sipMessageErrorEmail);
            this.Controls.Add(this.sipLabelButtonSignUP);
            this.Controls.Add(this.sipPassBox);
            this.Controls.Add(this.sipEmailBox);
            this.Controls.Add(this.sipPassIcon);
            this.Controls.Add(this.sipEmailIcon);
            this.Controls.Add(this.sipSUPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sipEmailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipPassIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sipSUPanel;
        private System.Windows.Forms.PictureBox sipEmailIcon;
        private System.Windows.Forms.PictureBox sipPassIcon;
        private System.Windows.Forms.TextBox sipEmailBox;
        private System.Windows.Forms.TextBox sipPassBox;
        private System.Windows.Forms.Panel sipLabelButtonSignUP;
        private System.Windows.Forms.Label sipMessageErrorEmail;
        private System.Windows.Forms.Label sipEmailMinCharError;
        private System.Windows.Forms.Label sipPassMinError;
        private System.Windows.Forms.Label sipPassInvalidChar;
    }
}
