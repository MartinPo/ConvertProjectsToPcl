namespace MLabs.ConvertToPcl
{
    partial class ProjectsUpdateList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectsUpdateList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Framework = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFrameworksinUse = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.reloadButton = new System.Windows.Forms.Button();
            this.cmbPortables = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.ProjectName,
            this.Framework});
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // Update
            // 
            this.Update.DataPropertyName = "IsSelected";
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectName.DataPropertyName = "Name";
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // Framework
            // 
            this.Framework.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Framework.DataPropertyName = "NetFrameworkInUse";
            this.Framework.HeaderText = "Current Framework";
            this.Framework.Name = "Framework";
            this.Framework.ReadOnly = true;
            // 
            // cmbFrameworksinUse
            // 
            this.cmbFrameworksinUse.FormattingEnabled = true;
            this.cmbFrameworksinUse.Location = new System.Drawing.Point(623, 10);
            this.cmbFrameworksinUse.Name = "cmbFrameworksinUse";
            this.cmbFrameworksinUse.Size = new System.Drawing.Size(21, 21);
            this.cmbFrameworksinUse.TabIndex = 1;
            this.cmbFrameworksinUse.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Select None";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Convert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(452, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(165, 47);
            this.lblInfo.TabIndex = 5;
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(623, 37);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(39, 23);
            this.reloadButton.TabIndex = 6;
            this.reloadButton.Text = "Reload Projects List";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Visible = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // cmbPortables
            // 
            this.cmbPortables.FormattingEnabled = true;
            this.cmbPortables.Location = new System.Drawing.Point(12, 10);
            this.cmbPortables.Name = "cmbPortables";
            this.cmbPortables.Size = new System.Drawing.Size(422, 21);
            this.cmbPortables.TabIndex = 7;
            // 
            // ProjectsUpdateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 366);
            this.Controls.Add(this.cmbPortables);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFrameworksinUse);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectsUpdateList";
            this.Text = "Convert to Portable Class Library";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbFrameworksinUse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Framework;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.ComboBox cmbPortables;
    }
}