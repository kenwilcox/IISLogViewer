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
    public frmMain()
    {
      InitializeComponent();
    }

    private void UpdateProgress(object sender, int position, int count)
    {
      progress.Maximum = count;
      progress.Value = position;
      Application.DoEvents();
    }

    private void btnGo_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      progress.Visible = true;

      LogParser parser = new LogParser();
      parser.ParseLog(@"..\..\u_ex120921.log", UpdateProgress);
      
      DataTable table = parser.GridList;
      grid.DataSource = table;
      lblCount.Text = String.Format("Count: {0:n0}", table.Rows.Count);
      
      Cursor.Current = Cursors.Default;
      progress.Visible = false;
    }
  }
}
