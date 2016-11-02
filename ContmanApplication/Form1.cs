using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContmanApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog.FileName;
            string fileExtension = Path.GetExtension(openFileDialog.FileName);

            if (fileExtension == ".txt")
            {
                try
                {
                    previewTextBox.Text = File.ReadAllText(fileName);
                    AnalyseTextMethod(previewTextBox.Text);
                }
                catch (System.Security.SecurityException)
                {
                    MessageBox.Show("Brak uprawnień do czytania pliku.");
                }
                catch (IOException)
                {
                    MessageBox.Show("Wystąpił błąd podczas otwierania pliku. Spróbuj ponownie.");
                }
                catch
                {
                    MessageBox.Show("Nieznany błąd. Spróbuj ponownie.");
                }
            }
            else
                previewTextBox.Text = "Nieprawidłowy plik.";
        }

        private void AnalyseTextMethod(string input)
        {
            AnalyseText o = new AnalyseText(input);
            
            // count up all chars
            charCountTextBox.Text = o.CountCharacters().ToString();

            // count up all words
            wordCountTextBox.Text =
                o.CountWordsAndAverageLettersPerWord().Item1.ToString();

            // count up average letters per word
            averageLettersInWordTextBox.Text
                = o.CountWordsAndAverageLettersPerWord().Item2.ToString("F");

            // count up sentences
            sentenceCountTextBox.Text =
                o.CountSentencesAndAverageWordsPerSentence().Item1.ToString();

            // count up average words per sentence
            averageWordsInSentenceTextBox.Text =
                o.CountSentencesAndAverageWordsPerSentence().Item2.ToString("F");

            // count up paragraps
            paragraphCountTextBox.Text = o.CountParagraphs().ToString();

            // count up all unique non-whitespace characters
            o.CountUniqueCharacters();

            threeMostFrequentCharsTextBox.Text = String.Empty;

            if (o.listOfUsedChars.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    threeMostFrequentCharsTextBox.Text +=
                        o.GetKeyAtIndex(i).ToString();
                    if (i != 2)
                        threeMostFrequentCharsTextBox.Text += ", ";
                }
            }
            else
            {
                threeMostFrequentCharsTextBox.Text = "Zbyt mało unikalnych znaków.";
            }
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
    }
}