using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            StartConfig();            
        }

        private void StartConfig()
        {
            sipMessageErrorEmail.Visible = false;
            sipEmailMinCharError.Visible = false;
            sipPassInvalidChar.Visible = false;
            sipPassMinError.Visible = false;

            sipSignUpButton.FlatStyle = FlatStyle.Flat;
            sipSignUpButton.BackColor = Color.Transparent;
            sipSignUpButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            sipSignUpButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void sipEmailIcon_Click(object sender, EventArgs e)
        {

        }

        private void sipPassIcon_Click(object sender, EventArgs e)
        {

        }

        private void sipSUPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sipPassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sipEmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool CheckEmail(string text)
        {
            char[] chars = text.ToCharArray();
            foreach (char c in chars)
            {
                if (c == '@')
                {
                    return true;

                }
            }

            return false;
        }

        private bool AntiSQLInjection(string text)
        {
            char[] caractereSQLInjection = { '\'', '"', ';', '-', '-', '/', '*', '=' };

            foreach (char caracter in text)
            {
                if (caractereSQLInjection.Contains(caracter))
                {
                    return true;
                }
            }

            return false;
        }
        private bool OnlyNumbers(string text)
        {
           /* char[] onlynumb = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach(char number  in onlynumb)
            {
                for (int i = 0; i < text.Length; i++)
                {
                   
                }
            }
           */
            return true;
        }

        private void sipMessageErrorEmail_Click(object sender, EventArgs e)
        {

        }

        private void sipEmailMinCharError_Click(object sender, EventArgs e)
        {

        }

        private void sipPassInvalidChar_Click(object sender, EventArgs e)
        {

        }

        private void sipPassMinError_Click(object sender, EventArgs e)
        {

        }

        // Sign Up Button (Panel) //

        private void sipSignUpButton_Click(object sender, EventArgs e)
        {

            if (sipEmailBox.Text.Length <= 3)
            {
                sipEmailMinCharError.Visible = true;
                sipMessageErrorEmail.Visible = false;
                return;
            }

            if (AntiSQLInjection(sipEmailBox.Text) == true)
            {
                sipEmailMinCharError.Visible = false;
                sipMessageErrorEmail.Visible = true;
                return;
            }

            if (CheckEmail(sipEmailBox.Text) == false)
            {
                sipEmailMinCharError.Visible = false;
                sipMessageErrorEmail.Visible = true;
                return;
            }

            sipMessageErrorEmail.Visible = false;
            sipEmailMinCharError.Visible = false;
            sipPassInvalidChar.Visible = false;
            sipPassMinError.Visible = false;

            //just a test
        }
    }
}
