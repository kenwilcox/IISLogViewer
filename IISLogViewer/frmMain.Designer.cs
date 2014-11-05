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
      ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
      this.SuspendLayout();
      // 
      // btnGo
      // 
      this.btnGo.Location = new System.Drawing.Point(12, 12);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 0;
      this.btnGo.Text = "Go";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // grid
      // 
      this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid.Location = new System.Drawing.Point(12, 58);
      this.grid.Name = "grid";
      this.grid.Size = new System.Drawing.Size(260, 192);
      this.grid.TabIndex = 1;
      // 
      // lblCount
      // 
      this.lblCount.AutoSize = true;
      this.lblCount.Location = new System.Drawing.Point(93, 17);
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
      this.progress.TabIndex = 3;
      this.progress.Visible = false;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
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
  }
}

