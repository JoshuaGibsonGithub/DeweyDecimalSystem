using PROG7312_Part_1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_Part_1
{
    public partial class FindCallNumbersForm : Form
    {

        public Label LblScoreLabel = new Label();
        public ListBox lbAnswers = new ListBox();
        public Label LblDisplayLabel = new Label();
        public TreeView tView = new TreeView();
        FindCallNumbersClass findCallNumbersClass = new FindCallNumbersClass();
        //Boolean flag;

        public FindCallNumbersForm()
        {
            InitializeComponent();
            LblScoreLabel = lblScoreLabel;
            lbAnswers = lbNumbers;
            LblDisplayLabel = lblDisplay;
            tView = tView1;
        }

        private void FindCallNumbersForm_Load(object sender, EventArgs e)
        {
            findCallNumbersClass.Help();
            findCallNumbersClass.populateTree(this);
            findCallNumbersClass.CallNumbersGame(this);
            findCallNumbersClass.StopWatchUpdate();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            findCallNumbersClass.SubmitAnswer(this);
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            findCallNumbersClass.CallNumbersGame(this);
        }



        private void btnHelp_Click(object sender, EventArgs e)
        {
            findCallNumbersClass.Help();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        

        private void timerStopWatch_Tick(object sender, EventArgs e)
        {
            findCallNumbersClass.StopWatchUpdate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
                Environment.Exit(0);
        }




    }
}
