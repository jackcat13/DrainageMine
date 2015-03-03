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
            this.H2OSeuilLabel = new System.Windows.Forms.Label();
            this.H2OSeuilTextBox = new System.Windows.Forms.TextBox();
            this.CH4SeuilTextBox = new System.Windows.Forms.TextBox();
            this.CH4SeuilLabel = new System.Windows.Forms.Label();
            this.CO2SeuilTextBox = new System.Windows.Forms.TextBox();
            this.CO2SeuilLabel = new System.Windows.Forms.Label();
            this.setSeuilButton = new System.Windows.Forms.Button();
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
            this.chTextBox.Location = new System.Drawing.Point(400, 191);
            this.chTextBox.Name = "chTextBox";
            this.chTextBox.ReadOnly = true;
            this.chTextBox.Size = new System.Drawing.Size(100, 20);
            this.chTextBox.TabIndex = 3;
            // 
            // coTextBox
            // 
            this.coTextBox.Location = new System.Drawing.Point(400, 141);
            this.coTextBox.Name = "coTextBox";
            this.coTextBox.ReadOnly = true;
            this.coTextBox.Size = new System.Drawing.Size(100, 20);
            this.coTextBox.TabIndex = 2;
            this.coTextBox.Text = "50";
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
            this.groupBox1.Controls.Add(this.setSeuilButton);
            this.groupBox1.Controls.Add(this.CO2SeuilTextBox);
            this.groupBox1.Controls.Add(this.CO2SeuilLabel);
            this.groupBox1.Controls.Add(this.CH4SeuilTextBox);
            this.groupBox1.Controls.Add(this.CH4SeuilLabel);
            this.groupBox1.Controls.Add(this.H2OSeuilTextBox);
            this.groupBox1.Controls.Add(this.H2OSeuilLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seuils capteurs";
            // 
            // H2OSeuilLabel
            // 
            this.H2OSeuilLabel.AutoSize = true;
            this.H2OSeuilLabel.Location = new System.Drawing.Point(6, 31);
            this.H2OSeuilLabel.Name = "H2OSeuilLabel";
            this.H2OSeuilLabel.Size = new System.Drawing.Size(29, 13);
            this.H2OSeuilLabel.TabIndex = 0;
            this.H2OSeuilLabel.Text = "H2O";
            // 
            // H2OSeuilTextBox
            // 
            this.H2OSeuilTextBox.Location = new System.Drawing.Point(41, 28);
            this.H2OSeuilTextBox.Name = "H2OSeuilTextBox";
            this.H2OSeuilTextBox.Size = new System.Drawing.Size(138, 20);
            this.H2OSeuilTextBox.TabIndex = 1;
            this.H2OSeuilTextBox.Text = "200";
            // 
            // CH4SeuilTextBox
            // 
            this.CH4SeuilTextBox.Location = new System.Drawing.Point(41, 53);
            this.CH4SeuilTextBox.Name = "CH4SeuilTextBox";
            this.CH4SeuilTextBox.Size = new System.Drawing.Size(138, 20);
            this.CH4SeuilTextBox.TabIndex = 3;
            this.CH4SeuilTextBox.Text = "300";
            // 
            // CH4SeuilLabel
            // 
            this.CH4SeuilLabel.AutoSize = true;
            this.CH4SeuilLabel.Location = new System.Drawing.Point(6, 56);
            this.CH4SeuilLabel.Name = "CH4SeuilLabel";
            this.CH4SeuilLabel.Size = new System.Drawing.Size(28, 13);
            this.CH4SeuilLabel.TabIndex = 2;
            this.CH4SeuilLabel.Text = "CH4";
            // 
            // CO2SeuilTextBox
            // 
            this.CO2SeuilTextBox.Location = new System.Drawing.Point(41, 78);
            this.CO2SeuilTextBox.Name = "CO2SeuilTextBox";
            this.CO2SeuilTextBox.Size = new System.Drawing.Size(138, 20);
            this.CO2SeuilTextBox.TabIndex = 5;
            this.CO2SeuilTextBox.Text = "330";
            // 
            // CO2SeuilLabel
            // 
            this.CO2SeuilLabel.AutoSize = true;
            this.CO2SeuilLabel.Location = new System.Drawing.Point(6, 81);
            this.CO2SeuilLabel.Name = "CO2SeuilLabel";
            this.CO2SeuilLabel.Size = new System.Drawing.Size(28, 13);
            this.CO2SeuilLabel.TabIndex = 4;
            this.CO2SeuilLabel.Text = "CO2";
            // 
            // setSeuilButton
            // 
            this.setSeuilButton.Location = new System.Drawing.Point(100, 104);
            this.setSeuilButton.Name = "setSeuilButton";
            this.setSeuilButton.Size = new System.Drawing.Size(79, 27);
            this.setSeuilButton.TabIndex = 6;
            this.setSeuilButton.Text = "Set seuils";
            this.setSeuilButton.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Label H2OSeuilLabel;
        private System.Windows.Forms.TextBox CH4SeuilTextBox;
        private System.Windows.Forms.Label CH4SeuilLabel;
        private System.Windows.Forms.TextBox H2OSeuilTextBox;
        private System.Windows.Forms.Button setSeuilButton;
        private System.Windows.Forms.TextBox CO2SeuilTextBox;
        private System.Windows.Forms.Label CO2SeuilLabel;
    }
}

