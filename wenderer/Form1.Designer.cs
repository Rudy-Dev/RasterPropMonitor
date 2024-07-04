namespace wenderer;

partial class RealWindow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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

    //protected override void OnPaint(PaintEventArgs e)
    //{
    //    base.OnPaint(e);

    //    var screenshot = new Texture2D(screenTexture.width, screenTexture.height);
    //    RenderTexture backupRenderTexture = RenderTexture.active;
    //    RenderTexture.active = screenTexture;
    //    screenshot.ReadPixels(new Rect(0, 0, screenTexture.width, screenTexture.height), 0, 0);
    //    RenderTexture.active = backupRenderTexture;
    //    var bytes = ImageConversion.EncodeToPNG(screenshot);
    //}
    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.Location = new System.Drawing.Point(0, 0);
        this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(484, 463);
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(484, 461);
        this.Controls.Add(this.pictureBox1);
        this.MaximizeBox = false;
        this.MaximumSize = new System.Drawing.Size(500, 500);
        this.MdiChildrenMinimizedAnchorBottom = false;
        this.MinimizeBox = false;
        this.MinimumSize = new System.Drawing.Size(500, 500);
        this.Name = "Form1";
        this.ShowIcon = false;
        this.Text = "Form1";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion
    private PictureBox pictureBox1;
}
