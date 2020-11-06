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

                dlgShowExeptions.Text = "Что-то пошло не так...";
                dlgShowExeptions.AutoSize = false;
                dlgShowExeptions.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlgShowExeptions.MaximizeBox = false;


                dlgShowExeptions.textBoxExMessage.AutoSize = true;
                dlgShowExeptions.textBoxExMessage.Multiline = true;
                dlgShowExeptions.textBoxExMessage.WordWrap = true;
                dlgShowExeptions.textBoxExMessage.ReadOnly = true;

                dlgShowExeptions.textBoxExSource.AutoSize = true;
                dlgShowExeptions.textBoxExSource.Multiline = true;
                dlgShowExeptions. textBoxExSource.WordWrap = true;
                dlgShowExeptions.textBoxExSource.ReadOnly = true;

                dlgShowExeptions.textBoxExSteck.AutoSize = true;
                dlgShowExeptions.textBoxExSteck.Multiline = true;
                dlgShowExeptions.textBoxExSteck.WordWrap = true;
                dlgShowExeptions.textBoxExSteck.ReadOnly = true;



                dlgShowExeptions.textBoxExMessage.Text = EX.Message;
                dlgShowExeptions.textBoxExSource.Text = EX.Source;
                dlgShowExeptions.textBoxExSteck.Text = EX.StackTrace;
                dlgShowExeptions.ShowDialog();
            }
           
        }

        private void buttonAppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

           
            
        }
    }
}
