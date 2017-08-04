using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLINQDataProcessingWithCancellation
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancelToken = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            //Start a new task to process the ints
            Task.Factory.StartNew(() =>
            {
                ProcessIntData();
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelToken.Cancel();
        }

        private void ProcessIntData()
        {
            //Get a very large array integers.
            int[] source = Enumerable.Range(1, 20000000).ToArray();

            //Find the numbers where num % 3 == 0 is true, returned
            //in decending order
            int[] modThreeIsZero = null;
            try
            {

                modThreeIsZero = (from num in source.AsParallel().WithCancellation(cancelToken.Token)
                                  where num % 3 == 0
                                  orderby num descending
                                  select num).ToArray();
                MessageBox.Show(string.Format($"Found {modThreeIsZero.Count()} numbers that match query"));
            }
            catch(OperationCanceledException ex)
            {
                this.Invoke((Action)delegate
                {
                    this.Text = ex.Message;
                });
            }
        }
    }
}
