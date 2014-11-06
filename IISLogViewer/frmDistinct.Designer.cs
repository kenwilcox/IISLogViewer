namespace IISLogViewer
{
  partial class frmDistinct
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.pnlTop = new System.Windows.Forms.Panel();
      this.btnDistinct = new System.Windows.Forms.Button();
      this.cboDistinct = new System.Windows.Forms.ComboBox();
      this.lblField = new System.Windows.Forms.Label();
      this.txtDistinct = new System.Windows.Forms.TextBox();
      this.btnCount = new System.Windows.Forms.Button();
      this.grid = new System.Windows.Forms.DataGridView();
      this.pnlTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlTop
      // 
      this.pnlTop.Controls.Add(this.btnCount);
      this.pnlTop.Controls.Add(this.btnDistinct);
      this.pnlTop.Controls.Add(this.cboDistinct);
      this.pnlTop.Controls.Add(this.lblField);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(402, 42);
      this.pnlTop.TabIndex = 0;
      // 
      // btnDistinct
      // 
      this.btnDistinct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDistinct.Location = new System.Drawing.Point(216, 10);
      this.btnDistinct.Name = "btnDistinct";
      this.btnDistinct.Size = new System.Drawing.Size(84, 23);
      this.btnDistinct.TabIndex = 2;
      this.btnDistinct.Text = "Distinct List";
      this.btnDistinct.UseVisualStyleBackColor = true;
      this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
      // 
      // cboDistinct
      // 
      this.cboDistinct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cboDistinct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboDistinct.FormattingEnabled = true;
      this.cboDistinct.Location = new System.Drawing.Point(48, 12);
      this.cboDistinct.Name = "cboDistinct";
      this.cboDistinct.Size = new System.Drawing.Size(162, 21);
      this.cboDistinct.TabIndex = 1;
      // 
      // lblField
      // 
      this.lblField.AutoSize = true;
      this.lblField.Location = new System.Drawing.Point(12, 15);
      this.lblField.Name = "lblField";
      this.lblField.Size = new System.Drawing.Size(29, 13);
      this.lblField.TabIndex = 0;
      this.lblField.Text = "Field";
      // 
      // txtDistinct
      // 
      this.txtDistinct.AcceptsReturn = true;
      this.txtDistinct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtDistinct.Location = new System.Drawing.Point(12, 48);
      this.txtDistinct.Multiline = true;
      this.txtDistinct.Name = "txtDistinct";
      this.txtDistinct.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtDistinct.Size = new System.Drawing.Size(382, 202);
      this.txtDistinct.TabIndex = 1;
      // 
      // btnCount
      // 
      this.btnCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCount.Location = new System.Drawing.Point(306, 10);
      this.btnCount.Name = "btnCount";
      this.btnCount.Size = new System.Drawing.Size(84, 23);
      this.btnCount.TabIndex = 3;
      this.btnCount.Text = "Distinct Count";
      this.btnCount.UseVisualStyleBackColor = true;
      this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
      // 
      // grid
      // 
      this.grid.AllowUserToAddRows = false;
      this.grid.AllowUserToDeleteRows = false;
      this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid.Location = new System.Drawing.Point(68, 60);
      this.grid.Name = "grid";
      this.grid.RowHeadersWidth = 15;
      this.grid.Size = new System.Drawing.Size(260, 180);
      this.grid.TabIndex = 3;
      this.grid.Visible = false;
      // 
      // frmDistinct
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(402, 262);
      this.Controls.Add(this.grid);
      this.Controls.Add(this.txtDistinct);
      this.Controls.Add(this.pnlTop);
      this.Name = "frmDistinct";
      this.Text = "Find Distinct";
      this.Load += new System.EventHandler(this.frmDistinct_Load);
      this.pnlTop.ResumeLayout(false);
      this.pnlTop.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Button btnDistinct;
    private System.Windows.Forms.ComboBox cboDistinct;
    private System.Windows.Forms.Label lblField;
    private System.Windows.Forms.TextBox txtDistinct;
    private System.Windows.Forms.Button btnCount;
    private System.Windows.Forms.DataGridView grid;
  }
}