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
            this.waterLevelTextBox = new System.Windows.Forms.TextBox();
            this.chTextBox = new System.Windows.Forms.TextBox();
            this.coTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pumpPictureBox = new System.Windows.Forms.PictureBox();
            this.espaceTupleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minageDataSet = new DrainageMine.MinageDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.espaceTupleTableAdapter = new DrainageMine.MinageDataSetTableAdapters.EspaceTupleTableAdapter();
            this.tableAdapterManager = new DrainageMine.MinageDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.H2OSeuilHautLabel = new System.Windows.Forms.Label();
            this.H2OSeuilHautTextBox = new System.Windows.Forms.TextBox();
            this.CH4SeuilHautTextBox = new System.Windows.Forms.TextBox();
            this.CH4SeuilHautLabel = new System.Windows.Forms.Label();
            this.COSeuilHautTextBox = new System.Windows.Forms.TextBox();
            this.COSeuilHautLabel = new System.Windows.Forms.Label();
            this.setSeuilHautButton = new System.Windows.Forms.Button();
            this.designPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espaceTupleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minageDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // designPanel
            // 
            this.designPanel.Controls.Add(this.waterLevelTextBox);
            this.designPanel.Controls.Add(this.chTextBox);
            this.designPanel.Controls.Add(this.coTextBox);
            this.designPanel.Controls.Add(this.pictureBox1);
            this.designPanel.Controls.Add(this.pumpPictureBox);
            this.designPanel.Location = new System.Drawing.Point(13, 11);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(740, 510);
            this.designPanel.TabIndex = 0;
            // 
            // waterLevelTextBox
            // 
            this.waterLevelTextBox.Location = new System.Drawing.Point(400, 387);
            this.waterLevelTextBox.Name = "waterLevelTextBox";
            this.waterLevelTextBox.ReadOnly = true;
            this.waterLevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.waterLevelTextBox.TabIndex = 4;
            // 
            // chTextBox
            // 
            this.chTextBox.Location = new System.Drawing.Point(501, 191);
            this.chTextBox.Name = "chTextBox";
            this.chTextBox.ReadOnly = true;
            this.chTextBox.Size = new System.Drawing.Size(100, 20);
            this.chTextBox.TabIndex = 3;
            // 
            // coTextBox
            // 
            this.coTextBox.Location = new System.Drawing.Point(501, 141);
            this.coTextBox.Name = "coTextBox";
            this.coTextBox.ReadOnly = true;
            this.coTextBox.Size = new System.Drawing.Size(100, 20);
            this.coTextBox.TabIndex = 2;
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
            this.espaceTupleBindingSource.DataSource = this.minageDataSet;
            // 
            // minageDataSet
            // 
            this.minageDataSet.DataSetName = "MinageDataSet";
            this.minageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(772, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 510);
            this.panel1.TabIndex = 1;
            // 
            // espaceTupleTableAdapter
            // 
            this.espaceTupleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EspaceTupleTableAdapter = this.espaceTupleTableAdapter;
            this.tableAdapterManager.UpdateOrder = DrainageMine.MinageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.groupBox1.Size = new System.Drawing.Size(188, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seuils capteurs haut";
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
            // H2OSeuilHautTextBox
            // 
            this.H2OSeuilHautTextBox.Location = new System.Drawing.Point(41, 28);
            this.H2OSeuilHautTextBox.Name = "H2OSeuilHautTextBox";
            this.H2OSeuilHautTextBox.Size = new System.Drawing.Size(138, 20);
            this.H2OSeuilHautTextBox.TabIndex = 1;
            this.H2OSeuilHautTextBox.Text = "200";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.designPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.designPanel.ResumeLayout(false);
            this.designPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espaceTupleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minageDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private MinageDataSet minageDataSet;
        private System.Windows.Forms.BindingSource espaceTupleBindingSource;
        private MinageDataSetTableAdapters.EspaceTupleTableAdapter espaceTupleTableAdapter;
        private MinageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label H2OSeuilHautLabel;
        private System.Windows.Forms.TextBox CH4SeuilHautTextBox;
        private System.Windows.Forms.Label CH4SeuilHautLabel;
        private System.Windows.Forms.TextBox H2OSeuilHautTextBox;
        private System.Windows.Forms.Button setSeuilHautButton;
        private System.Windows.Forms.TextBox COSeuilHautTextBox;
        private System.Windows.Forms.Label COSeuilHautLabel;
    }
}

