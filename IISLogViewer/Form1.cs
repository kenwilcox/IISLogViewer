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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void UpdateProgress(object sender, int position, int count)
    {
      progress.Maximum = count;
      progress.Value = position;
      Application.DoEvents();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      progress.Visible = true;

      LogParser parser = new LogParser();
      parser.ParseLog(@"..\..\u_ex140520.log", UpdateProgress);
      //parser.ParseLog(@"..\..\u_ex120427.log");
      
      DataTable table = parser.GridList;
      grid.DataSource = table;
      label1.Text = String.Format("Count: {0:n0}", table.Rows.Count);
      
      Cursor.Current = Cursors.Default;
      progress.Visible = false;
    }
  }
}
