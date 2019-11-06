namespace Telepresence.Control {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.pnlContent.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContent
      // 
      this.pnlContent.Controls.Add(this.label2);
      this.pnlContent.Controls.Add(this.label1);
      this.pnlContent.Size = new System.Drawing.Size(498, 145);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(11, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(480, 60);
      this.label1.TabIndex = 0;
      this.label1.Text = resources.GetString("label1.Text");
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(11, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(480, 60);
      this.label2.TabIndex = 1;
      this.label2.Text = "You can connect the camera control to the remote port that Ezb camera server is r" +
    "unning on and watch the live feed from either camera.";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 177);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.pnlContent.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}