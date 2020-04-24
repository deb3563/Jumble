using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jumble
{
    public partial class Form1 : Form
    {

        List<string> word5List = new List<string>();
        List<string> word6List = new List<string>();


        public Form1()
        {
            InitializeComponent();
            readFileWord5();
            readFileWord6();
            fiveButton.Checked = true;
        }

        //read file of 5 letter words
        private void readFileWord5()
        {
            StreamReader readFile;
            try
            {
                readFile = File.OpenText("word5.txt");
                string word = "";
                while (!readFile.EndOfStream)
                {
                    word = readFile.ReadLine();
                    word5List.Add(word);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //read file of 6 letter words
        private void readFileWord6()
        {
            StreamReader readFile;
            try
            {
                readFile = File.OpenText("word6.txt");
                string word = "";
                while (!readFile.EndOfStream)
                {
                    word = readFile.ReadLine();
                    word6List.Add(word);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //get Random word
        private string getWord(List<string> wordList)
        {
            Random myRand = new Random();
            int index = myRand.Next(wordList.Count);
            string word;
            word = wordList.ElementAt(index);
            return word;
        }

        //jumble letters in word and return jumbled word
        private string jumble(string word)
        {
            int count = word.Length; //save word length before word is modified
            string jumble = "";
            int target = 0;
            Random myRand = new Random();
            while (jumble.Length < count)
            {
                target = myRand.Next(word.Length); //word length is reduced each loop
                string copy = ""; //holds the word without the target character
                for (int i = 0; i <word.Length; i++)
                {
                    if (i == target)
                        jumble += word[i];
                    else
                        copy += word[i];
                }
                word = copy;
            }
            return jumble;
        }

        //get a jumbled word
        private void getJumble_Click(object sender, EventArgs e)
        {
            if (answerBox.Visible) //Get Jumble
            {
                answerBox.Visible = false;
                string word = "";
                if (fiveButton.Checked)
                {
                    word = getWord(word5List);
                    answerBox.Text = word;
                }
                else
                {
                    word = getWord(word6List);
                    answerBox.Text = word;
                }
                letters.Text = jumble(word);
                getJumble.Text = "Show Answer"; //change the button text
            }
            else //Show answer
            {
                answerBox.Visible = true;
                getJumble.Text = "Get Jumble"; //change the button text
            }
        }


        //add a point for player1
        private void player1AddButto_Click(object sender, EventArgs e)
        {

                int count = int.Parse(player1Label.Text);
                count++;
                player1Label.Text = count.ToString();
        }

        //add a point for player2
        private void button1_Click(object sender, EventArgs e)
        {
                int count = int.Parse(player2Label.Text);
                count++;
                player2Label.Text = count.ToString();
        }

      


        //clear player points and all labels
        private void clearButton_Click(object sender, EventArgs e)
        {
            player2Label.Text = "0";
            player1Label.Text = "0";
        }

        //remove a point from player1
        private void player1Label_Click(object sender, EventArgs e)
        {
            int count = int.Parse(player1Label.Text);
            count--;
            player1Label.Text = count.ToString();
        }

        //remove a point from player2
        private void player2Label_Click(object sender, EventArgs e)
        {
            int count = int.Parse(player2Label.Text);
            count--;
            player2Label.Text = count.ToString();
        }
    }
}
