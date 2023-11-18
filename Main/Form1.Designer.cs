namespace Main
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Form2 form2Instance;


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
            this.sipEmailIcon = new System.Windows.Forms.PictureBox();
            this.sipPassIcon = new System.Windows.Forms.PictureBox();
            this.sipEmailBox = new System.Windows.Forms.TextBox();
            this.sipPassBox = new System.Windows.Forms.TextBox();
            this.sipMessageErrorEmail = new System.Windows.Forms.Label();
            this.sipEmailMinCharError = new System.Windows.Forms.Label();
            this.sipPassMinError = new System.Windows.Forms.Label();
            this.sipPassInvalidChar = new System.Windows.Forms.Label();
            this.sipSignUpButton = new System.Windows.Forms.Button();
            this.sipShowPass = new System.Windows.Forms.PictureBox();
            this.sipSUbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sipEmailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipPassIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // sipEmailIcon
            // 
            this.sipEmailIcon.Image = ((System.Drawing.Image)(resources.GetObject("sipEmailIcon.Image")));
            this.sipEmailIcon.Location = new System.Drawing.Point(249, 312);
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
            // sipSignUpButton
            // 
            this.sipSignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.sipSignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sipSignUpButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.sipSignUpButton.FlatAppearance.BorderSize = 0;
            this.sipSignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sipSignUpButton.Location = new System.Drawing.Point(246, 422);
            this.sipSignUpButton.Name = "sipSignUpButton";
            this.sipSignUpButton.Size = new System.Drawing.Size(242, 21);
            this.sipSignUpButton.TabIndex = 10;
            this.sipSignUpButton.UseVisualStyleBackColor = false;
            this.sipSignUpButton.Click += new System.EventHandler(this.sipSignUpButton_Click);
            // 
            // sipShowPass
            // 
            this.sipShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sipShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sipShowPass.Image = ((System.Drawing.Image)(resources.GetObject("sipShowPass.Image")));
            this.sipShowPass.Location = new System.Drawing.Point(493, 360);
            this.sipShowPass.Name = "sipShowPass";
            this.sipShowPass.Size = new System.Drawing.Size(16, 17);
            this.sipShowPass.TabIndex = 11;
            this.sipShowPass.TabStop = false;
            this.sipShowPass.Click += new System.EventHandler(this.sipShowPass_Click);
            // 
            // sipSUbutton
            // 
            this.sipSUbutton.BackColor = System.Drawing.Color.Transparent;
            this.sipSUbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sipSUbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.sipSUbutton.FlatAppearance.BorderSize = 0;
            this.sipSUbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sipSUbutton.Location = new System.Drawing.Point(392, 481);
            this.sipSUbutton.Name = "sipSUbutton";
            this.sipSUbutton.Size = new System.Drawing.Size(67, 11);
            this.sipSUbutton.TabIndex = 12;
            this.sipSUbutton.UseVisualStyleBackColor = false;
            this.sipSUbutton.Click += new System.EventHandler(this.sipSUbutton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.sipSUbutton);
            this.Controls.Add(this.sipShowPass);
            this.Controls.Add(this.sipSignUpButton);
            this.Controls.Add(this.sipPassInvalidChar);
            this.Controls.Add(this.sipPassMinError);
            this.Controls.Add(this.sipEmailMinCharError);
            this.Controls.Add(this.sipMessageErrorEmail);
            this.Controls.Add(this.sipPassBox);
            this.Controls.Add(this.sipEmailBox);
            this.Controls.Add(this.sipPassIcon);
            this.Controls.Add(this.sipEmailIcon);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sipEmailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipPassIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipShowPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox sipEmailIcon;
        private System.Windows.Forms.PictureBox sipPassIcon;
        private System.Windows.Forms.TextBox sipEmailBox;
        private System.Windows.Forms.TextBox sipPassBox;
        private System.Windows.Forms.Label sipMessageErrorEmail;
        private System.Windows.Forms.Label sipEmailMinCharError;
        private System.Windows.Forms.Label sipPassMinError;
        private System.Windows.Forms.Label sipPassInvalidChar;
        private System.Windows.Forms.Button sipSignUpButton;
        private System.Windows.Forms.PictureBox sipShowPass;
        private System.Windows.Forms.Button sipSUbutton;
    }
}

