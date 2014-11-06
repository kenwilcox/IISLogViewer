using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IISLogParser;

namespace IISLogViewer
{
  public partial class frmMain : Form
  {
    private string _logFile;

    public frmMain()
    {
      InitializeComponent();
    }

    private void UpdateProgress(object sender, int position, int count)
    {
      progress.Maximum = count;
      progress.Value = position;
      Application.DoEvents();
      Cursor.Current = Cursors.WaitCursor;
    }

    private void ParseLogFile()
    {
      Cursor.Current = Cursors.WaitCursor;
      progress.Visible = true;

      LogParser parser = new LogParser();
      parser.ParseLog(_logFile, UpdateProgress);

      DataTable table = parser.GridList;
      grid.DataSource = table;
      lblCount.Text = String.Format("Count: {0:n0}", table.Rows.Count);

      grid.Columns[grid.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

      Cursor.Current = Cursors.Default;
      progress.Visible = false;
    }

    private void btnGo_Click(object sender, EventArgs e)
    {
      DateTime start = DateTime.Now;
      if (openFileDlg.ShowDialog(this) == DialogResult.OK)
      {
        _logFile = openFileDlg.FileName;
        txtPath.Text = _logFile;
        ParseLogFile();
      }
      TimeSpan time = DateTime.Now - start;
      lblCount.Text += " - (" + time.Duration().ToString() + ")";
    }
  }
}
