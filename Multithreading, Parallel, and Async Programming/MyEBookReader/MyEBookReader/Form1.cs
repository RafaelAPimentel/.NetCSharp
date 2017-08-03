using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEBookReader
{
    public partial class Form1 : Form
    {
        string theEBook;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.DownloadStringCompleted += (s, eArgs) =>
            {
                theEBook = eArgs.Result;
                txtBook.Text = theEBook;
            };

            //The Project Gutenberg EBook of A Tale of Two cities, by Charles Dickens
            wc.DownloadStringAsync(new Uri("http://www.gutenberg.org/files/98/98-8.txt"));
        }

        private void btnGetStats_Click(object sender, EventArgs e)
        {
            //Get the words from the e-book.
            string[] words = theEBook.Split(new char[]
            { ' ', '\u000a',',','.',';',':',':','-','?','/' }, StringSplitOptions.RemoveEmptyEntries);
            
            string[] tenMostCommon = null; 
            string longestWord = string.Empty;

            Parallel.Invoke(() =>
            {
                //Now, find the ten most common words
                tenMostCommon = FindTenMostCommon(words);
            },()=> {
                //Get Longest word
                longestWord = FindLongestWord(words);
            });

            //Now that all tasks are complete, build a string to show all
            //stats in a message
            StringBuilder bookStat = new StringBuilder("Ten Most Common Words are :\n");
            foreach (string s in tenMostCommon) {
                bookStat.AppendLine(s);
            }

            bookStat.AppendFormat($"Longest word is: {longestWord}");
            bookStat.AppendLine();
            MessageBox.Show(bookStat.ToString(), "Book info");
            
        }

        private string[] FindTenMostCommon(string[] words) {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            string[] commonWords = (frequencyOrder.Take(10)).ToArray();
            return commonWords;
        }

        private string FindLongestWord(string[] words) {
            return (from w in words orderby w.Length descending select w).FirstOrDefault();
        }
    }
}
