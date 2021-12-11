
namespace floydAlgoritmasi
{
    partial class FloydMatrisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloydMatrisForm));
            this.matrisTextBoxPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelSMatris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matrisTextBoxPanel
            // 
            this.matrisTextBoxPanel.Location = new System.Drawing.Point(28, 38);
            this.matrisTextBoxPanel.Name = "matrisTextBoxPanel";
            this.matrisTextBoxPanel.Size = new System.Drawing.Size(402, 318);
            this.matrisTextBoxPanel.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(453, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 320);
            this.listBox1.TabIndex = 1;
            // 
            // labelSMatris
            // 
            this.labelSMatris.AutoSize = true;
            this.labelSMatris.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSMatris.Location = new System.Drawing.Point(552, 38);
            this.labelSMatris.Name = "labelSMatris";
            this.labelSMatris.Size = new System.Drawing.Size(151, 20);
            this.labelSMatris.TabIndex = 2;
            this.labelSMatris.Text = "*** S MATRİSİ ***";
            // 
            // FloydMatrisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(875, 446);
            this.Controls.Add(this.labelSMatris);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.matrisTextBoxPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FloydMatrisForm";
            this.Text = "En Kısa Uzaklık";
            this.Load += new System.EventHandler(this.FloydMatrisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel matrisTextBoxPanel;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelSMatris;
    }
}