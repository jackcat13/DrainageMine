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
            this.designPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espaceTupleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // designPanel
            // 
            this.designPanel.Controls.Add(this.waterLevelTextBox);
            this.designPanel.Controls.Add(this.chTextBox);
            this.designPanel.Controls.Add(this.coTextBox);
            this.designPanel.Controls.Add(this.pictureBox1);
            this.designPanel.Controls.Add(this.pumpPictureBox);
            this.designPanel.Location = new System.Drawing.Point(17, 14);
            this.designPanel.Margin = new System.Windows.Forms.Padding(4);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(987, 628);
            this.designPanel.TabIndex = 0;
            // 
            // waterLevelTextBox
            // 
            this.waterLevelTextBox.Location = new System.Drawing.Point(533, 476);
            this.waterLevelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.waterLevelTextBox.Name = "waterLevelTextBox";
            this.waterLevelTextBox.ReadOnly = true;
            this.waterLevelTextBox.Size = new System.Drawing.Size(132, 22);
            this.waterLevelTextBox.TabIndex = 4;
            // 
            // chTextBox
            // 
            this.chTextBox.Location = new System.Drawing.Point(533, 235);
            this.chTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.chTextBox.Name = "chTextBox";
            this.chTextBox.ReadOnly = true;
            this.chTextBox.Size = new System.Drawing.Size(132, 22);
            this.chTextBox.TabIndex = 3;
            // 
            // coTextBox
            // 
            this.coTextBox.Location = new System.Drawing.Point(533, 174);
            this.coTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.coTextBox.Name = "coTextBox";
            this.coTextBox.ReadOnly = true;
            this.coTextBox.Size = new System.Drawing.Size(132, 22);
            this.coTextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 174);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pumpPictureBox
            // 
            this.pumpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pumpPictureBox.Image")));
            this.pumpPictureBox.Location = new System.Drawing.Point(320, 448);
            this.pumpPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pumpPictureBox.Name = "pumpPictureBox";
            this.pumpPictureBox.Size = new System.Drawing.Size(168, 85);
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
            this.panel1.Location = new System.Drawing.Point(1029, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 628);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.designPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.designPanel.ResumeLayout(false);
            this.designPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pumpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espaceTupleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minageDataSet)).EndInit();
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
    }
}

