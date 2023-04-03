using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_Part_1.Classes
{
    class IdentifyAreasClass
    {
        private IdentifyAreasForm form;
        public static Dictionary<string, string> DeweyPairs = new Dictionary<string, string>();
        public List<string> strList = new List<string>();
        Random random = new Random();
        int counter, counter2;
        private int secondsTime = 0;
        private bool isActive;

        /// <summary>
        /// Populates the list boxes with the keys and values from the dictionary
        /// </summary>
        /// <param name="Sender"></param>
        public void PopulateListBox(IdentifyAreasForm Sender)
        {
            PopulateDictionary();
            counter = 0;
            counter2 = 0;
            this.form = Sender;

            for (int i = 0; i < 4; i++)
            {
                    int randInt = random.Next(0, DeweyPairs.Count);
                    this.form.lbLeftBox.Items.Add(DeweyPairs.ElementAt(randInt).Key);
                    strList.Add(DeweyPairs.ElementAt(randInt).Value);
            }

            for (int i = 0; i < 3; i++)
            {
                int randInt = random.Next(0, DeweyPairs.Count);
                strList.Add(DeweyPairs.ElementAt(randInt).Value);
            }

            strList.Sort();
            for (int i = 0; i < strList.Count; i++)
            {
                this.form.lbRightBox.Items.Add(strList[i]);
            }
        }

        /// <summary>
        /// Populates the dictionary with dewey decimal information
        /// </summary>
        public void PopulateDictionary()
        {
            DeweyPairs["000"] = "Computer science, information and general works";
            DeweyPairs["100"] = "Philosophy and psychology";
            DeweyPairs["200"] = "Religion";
            DeweyPairs["300"] = "Social sciences";
            DeweyPairs["400"] = "Language";
            DeweyPairs["500"] = "Pure Science";
            DeweyPairs["600"] = "Technology";
            DeweyPairs["700"] = "Arts and recreation";
            DeweyPairs["800"] = "Literature";
            DeweyPairs["900"] = "History and geography";
        }

        /// <summary>
        /// Checks whether the user has chosen the correct pair
        /// </summary>
        /// <param name="Sender"></param>
        public void AddItem(IdentifyAreasForm Sender)
        {
            if (this.form.lbLeftBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select A Value From The List of Call Numbers On The Left");
            }else

            if (DeweyPairs[this.form.lbLeftBox.Text] != this.form.lbRightBox.Text)
            {
                counter2 = counter2 + 1;
                this.form.lbLeftBox.Items.Remove(this.form.lbLeftBox.SelectedItem);
                this.form.lbRightBox.Items.Remove(this.form.lbRightBox.SelectedItem);
            }
            else
            {
                counter = counter + 1;
                counter2 = counter2 + 1;
                this.form.lbLeftBox.Items.Remove(this.form.lbLeftBox.SelectedItem);
                this.form.lbRightBox.Items.Remove(this.form.lbRightBox.SelectedItem);
            }

            if (counter2 == 4)
            {
                isActive = false;
                this.form.lblScoreLabel.Text = "Your score is " + counter + "/4 and you completed the activity in " + secondsTime.ToString() + " seconds!";
            }
        }

        /// <summary>
        /// Activates the timer
        /// </summary>
        public void StopWatchUpdate()
        {
            isActive = true;
            if (isActive)
            {
                secondsTime++;
            }
        }

        /// <summary>
        /// Resets the form back to the original state
        /// </summary>
        /// <param name="Sender"></param>
        public void ResetForm(IdentifyAreasForm Sender)
        {
            strList.Clear();
            this.form.lbLeftBox.Items.Clear();
            this.form.lbRightBox.Items.Clear();
            this.form.lblScoreLabel.Text = "";
            counter = 0;
            counter2 = 0;
            secondsTime = 0;
            PopulateListBox(Sender);

        }

        /// <summary>
        /// Instructions for the activity
        /// </summary>
        public void IdentifyAreasInstructions()
        {
            MessageBox.Show("Select a Call Number from the list on the left and select the matching description from the list on the right. Once the pairs are matched " +
                "click the Submit Answer button.");
        }

    }
}
