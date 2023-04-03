using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_Part_1.Classes
{
    class FindCallNumbersClass
    {
        private FindCallNumbersForm form;
        private string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        string textFile = Path.Combine(Directory.GetCurrentDirectory(), "multi level list.txt");
        int counter2, counter3;
        TreeNode tNode;
        int node1, node2;
        int counter = 0;
        private int secondsTime = 0;
        private bool isActive;


        /// <summary>
        /// Populates the tree with the values from the text file
        /// </summary>
        public void populateTree(FindCallNumbersForm Sender)
        {
            this.form = Sender;
            tNode = Sender.tView.Nodes.Add("Dewey Classes");

            counter2 = -1;
            counter3 = -1;
            if (File.Exists(textFile))
            {
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                {

                    if (line != "")
                    {
                        string newLine = line.Remove(0, 2);
                        char firstChar = line[0];
                        switch (firstChar)
                        {
                            case '*':
                                Sender.tView.Nodes[0].Nodes.Add(newLine);
                                counter2++;
                                break;
                            case 'o':
                                Sender.tView.Nodes[0].Nodes[counter2].Nodes.Add(newLine);
                                counter3++;
                                break;
                            case '-':
                                if (counter3 == 5)
                                {
                                    counter3 = 0;
                                }
                                Sender.tView.Nodes[0].Nodes[counter2].Nodes[counter3].Nodes.Add(newLine);
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Populates the list box with values from the text file
        /// </summary>
        public void CallNumbersGame(FindCallNumbersForm Sender)
        {
            secondsTime = 0;
            counter = 0;
            Sender.lbAnswers.Items.Clear();
            Random rnd = new Random();
            node1 = rnd.Next(0, 9);
            node2 = rnd.Next(0, 4);
            string display = Sender.tView.Nodes[0].Nodes[node1].Nodes[node2].Nodes[0].ToString().Remove(0, 14);
            Sender.LblDisplayLabel.Text = display;
            string display2 = Sender.tView.Nodes[0].Nodes[node1].ToString().Remove(0, 10);
            Sender.lbAnswers.Items.Add(display2);

            for (int i = 0; i < 3; i++)
            {
                string display3 = Sender.tView.Nodes[0].Nodes[rnd.Next(0, 9)].ToString().Remove(0, 10);
                Sender.lbAnswers.Items.Add(display3);
            }
            Sender.lbAnswers.Sorted = true;
        }

        /// <summary>
        /// Submits the user's answer and checks whether it is correct
        /// </summary>
        public void SubmitAnswer(FindCallNumbersForm Sender)
        {

            string display = Sender.tView.Nodes[0].Nodes[node1].ToString().Remove(0, 10);
            string display3 = Sender.tView.Nodes[0].Nodes[node1].Nodes[node2].ToString().Remove(0, 10);
            if (Sender.lbAnswers.SelectedItem.ToString() == display || Sender.lbAnswers.SelectedItem.ToString() == display3)
            {
                MessageBox.Show("Correct");
                counter = counter + 1;
                Random rnd = new Random();
                Sender.lbAnswers.Items.Clear();
                Sender.lbAnswers.Items.Add(display3);

                for (int i = 0; i < 3; i++)
                {
                    string display4 = Sender.tView.Nodes[0].Nodes[node1].Nodes[rnd.Next(0, 4)].ToString().Remove(0, 10);
                    Sender.lbAnswers.Items.Add(display4);
                }
                Sender.lbAnswers.Sorted = true;
                if (counter == 2)
                {
                    Sender.lbAnswers.Items.Clear();
                    MessageBox.Show("Complete");
                    isActive = false;
                    Sender.LblScoreLabel.Text = "You completed the activity in " + secondsTime.ToString() + " seconds!";
                }
            }
            else
            {
                MessageBox.Show("Incorrect");
                counter = 0;
                CallNumbersGame(Sender);
            }
        }

        /// <summary>
        /// Provides a help tooltip for the user
        /// </summary>
        public void Help()
        {
            MessageBox.Show("Select the call number from the list box that matches the description displayed above it and click the Submit Answer button to confirm your choice." +
                "The options presented will narrow down until you have the correct answer");
        }

        /// <summary>
        /// Updates the stopwatch
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
