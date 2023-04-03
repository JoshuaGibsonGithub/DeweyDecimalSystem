using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_Part_1.Classes
{
    class ReplaceBooksClass
    {
        private int callNumber1;
        private int callNumber2;
        private string key;
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string initials;
        Random ran = new Random();
        private List<string> callNumberList = new List<string>();
        private List<string> sortedList = new List<string>();
        private List<string> userSortedList = new List<string>();
        private ReplaceBooksForm form;
        private string callNumberString;
        private string selectedCallNumber;
        private int i;
        private int counter;
        private int secondsTime = 0;
        private bool isActive;
        /// <summary>
        /// generates random call numbers
        /// </summary>
        /// <param name="Sender"></param>
        public void GenerateCallNumbers(ReplaceBooksForm Sender)
        {
            for (int i = 0; i < 10; i++)
            {
                //Generates 2 random 3 digit numbers
                callNumber1 = ran.Next(0, 999);
                callNumber2 = ran.Next(0, 999);
                key = callNumber1.ToString("000");
                //generates a random 3 digit string
                initials = "";
                for (int j = 0; j < 3; j++)
                {
                    int a = ran.Next(26);
                    initials = initials + alphabet.ElementAt(a);
                }
                callNumberString = key + "." + callNumber2.ToString() + " " + initials;
                //adds the call numbers to a list
                callNumberList.Add(callNumberString);
               
        }
            //adds each call number from the list into a list box
            foreach (var callNumber in callNumberList)
            {
                this.form = Sender;
                this.form.listBoxCallNumbers.Items.Add(callNumber);
            }
            //sorts the list of call numbers and adds them to another list
            sortedList = callNumberList;
            sortedList.Sort();
        }

        /// <summary>
        /// Checks whether the order is correct
        /// </summary>
        /// <param name="Sender"></param>
        public void UserOrder(ReplaceBooksForm Sender)
        { 
            //checks whether a call number has been selected from the list box
            if (this.form.listBoxCallNumbers.SelectedItem == null)
            {
                MessageBox.Show("Please Select A Value From The List of Call Numbers On The Left");
            }
            else
            {
                //adds selected call number to secondary list box and removes from primary list box
                i = i + 1;
                selectedCallNumber = this.form.listBoxCallNumbers.SelectedItem.ToString();
                this.form.listBoxSortedList.Items.Add(selectedCallNumber);
                this.form.lblCall.Text = "Select Call Number #" + i;
                this.form.listBoxCallNumbers.Items.Remove(selectedCallNumber);
                userSortedList.Add(selectedCallNumber);
                if (i == 11)
                {
                    this.form.lblCall.Text = "Ordering Complete";
                    isActive = false;
                    //displays time taken to complete the activity
                    this.form.lblTimers.Text = "You completed in " + secondsTime.ToString() + " seconds!";
                    //compares the sorted list to the user sorted list to see how many call numbers match
                    for (int k = 0; k < callNumberList.Count; k++)
                    {
                        var item1 = userSortedList[k];
                        var item2 = sortedList[k];
                        if (item1 == item2)
                        {
                            counter = counter + 1;
                        }
                    }
                    //displays score
                    this.form.lblScores.Text = "You got " + counter.ToString() + "/10 answers correct!";

                }
            }
        }

        /// <summary>
        /// Resets form
        /// </summary>
        /// <param name="Sender"></param>
        public void ResetForm(ReplaceBooksForm Sender)
        {
            i = 1;
            this.form.lblCall.Text = "Select Call Number #" + i;
            this.form.lblScores.Text = "";
            this.form.listBoxSortedList.Items.Clear();
            userSortedList.Clear();
            this.form.listBoxCallNumbers.Items.Clear();
            counter = 0;
            secondsTime = 0;
            foreach (var callNumber in callNumberList)
            {
                this.form = Sender;
                this.form.listBoxCallNumbers.Items.Add(callNumber);
            }
            
        }

        /// <summary>
        /// Provides the user with a help tooltip
        /// </summary>
        public void ReplaceBooksInstructions()
        {
            MessageBox.Show("Select a Call Number from the list on the left and click the Add a Call Number button to add it to" +
                " the list on the right. Add the Call Numbers to the list in ascending order.");
        }

        /// <summary>
        /// Starts the timer
        /// </summary>
        public void StopWatchUpdate()
        {
            isActive = true;
            if (isActive)
            {
                secondsTime++;
            }
        }
    }
}
