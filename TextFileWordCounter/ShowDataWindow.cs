using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TextFileWordCounter
{
    public partial class ShowDataWindow : Form
    {
        private IDictionary<string, int> _words;

        public ShowDataWindow(IDictionary<string, int> words, string title)
        {
            InitializeComponent();

            _words = words;
            dataTitle.Text = title;

            FormatWordsAsTable();
        }

        private void FormatWordsAsTable()
        {
            var wordsSortedByCount = _words.OrderByDescending(x => x.Value);
            var formattedTable = from row in wordsSortedByCount select new {Wort = row.Key, Anzahl = row.Value};
            dataGridView1.Visible = true;
            dataGridView1.DataSource = formattedTable.ToArray();
        }
    }
}