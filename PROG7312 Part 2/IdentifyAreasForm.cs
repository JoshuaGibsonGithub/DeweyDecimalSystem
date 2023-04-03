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
    public partial class IdentifyAreasForm : Form
    {
        public ListBox lbLeftBox = new ListBox();
        public ListBox lbRightBox = new ListBox();
        public Label lblScoreLabel = new Label();
        IdentifyAreasClass identifyAreasClass = new IdentifyAreasClass();
        public static Dictionary<string, string> dict = new Dictionary<string, string>();

        public IdentifyAreasForm()
        {
            InitializeComponent();
            lbLeftBox = lbLeft;
            lbRightBox = lbRight;
            lblScoreLabel = lblScore;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            identifyAreasClass.AddItem(this);
        }

        private void IdentifyAreasForm_Load(object sender, EventArgs e)
        {
            identifyAreasClass.PopulateListBox(this);
            identifyAreasClass.StopWatchUpdate();
            identifyAreasClass.IdentifyAreasInstructions();
        }

        private void lbRight_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void timerStopWatch_Tick_1(object sender, EventArgs e)
        {
            identifyAreasClass.StopWatchUpdate();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            identifyAreasClass.ResetForm(this);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            identifyAreasClass.IdentifyAreasInstructions();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
