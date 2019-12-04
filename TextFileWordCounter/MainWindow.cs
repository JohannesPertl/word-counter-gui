using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TextFileWordCounter
{
    public partial class MainWindow : Form
    {
        private WordCounter _wordCounter;

        public MainWindow()
        {
            InitializeComponent();
            ShowChoosingFileScreen();
        }

        private void btnFileInput_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;

            var path = openFileDialog1.FileName;

            _wordCounter = new WordCounter(path);

            ShowCountOperationScreen();
        }

        private async void btnCount_Click(object sender, EventArgs e)
        {
            ShowProgressScreen();

            _wordCounter.CancellationTokenSource = new CancellationTokenSource();

            try
            {
                var data = await Task.Run(() => _wordCounter.GetWordsAsDict(),
                    _wordCounter.CancellationTokenSource.Token);

                OpenNewDataWindow(data);
            }

            catch (Exception ex)
            {
                Trace.TraceError(ex.StackTrace);
            }
            finally
            {
                _wordCounter.CancellationTokenSource.Dispose();
            }


            ShowChoosingFileScreen();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            _wordCounter.CancellationTokenSource.Cancel();
        }


        private void OpenNewDataWindow(ConcurrentDictionary<string, int> data)
        {
            var title = "Anzahl der Wörter in:  " + openFileDialog1.SafeFileName;
            var dataWindow = new ShowDataWindow(data, title)
            {
                Text = openFileDialog1.SafeFileName
            };

            dataWindow.Show();
        }


        private void btnNewFile_Click(object sender, EventArgs e)
        {
            ShowChoosingFileScreen();
        }

        private void ShowChoosingFileScreen()
        {
            btnFileInput.Visible = true;
            btnAbort.Visible = false;
            btnCount.Visible = false;
            btnNewFile.Visible = false;
            btnAbort.Visible = false;
            labelFile.Visible = false;
            labelInProgress.Visible = false;
            progressBar1.Visible = false;
            labelChoosenFile.Visible = false;
        }

        private void ShowCountOperationScreen()
        {
            labelFile.Visible = true;
            labelFile.Text = openFileDialog1.SafeFileName;
            btnCount.Visible = true;
            btnNewFile.Visible = true;
            btnAbort.Visible = false;
            btnFileInput.Visible = false;
            progressBar1.Visible = false;
            labelInProgress.Visible = false;
            labelChoosenFile.Visible = true;
        }

        private void ShowProgressScreen()
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.BringToFront();

            progressBar1.Visible = true;
            btnAbort.Visible = true;
            labelFile.Visible = false;
            btnCount.Visible = false;
            btnFileInput.Visible = false;
            btnNewFile.Visible = false;
            labelInProgress.Visible = true;
            labelChoosenFile.Visible = false;

        }
    }
}