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
            // SignUpPage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.supSIbutton);
            this.Controls.Add(this.supSignUpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpPage";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button supSignUpButton;
        private System.Windows.Forms.Button supSIbutton;
    }
}