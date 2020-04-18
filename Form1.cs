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

namespace Jumble_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fiveButton.Checked = true;
        }

        private string getWord(List<string> wordList)
        {

            Random myRand = new Random();
            int index = myRand.Next(wordList.Count);
            string word;
            word = wordList.ElementAt(index);
            return word;
        }

        private void jumble(string word)
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
            letters.Text = jumble;
        }

        private void getJumble_Click(object sender, EventArgs e)
        {
            wordText.Visible = false;
            StreamReader readFile;
            readFile = File.OpenText("words.txt");
            string word = "";

            if (fiveButton.Checked)
            { 
                List<string> word5List = new List<string>();
                while (!readFile.EndOfStream)
                {
                    word = readFile.ReadLine();
                    if (word.Length == 5)
                        word5List.Add(word);
                }
                word = getWord(word5List);
            }
            else if (sixButton.Checked)
            {
                List<string> word6List = new List<string>();
                while (!readFile.EndOfStream)
                {
                    word = readFile.ReadLine();
                    if (word.Length == 6)
                        word6List.Add(word);
                }
                word = getWord(word6List);
                
            }
            wordText.Text = word;
            jumble(word);
        }

        private void sixButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wordText_Click(object sender, EventArgs e)
        {
            
        }

        private void answer_Click(object sender, EventArgs e)
        {
            wordText.Visible = true;
        }

        private void myDebug_TextChanged(object sender, EventArgs e)
        {

        }

        private void letters_Click(object sender, EventArgs e)
        {

        }
    }
}
