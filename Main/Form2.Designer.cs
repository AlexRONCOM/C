namespace Main
{
    partial class SignUpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpPage));
            this.supSignUpButton = new System.Windows.Forms.Button();
            this.supSIbutton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // supSignUpButton
            // 
            this.supSignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.supSignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supSignUpButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.supSignUpButton.FlatAppearance.BorderSize = 0;
            this.supSignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supSignUpButton.Location = new System.Drawing.Point(245, 422);
            this.supSignUpButton.Name = "supSignUpButton";
            this.supSignUpButton.Size = new System.Drawing.Size(242, 21);
            this.supSignUpButton.TabIndex = 11;
            this.supSignUpButton.UseVisualStyleBackColor = false;
            this.supSignUpButton.Click += new System.EventHandler(this.supSignUpButton_Click);
            // 
            // supSIbutton
            // 
            this.supSIbutton.BackColor = System.Drawing.Color.Transparent;
            this.supSIbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supSIbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.supSIbutton.FlatAppearance.BorderSize = 0;
            this.supSIbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supSIbutton.Location = new System.Drawing.Point(393, 481);
            this.supSIbutton.Name = "supSIbutton";
            this.supSIbutton.Size = new System.Drawing.Size(67, 11);
            this.supSIbutton.TabIndex = 13;
            this.supSIbutton.UseVisualStyleBackColor = false;
            this.supSIbutton.Click += new System.EventHandler(this.supSIbutton_Click);
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(273, 265);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(210, 18);
            this.NameBox.TabIndex = 14;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(273, 312);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(210, 18);
            this.EmailBox.TabIndex = 15;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(273, 359);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(210, 18);
            this.PasswordBox.TabIndex = 16;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // SignUpPage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.supSIbutton);
            this.Controls.Add(this.supSignUpButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpPage";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supSignUpButton;
        private System.Windows.Forms.Button supSIbutton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PasswordBox;
    }
}