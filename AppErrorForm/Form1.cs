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

                Graphics gr = dlgShowExeptions.textBoxExSteck.CreateGraphics();
                SizeF size = new SizeF();

                using (gr)
                {
                    //получаем размер прямоугольника под строку
                    size = gr.MeasureString(EX.StackTrace, dlgShowExeptions.textBoxExMessage.Font, dlgShowExeptions.Width);
                    size = gr.MeasureString(EX.StackTrace, dlgShowExeptions.textBoxExSource.Font, dlgShowExeptions.Width);
                    size = gr.MeasureString(EX.StackTrace, dlgShowExeptions.textBoxExSteck.Font, dlgShowExeptions.Width);
                }

                //устанавливаем размер TextBox
                dlgShowExeptions.textBoxExMessage.Size = new Size((int)size.Width, (int)size.Height + dlgShowExeptions.textBoxExMessage.Font.Height); //высота с запасом 	в одну строку под верхний и нижний отступ
                dlgShowExeptions.textBoxExSource.Size = new Size((int)size.Width, (int)size.Height + dlgShowExeptions.textBoxExSource.Font.Height); //высота с запасом 	в одну строку под верхний и нижний отступ
                dlgShowExeptions.textBoxExSteck.Size = new Size((int)size.Width, (int)size.Height + dlgShowExeptions.textBoxExSteck.Font.Height); //высота с запасом 	в одну строку под верхний и нижний отступ


                dlgShowExeptions.textBoxExMessage.Text = EX.Message;
                dlgShowExeptions.textBoxExSource.Text = EX.Source;
                dlgShowExeptions.textBoxExSteck.Text = EX.StackTrace;
                dlgShowExeptions.ShowDialog();
            }
            // System.Diagnostics.Process.Start("mailto:admin@example.com&body="+ System.Net.WebUtility.UrlEncode(EX.Message));
        }

        private void buttonAppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

           
            
        }
    }
}
