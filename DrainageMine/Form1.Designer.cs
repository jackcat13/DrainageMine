namespace DrainageMine
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.designPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pumpPictureBox = new System.Windows.Forms.PictureBox();
            this.designPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pumpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // designPanel
            // 
            this.designPanel.Controls.Add(this.pumpPictureBox);
            this.designPanel.Location = new System.Drawing.Point(13, 13);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(740, 510);
            this.designPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(772, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 510);
            this.panel1.TabIndex = 1;
            // 
            // pumpPictureBox
            // 
            this.pumpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pumpPictureBox.Image")));
            this.pumpPictureBox.Location = new System.Drawing.Point(132, 354);
            this.pumpPictureBox.Name = "pumpPictureBox";
            this.pumpPictureBox.Size = new System.Drawing.Size(126, 61);
            this.pumpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pumpPictureBox.TabIndex = 0;
            this.pumpPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.designPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.designPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pumpPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.PictureBox pumpPictureBox;
        private System.Windows.Forms.Panel panel1;
    }
}

