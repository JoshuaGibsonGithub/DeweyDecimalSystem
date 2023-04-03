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
    public partial class ReplaceBooksForm : Form
    {
        public ListBox listBoxCallNumbers = new ListBox();
        public ListBox listBoxSortedList = new ListBox();
        public Label lblCall = new Label();
        public Label lblScores = new Label();
        public Label lblTimers = new Label();
        ReplaceBooksClass replaceBooksClass = new ReplaceBooksClass();
        
        public ReplaceBooksForm()
        {
            InitializeComponent();
            listBoxCallNumbers = lbCallNumbers;
            listBoxSortedList = lbSortedList;
            lblCall = lblCallNumber;
            lblScores = lblScore;
            lblTimers = lblTimer;
            replaceBooksClass.GenerateCallNumbers(this);
            replaceBooksClass.ResetForm(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            replaceBooksClass.UserOrder(this);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            replaceBooksClass.ReplaceBooksInstructions();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            replaceBooksClass.ResetForm(this);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void ReplaceBooksForm_Load(object sender, EventArgs e)
        {

        }

        private void timerStopWatch_Tick(object sender, EventArgs e)
        {
            replaceBooksClass.StopWatchUpdate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
