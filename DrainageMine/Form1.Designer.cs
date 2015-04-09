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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.designPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pumpPictureBox = new System.Windows.Forms.PictureBox();
            this.espaceTupleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.COValueTextBox = new System.Windows.Forms.TextBox();
            this.COValue = new System.Windows.Forms.Label();
            this.CH4ValueTextBox = new System.Windows.Forms.TextBox();
            this.CH4Value = new System.Windows.Forms.Label();
            this.H2OValueTextBox = new System.Windows.Forms.TextBox();
            this.H2OValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setSeuilHautButton = new System.Windows.Forms.Button();
            this.COSeuilHautTextBox = new System.Windows.Forms.TextBox();
            this.COSeuilHautLabel = new System.Windows.Forms.Label();
            this.CH4SeuilHautTextBox = new System.Windows.Forms.TextBox();
            this.CH4SeuilHautLabel = new System.Windows.Forms.Label();
            this.H2OSeuilHautTextBox = new System.Windows.Forms.TextBox();
            this.H2OSeuilHautLabel = new System.Windows.Forms.Label();
            this.designPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espaceTupleBindingSource)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // designPanel
            // 
            this.designPanel.Controls.Add(this.pictureBox1);
            this.designPanel.Controls.Add(this.pumpPictureBox);
            this.designPanel.Location = new System.Drawing.Point(13, 11);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(740, 510);
            this.designPanel.TabIndex = 0;
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
            // espaceTupleBindingSource
            // 
            this.espaceTupleBindingSource.DataMember = "EspaceTuple";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.groupBox2);
            this.ControlPanel.Controls.Add(this.groupBox1);
            this.ControlPanel.Location = new System.Drawing.Point(772, 13);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(454, 510);
            this.ControlPanel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.COValueTextBox);
            this.groupBox2.Controls.Add(this.COValue);
            this.groupBox2.Controls.Add(this.CH4ValueTextBox);
            this.groupBox2.Controls.Add(this.CH4Value);
            this.groupBox2.Controls.Add(this.H2OValueTextBox);
            this.groupBox2.Controls.Add(this.H2OValue);
            this.groupBox2.Location = new System.Drawing.Point(240, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valeures capteurs";
            // 
            // COValueTextBox
            // 
            this.COValueTextBox.Location = new System.Drawing.Point(41, 78);
            this.COValueTextBox.Name = "COValueTextBox";
            this.COValueTextBox.Size = new System.Drawing.Size(138, 20);
            this.COValueTextBox.TabIndex = 5;
            // 
            // COValue
            // 
            this.COValue.AutoSize = true;
            this.COValue.Location = new System.Drawing.Point(6, 81);
            this.COValue.Name = "COValue";
            this.COValue.Size = new System.Drawing.Size(22, 13);
            this.COValue.TabIndex = 4;
            this.COValue.Text = "CO";
            // 
            // CH4ValueTextBox
            // 
            this.CH4ValueTextBox.Location = new System.Drawing.Point(41, 53);
            this.CH4ValueTextBox.Name = "CH4ValueTextBox";
            this.CH4ValueTextBox.Size = new System.Drawing.Size(138, 20);
            this.CH4ValueTextBox.TabIndex = 3;
            // 
            // CH4Value
            // 
            this.CH4Value.AutoSize = true;
            this.CH4Value.Location = new System.Drawing.Point(6, 56);
            this.CH4Value.Name = "CH4Value";
            this.CH4Value.Size = new System.Drawing.Size(28, 13);
            this.CH4Value.TabIndex = 2;
            this.CH4Value.Text = "CH4";
            // 
            // H2OValueTextBox
            // 
            this.H2OValueTextBox.Location = new System.Drawing.Point(41, 28);
            this.H2OValueTextBox.Name = "H2OValueTextBox";
            this.H2OValueTextBox.Size = new System.Drawing.Size(138, 20);
            this.H2OValueTextBox.TabIndex = 1;
            // 
            // H2OValue
            // 
            this.H2OValue.AutoSize = true;
            this.H2OValue.Location = new System.Drawing.Point(6, 31);
            this.H2OValue.Name = "H2OValue";
            this.H2OValue.Size = new System.Drawing.Size(29, 13);
            this.H2OValue.TabIndex = 0;
            this.H2OValue.Text = "H2O";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setSeuilHautButton);
            this.groupBox1.Controls.Add(this.COSeuilHautTextBox);
            this.groupBox1.Controls.Add(this.COSeuilHautLabel);
            this.groupBox1.Controls.Add(this.CH4SeuilHautTextBox);
            this.groupBox1.Controls.Add(this.CH4SeuilHautLabel);
            this.groupBox1.Controls.Add(this.H2OSeuilHautTextBox);
            this.groupBox1.Controls.Add(this.H2OSeuilHautLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seuils capteurs haut";
            // 
            // setSeuilHautButton
            // 
            this.setSeuilHautButton.Location = new System.Drawing.Point(89, 104);
            this.setSeuilHautButton.Name = "setSeuilHautButton";
            this.setSeuilHautButton.Size = new System.Drawing.Size(90, 27);
            this.setSeuilHautButton.TabIndex = 6;
            this.setSeuilHautButton.Text = "Set seuils haut";
            this.setSeuilHautButton.UseVisualStyleBackColor = true;
            this.setSeuilHautButton.Click += new System.EventHandler(this.setSeuilButton_Click);
            // 
            // COSeuilHautTextBox
            // 
            this.COSeuilHautTextBox.Location = new System.Drawing.Point(41, 78);
            this.COSeuilHautTextBox.Name = "COSeuilHautTextBox";
            this.COSeuilHautTextBox.Size = new System.Drawing.Size(138, 20);
            this.COSeuilHautTextBox.TabIndex = 5;
            this.COSeuilHautTextBox.Text = "330";
            // 
            // COSeuilHautLabel
            // 
            this.COSeuilHautLabel.AutoSize = true;
            this.COSeuilHautLabel.Location = new System.Drawing.Point(6, 81);
            this.COSeuilHautLabel.Name = "COSeuilHautLabel";
            this.COSeuilHautLabel.Size = new System.Drawing.Size(22, 13);
            this.COSeuilHautLabel.TabIndex = 4;
            this.COSeuilHautLabel.Text = "CO";
            // 
            // CH4SeuilHautTextBox
            // 
            this.CH4SeuilHautTextBox.Location = new System.Drawing.Point(41, 53);
            this.CH4SeuilHautTextBox.Name = "CH4SeuilHautTextBox";
            this.CH4SeuilHautTextBox.Size = new System.Drawing.Size(138, 20);
            this.CH4SeuilHautTextBox.TabIndex = 3;
            this.CH4SeuilHautTextBox.Text = "300";
            // 
            // CH4SeuilHautLabel
            // 
            this.CH4SeuilHautLabel.AutoSize = true;
            this.CH4SeuilHautLabel.Location = new System.Drawing.Point(6, 56);
            this.CH4SeuilHautLabel.Name = "CH4SeuilHautLabel";
            this.CH4SeuilHautLabel.Size = new System.Drawing.Size(28, 13);
            this.CH4SeuilHautLabel.TabIndex = 2;
            this.CH4SeuilHautLabel.Text = "CH4";
            // 
            // H2OSeuilHautTextBox
            // 
            this.H2OSeuilHautTextBox.Location = new System.Drawing.Point(41, 28);
            this.H2OSeuilHautTextBox.Name = "H2OSeuilHautTextBox";
            this.H2OSeuilHautTextBox.Size = new System.Drawing.Size(138, 20);
            this.H2OSeuilHautTextBox.TabIndex = 1;
            this.H2OSeuilHautTextBox.Text = "200";
            // 
            // H2OSeuilHautLabel
            // 
            this.H2OSeuilHautLabel.AutoSize = true;
            this.H2OSeuilHautLabel.Location = new System.Drawing.Point(6, 31);
            this.H2OSeuilHautLabel.Name = "H2OSeuilHautLabel";
            this.H2OSeuilHautLabel.Size = new System.Drawing.Size(29, 13);
            this.H2OSeuilHautLabel.TabIndex = 0;
            this.H2OSeuilHautLabel.Text = "H2O";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 535);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.designPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.designPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espaceTupleBindingSource)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.PictureBox pumpPictureBox;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource espaceTupleBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label H2OSeuilHautLabel;
        private System.Windows.Forms.TextBox CH4SeuilHautTextBox;
        private System.Windows.Forms.Label CH4SeuilHautLabel;
        private System.Windows.Forms.TextBox H2OSeuilHautTextBox;
        private System.Windows.Forms.Button setSeuilHautButton;
        private System.Windows.Forms.TextBox COSeuilHautTextBox;
        private System.Windows.Forms.Label COSeuilHautLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox COValueTextBox;
        private System.Windows.Forms.Label COValue;
        private System.Windows.Forms.TextBox CH4ValueTextBox;
        private System.Windows.Forms.Label CH4Value;
        private System.Windows.Forms.TextBox H2OValueTextBox;
        private System.Windows.Forms.Label H2OValue;
    }
}

