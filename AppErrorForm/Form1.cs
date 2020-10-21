using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppErrorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Пример отбражения сообщения о ошибке...";
        }

        private void buttonShowAbaut_Click(object sender, EventArgs e)
        {
            dlgAboutBox dlgAboutBox = new dlgAboutBox();
            dlgAboutBox.ShowDialog();
        }

        private void buttonGenerateExeptions_Click(object sender, EventArgs e)
        {

            try
            {
                string text = "cnhjrf";
                
                int a = Convert.ToInt32(text);
                int b = 10000000;
                int c = 1000000000;

                double  Summ = a - b / c;

                MessageBox.Show(Summ.ToString());


            }
            catch (Exception EX)
            {

                dlgShowExeptions dlgShowExeptions = new dlgShowExeptions();
                dlgShowExeptions.labelExMessage.Text = EX.Message;
                dlgShowExeptions.labelExSource.Text = EX.Source;
                dlgShowExeptions.labelExSteck.Text = EX.StackTrace;
                dlgShowExeptions.ShowDialog();
            }
           
        }

        private void buttonAppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

           
            
        }
    }
}
