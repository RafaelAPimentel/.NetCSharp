using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataParallelismWithForEach
{
    public partial class MainForm : Form
    {
        //New form-Level variable.
        private CancellationTokenSource cancelToken = new CancellationTokenSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ProcessFiles() {
            //Use  ParallelOptions instance to store the cancelationToken.
            ParallelOptions parOpts = new ParallelOptions();
            parOpts.CancellationToken = cancelToken.Token;
            parOpts.MaxDegreeOfParallelism = System.Environment.ProcessorCount;

            //Load up all *.jpg files and make a new fo,der for the omdified data
            string[] files = Directory.GetFiles(@"C:\Users\rafyr\Pictures", "*.jpg", SearchOption.AllDirectories);
            string newDir = @"C:\Users\rafyr\ModifiedPictures";
            Directory.CreateDirectory(newDir);

            try
            {
                //process the image data in a blocking manner
                Parallel.ForEach(files, currentFile =>
                {
                    string filename = Path.GetFileName(currentFile);

                    using (Bitmap bitmap = new Bitmap(currentFile))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bitmap.Save(Path.Combine(newDir, filename));

                        //This code state is now a problem
                        //this.Text = string.Format($"Processing {filename} on thread {Thread.CurrentThread.ManagedThreadId}");

                        this.Invoke((Action)delegate
                        {
                            this.Text = string.Format($"Processing {filename} on thread {Thread.CurrentThread.ManagedThreadId}");
                        });

                    }
                });
                this.Invoke((Action)delegate
                {
                    this.Text = "Done";
                });
            }
            catch (OperationCanceledException ex)
            {
                this.Invoke((Action)delegate
                {
                    this.Text = ex.Message;
                });
            }
        }

        private void btnProcessImage_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                ProcessFiles();
            });
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //This will used to tell all the worker threads to stop
            cancelToken.Cancel();
        }
    }
}
