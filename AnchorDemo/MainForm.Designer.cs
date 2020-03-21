namespace AnchorDemo
{
    partial class MainForm
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
            this.bAnchorDemo = new System.Windows.Forms.Button();
            this.bDockDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAnchorDemo
            // 
            this.bAnchorDemo.Location = new System.Drawing.Point(47, 38);
            this.bAnchorDemo.Name = "bAnchorDemo";
            this.bAnchorDemo.Size = new System.Drawing.Size(194, 27);
            this.bAnchorDemo.TabIndex = 0;
            this.bAnchorDemo.Text = "Anchor (horgonyzás) demo";
            this.bAnchorDemo.UseVisualStyleBackColor = true;
            this.bAnchorDemo.Click += new System.EventHandler(this.bAnchorDemo_Click);
            // 
            // bDockDemo
            // 
            this.bDockDemo.Location = new System.Drawing.Point(47, 84);
            this.bDockDemo.Name = "bDockDemo";
            this.bDockDemo.Size = new System.Drawing.Size(194, 27);
            this.bDockDemo.TabIndex = 1;
            this.bDockDemo.Text = "Dock (dokk, csatolás) demo";
            this.bDockDemo.UseVisualStyleBackColor = true;
            this.bDockDemo.Click += new System.EventHandler(this.bDockDemo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 153);
            this.Controls.Add(this.bDockDemo);
            this.Controls.Add(this.bAnchorDemo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Anchor és dock demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAnchorDemo;
        private System.Windows.Forms.Button bDockDemo;
    }
}