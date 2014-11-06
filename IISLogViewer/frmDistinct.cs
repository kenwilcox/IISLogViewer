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
  public partial class frmDistinct : Form
  {
    private LogParser _parser;

    public frmDistinct()
    {
      InitializeComponent();
    }

    public LogParser Parser
    {
      set
      {
        _parser = value;
      }
    }

    private void frmDistinct_Load(object sender, EventArgs e)
    {
      if (_parser != null)
      {
        cboDistinct.Items.AddRange(_parser.FieldNames.ToArray());
        cboDistinct.SelectedIndex = 0;
      }
    }

    private void btnDistinct_Click(object sender, EventArgs e)
    {
      List<string> list = _parser.Distinct(cboDistinct.SelectedItem.ToString());
      txtDistinct.Text = String.Join(Environment.NewLine, list.ToArray());
      txtDistinct.Visible = true;
      grid.Visible = false;
    }

    private void btnCount_Click(object sender, EventArgs e)
    {
      DictionaryCount ret = _parser.DistinctCount(cboDistinct.SelectedItem.ToString());
      grid.Size = txtDistinct.Size;
      grid.Location = txtDistinct.Location;
      txtDistinct.Visible = false;
      grid.Visible = true;
      grid.DataSource = ret.DataTable;
      grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }
  }
}
