using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROG7312_Part_1.Classes;

namespace PROG7312_Part_1
{
    public partial class Form1 : Form
    {
        ReplaceBooksForm replaceBooksForm = new ReplaceBooksForm();
        ReplaceBooksClass replaceBooksClass = new ReplaceBooksClass();
        IdentifyAreasForm identifyAreasForm = new IdentifyAreasForm();
        FindCallNumbersForm findCallNumbersForm = new FindCallNumbersForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            replaceBooksForm.Show();
            replaceBooksClass.ReplaceBooksInstructions();
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            this.Hide();
            identifyAreasForm.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.Hide();
            findCallNumbersForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
