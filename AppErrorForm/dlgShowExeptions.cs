//Пример работы:

//dlgShowExeptions dlgShowExeptions = new dlgShowExeptions();
//dlgShowExeptions.labelExMessage.Text = EX.Message;
//dlgShowExeptions.labelExSource.Text = EX.Source;
//dlgShowExeptions.labelExSteck.Text = EX.StackTrace;
//dlgShowExeptions.ShowDialog();



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
    public partial class dlgShowExeptions : Form
    {
        public dlgShowExeptions()
        {
            InitializeComponent();
        }

        private void dlgShowExeptions_Load(object sender, EventArgs e)
        {
            this.Text = "Что-то пошло не так...";
            this.AutoSize = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}