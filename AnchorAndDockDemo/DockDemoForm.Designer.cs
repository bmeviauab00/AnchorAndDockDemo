namespace AnchorAndDockDemo
{
    partial class DockDemoForm
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
            this.bTop = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.bBottom = new System.Windows.Forms.Button();
            this.bFill = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bTop
            // 
            this.bTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bTop.Location = new System.Drawing.Point(0, 0);
            this.bTop.Name = "bTop";
            this.bTop.Size = new System.Drawing.Size(494, 49);
            this.bTop.TabIndex = 1;
            this.bTop.Text = "Felülre dokkolva";
            this.bTop.UseVisualStyleBackColor = true;
            // 
            // bRight
            // 
            this.bRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.bRight.Location = new System.Drawing.Point(398, 49);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(96, 244);
            this.bRight.TabIndex = 2;
            this.bRight.Text = "Jobbra dokkolva";
            this.bRight.UseVisualStyleBackColor = true;
            // 
            // bBottom
            // 
            this.bBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bBottom.Location = new System.Drawing.Point(91, 249);
            this.bBottom.Name = "bBottom";
            this.bBottom.Size = new System.Drawing.Size(307, 44);
            this.bBottom.TabIndex = 3;
            this.bBottom.Text = "Alulra dokkolva";
            this.bBottom.UseVisualStyleBackColor = true;
            // 
            // bFill
            // 
            this.bFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bFill.Location = new System.Drawing.Point(91, 49);
            this.bFill.Name = "bFill";
            this.bFill.Size = new System.Drawing.Size(307, 200);
            this.bFill.TabIndex = 4;
            this.bFill.Text = "Kitöltés (Fill) dokkolva";
            this.bFill.UseVisualStyleBackColor = true;
            // 
            // bLeft
            // 
            this.bLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.bLeft.Location = new System.Drawing.Point(0, 49);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(91, 244);
            this.bLeft.TabIndex = 5;
            this.bLeft.Text = "Balra dokkolva";
            this.bLeft.UseVisualStyleBackColor = true;
            // 
            // DockDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 293);
            this.Controls.Add(this.bFill);
            this.Controls.Add(this.bBottom);
            this.Controls.Add(this.bLeft);
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.bTop);
            this.Name = "DockDemoForm";
            this.Text = "Dokk (illesztés) teszt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bTop;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bBottom;
        private System.Windows.Forms.Button bFill;
        private System.Windows.Forms.Button bLeft;
    }
}