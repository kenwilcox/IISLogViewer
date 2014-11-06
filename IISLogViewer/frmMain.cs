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
    private LogParser _parser;

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

      _parser = new LogParser();
      _parser.ParseLog(_logFile, UpdateProgress);

      DataTable table = _parser.GridList;
      grid.DataSource = table;
      lblCount.Text = String.Format("Count: {0:n0}", table.Rows.Count);

      grid.Columns[grid.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

      Cursor.Current = Cursors.Default;
      progress.Visible = false;
    }

    private void ResetFields()
    {
      lblCount.Text = "Count:";
      progress.Visible = false;
      grid.DataSource = null;
    }

    private void OpenFile()
    {
      DateTime start = DateTime.Now;
      if (openFileDlg.ShowDialog(this) == DialogResult.OK)
      {
        ResetFields();
        _logFile = openFileDlg.FileName;
        txtPath.Text = _logFile;
        ParseLogFile();
      }
      TimeSpan time = DateTime.Now - start;
      lblCount.Text += " - (" + time.Duration().ToString() + ")";
    }

    private void btnGo_Click(object sender, EventArgs e)
    {
      OpenFile();
    }

    private void mnuOpen_Click(object sender, EventArgs e)
    {
      OpenFile();
    }

    private void mnuEditDistinct_Click(object sender, EventArgs e)
    {
      if (_parser != null)
      {
        frmDistinct frm = new frmDistinct();
        frm.Parser = _parser;
        frm.ShowDialog(this);
        frm.Dispose();
      }
    }
  }
}
