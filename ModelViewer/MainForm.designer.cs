namespace ModelViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.modelsListView = new System.Windows.Forms.ListView();
            this.modelIdColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelNameColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSaveToFileButton = new System.Windows.Forms.ToolStripButton();
            this.modelsFromFileButton = new System.Windows.Forms.ToolStripButton();
            this.helpButton = new System.Windows.Forms.ToolStripButton();
            this.ownerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.directoryTreeControl1 = new ModelViewer.DirectoryTreeControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelsListView
            // 
            this.modelsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modelIdColHeader,
            this.modelNameColHeader,
            this.ownerColumnHeader});
            this.modelsListView.HideSelection = false;
            this.modelsListView.Location = new System.Drawing.Point(232, 12);
            this.modelsListView.Name = "modelsListView";
            this.modelsListView.Size = new System.Drawing.Size(369, 318);
            this.modelsListView.TabIndex = 0;
            this.modelsListView.UseCompatibleStateImageBehavior = false;
            this.modelsListView.View = System.Windows.Forms.View.Details;
            // 
            // modelIdColHeader
            // 
            this.modelIdColHeader.Text = "ID";
            this.modelIdColHeader.Width = 73;
            // 
            // modelNameColHeader
            // 
            this.modelNameColHeader.Text = "Nazwa Modelu";
            this.modelNameColHeader.Width = 157;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveToFileButton,
            this.modelsFromFileButton,
            this.helpButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(481, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripSaveToFileButton
            // 
            this.toolStripSaveToFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveToFileButton.Enabled = false;
            this.toolStripSaveToFileButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveToFileButton.Image")));
            this.toolStripSaveToFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveToFileButton.Name = "toolStripSaveToFileButton";
            this.toolStripSaveToFileButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveToFileButton.ToolTipText = "zapisz modele do pliku";
            this.toolStripSaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // modelsFromFileButton
            // 
            this.modelsFromFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.modelsFromFileButton.Image = ((System.Drawing.Image)(resources.GetObject("modelsFromFileButton.Image")));
            this.modelsFromFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modelsFromFileButton.Name = "modelsFromFileButton";
            this.modelsFromFileButton.Size = new System.Drawing.Size(23, 22);
            this.modelsFromFileButton.ToolTipText = "zapisz modele z pliku do bazy";
            this.modelsFromFileButton.Click += new System.EventHandler(this.SaveToDBButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 22);
            this.helpButton.ToolTipText = "pomoc";
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ownerColumnHeader
            // 
            this.ownerColumnHeader.Text = "właściciel";
            this.ownerColumnHeader.Width = 134;
            // 
            // directoryTreeControl1
            // 
            this.directoryTreeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.directoryTreeControl1.Location = new System.Drawing.Point(12, 12);
            this.directoryTreeControl1.Name = "directoryTreeControl1";
            this.directoryTreeControl1.Size = new System.Drawing.Size(213, 318);
            this.directoryTreeControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 343);
            this.Controls.Add(this.directoryTreeControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.modelsListView);
            this.Name = "MainForm";
            this.Text = "Modeler2D podgląd modeli";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView modelsListView;
        private System.Windows.Forms.ColumnHeader modelIdColHeader;
        private System.Windows.Forms.ColumnHeader modelNameColHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSaveToFileButton;
        private System.Windows.Forms.ToolStripButton modelsFromFileButton;
        private System.Windows.Forms.ToolStripButton helpButton;
        private DirectoryTreeControl directoryTreeControl1;
        private System.Windows.Forms.ColumnHeader ownerColumnHeader;
    }
}

