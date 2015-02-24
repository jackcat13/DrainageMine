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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coTextBox = new System.Windows.Forms.TextBox();
            this.chTextBox = new System.Windows.Forms.TextBox();
            this.waterLevelTextBox = new System.Windows.Forms.TextBox();
            this.designPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pumpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // designPanel
            // 
            this.designPanel.Controls.Add(this.waterLevelTextBox);
            this.designPanel.Controls.Add(this.chTextBox);
            this.designPanel.Controls.Add(this.coTextBox);
            this.designPanel.Controls.Add(this.pictureBox1);
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
            this.pumpPictureBox.Location = new System.Drawing.Point(240, 364);
            this.pumpPictureBox.Name = "pumpPictureBox";
            this.pumpPictureBox.Size = new System.Drawing.Size(126, 69);
            this.pumpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pumpPictureBox.TabIndex = 0;
            this.pumpPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // coTextBox
            // 
            this.coTextBox.Location = new System.Drawing.Point(400, 141);
            this.coTextBox.Name = "coTextBox";
            this.coTextBox.ReadOnly = true;
            this.coTextBox.Size = new System.Drawing.Size(100, 20);
            this.coTextBox.TabIndex = 2;
            // 
            // chTextBox
            // 
            this.chTextBox.Location = new System.Drawing.Point(400, 191);
            this.chTextBox.Name = "chTextBox";
            this.chTextBox.ReadOnly = true;
            this.chTextBox.Size = new System.Drawing.Size(100, 20);
            this.chTextBox.TabIndex = 3;
            // 
            // waterLevelTextBox
            // 
            this.waterLevelTextBox.Location = new System.Drawing.Point(400, 387);
            this.waterLevelTextBox.Name = "waterLevelTextBox";
            this.waterLevelTextBox.ReadOnly = true;
            this.waterLevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.waterLevelTextBox.TabIndex = 4;
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
            this.designPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pumpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.PictureBox pumpPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox waterLevelTextBox;
        private System.Windows.Forms.TextBox chTextBox;
        private System.Windows.Forms.TextBox coTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

