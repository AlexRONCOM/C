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
            
        }

        private void StartConfig()
        {
            sipMessageErrorEmail.Visible = false;
            sipEmailMinCharError.Visible = false;
            sipPassInvalidChar.Visible = false;
            sipPassMinError.Visible = false;
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
            char[] caractereSQLInjection = { '\'', '"', ';', '-', '-', '/', '*', '='};

            foreach (char caracter in text)
            {
                if (caractereSQLInjection.Contains(caracter))
                {
                    return true;
                }
            }

            return false;
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
    }
}
