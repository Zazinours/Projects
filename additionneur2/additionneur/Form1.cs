using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace additionneur
{
    public partial class FormAdditionneur : Form
    {
        

        public FormAdditionneur()
        {
            InitializeComponent();

            
        }

 

        private void btn0_Click(object sender, EventArgs e)
        {
            rb_Click();
        }

        private void rb_Click()
        {
            throw new NotImplementedException();
        }

        private void rb_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            switch (((Button)sender).Name)
            {

                case "0":

                    Environment.Exit(0);
                    break;
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":

                    break;
                case "7":

                    break;
                case "8":

                    break;
                case "9":

                    break;


            }
        }
    }
}
