namespace IISLogViewer
{
  partial class frmMain
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
      this.btnGo = new System.Windows.Forms.Button();
      this.grid = new System.Windows.Forms.DataGridView();
      this.lblCount = new System.Windows.Forms.Label();
      this.progress = new System.Windows.Forms.ProgressBar();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
      this.SuspendLayout();
      // 
      // btnGo
      // 
      this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGo.Location = new System.Drawing.Point(228, 12);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(44, 20);
      this.btnGo.TabIndex = 1;
      this.btnGo.Text = "...";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // grid
      // 
      this.grid.AllowUserToAddRows = false;
      this.grid.AllowUserToDeleteRows = false;
      this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid.Location = new System.Drawing.Point(12, 58);
      this.grid.Name = "grid";
      this.grid.RowHeadersWidth = 15;
      this.grid.Size = new System.Drawing.Size(260, 180);
      this.grid.TabIndex = 2;
      // 
      // lblCount
      // 
      this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblCount.AutoSize = true;
      this.lblCount.Location = new System.Drawing.Point(12, 241);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(38, 13);
      this.lblCount.TabIndex = 2;
      this.lblCount.Text = "Count:";
      // 
      // progress
      // 
      this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progress.Location = new System.Drawing.Point(12, 41);
      this.progress.Name = "progress";
      this.progress.Size = new System.Drawing.Size(260, 11);
      this.progress.TabIndex = 4;
      this.progress.Visible = false;
      // 
      // txtPath
      // 
      this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPath.Location = new System.Drawing.Point(12, 12);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(210, 20);
      this.txtPath.TabIndex = 0;
      // 
      // openFileDlg
      // 
      this.openFileDlg.Filter = "Log Files|*.log";
      this.openFileDlg.InitialDirectory = "C:\\inetpub\\logs";
      this.openFileDlg.Title = "Open Log File";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.progress);
      this.Controls.Add(this.lblCount);
      this.Controls.Add(this.grid);
      this.Controls.Add(this.btnGo);
      this.Name = "frmMain";
      this.Text = "Viewer";
      ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnGo;
    private System.Windows.Forms.DataGridView grid;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.ProgressBar progress;
    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.OpenFileDialog openFileDlg;
  }
}

