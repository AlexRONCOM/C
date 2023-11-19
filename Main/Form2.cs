using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
            StartConf();
        }

        void StartConf()
        {
            /*  sipMessageErrorEmail.Visible = false;
              sipEmailMinCharError.Visible = false;
              sipPassInvalidChar.Visible = false;
              sipPassMinError.Visible = false;

            */
            supSignUpButton.FlatStyle = FlatStyle.Flat;
            supSignUpButton.BackColor = Color.Transparent;
            supSignUpButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            supSignUpButton.FlatAppearance.MouseOverBackColor = Color.Transparent;

            supSIbutton.FlatStyle = FlatStyle.Flat;
            supSIbutton.BackColor = Color.Transparent;
            supSIbutton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            supSIbutton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        void CheckName(char[] name)
        {
            //TBC
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void supSignUpButton_Click(object sender, EventArgs e)
        {

        }

        private void supSIbutton_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
