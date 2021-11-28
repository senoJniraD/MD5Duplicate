
namespace MD5Duplicate
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fButton = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.TextBox();
            this.mfgBox = new System.Windows.Forms.TextBox();
            this.cButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.zipGrid = new System.Windows.Forms.DataGridView();
            this.SQLGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resGrid = new System.Windows.Forms.DataGridView();
            this.zCount = new System.Windows.Forms.Label();
            this.cCount = new System.Windows.Forms.Label();
            this.rCount = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sLabel = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zipGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SQLGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // fButton
            // 
            this.fButton.Location = new System.Drawing.Point(112, 60);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(75, 23);
            this.fButton.TabIndex = 0;
            this.fButton.Text = "Get Files";
            this.fButton.UseVisualStyleBackColor = true;
            this.fButton.Click += new System.EventHandler(this.go_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(6, 16);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(401, 23);
            this.pBox.TabIndex = 4;
            // 
            // mfgBox
            // 
            this.mfgBox.Location = new System.Drawing.Point(6, 60);
            this.mfgBox.Name = "mfgBox";
            this.mfgBox.Size = new System.Drawing.Size(100, 23);
            this.mfgBox.TabIndex = 5;
            // 
            // cButton
            // 
            this.cButton.Location = new System.Drawing.Point(413, 16);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(66, 23);
            this.cButton.TabIndex = 6;
            this.cButton.Text = "File";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // zipGrid
            // 
            this.zipGrid.AllowUserToAddRows = false;
            this.zipGrid.AllowUserToDeleteRows = false;
            this.zipGrid.AllowUserToResizeColumns = false;
            this.zipGrid.AllowUserToResizeRows = false;
            this.zipGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zipGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zipGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.zipGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.zipGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.zipGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zipGrid.ColumnHeadersVisible = false;
            this.zipGrid.EnableHeadersVisualStyles = false;
            this.zipGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zipGrid.Location = new System.Drawing.Point(12, 117);
            this.zipGrid.Name = "zipGrid";
            this.zipGrid.ReadOnly = true;
            this.zipGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.zipGrid.RowHeadersVisible = false;
            this.zipGrid.RowHeadersWidth = 60;
            this.zipGrid.RowTemplate.Height = 25;
            this.zipGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zipGrid.ShowEditingIcon = false;
            this.zipGrid.Size = new System.Drawing.Size(556, 126);
            this.zipGrid.TabIndex = 8;
            // 
            // SQLGrid
            // 
            this.SQLGrid.AllowUserToAddRows = false;
            this.SQLGrid.AllowUserToDeleteRows = false;
            this.SQLGrid.AllowUserToResizeColumns = false;
            this.SQLGrid.AllowUserToResizeRows = false;
            this.SQLGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SQLGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SQLGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SQLGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.SQLGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SQLGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLGrid.ColumnHeadersVisible = false;
            this.SQLGrid.EnableHeadersVisualStyles = false;
            this.SQLGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SQLGrid.Location = new System.Drawing.Point(12, 262);
            this.SQLGrid.Name = "SQLGrid";
            this.SQLGrid.ReadOnly = true;
            this.SQLGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SQLGrid.RowHeadersVisible = false;
            this.SQLGrid.RowHeadersWidth = 60;
            this.SQLGrid.RowTemplate.Height = 25;
            this.SQLGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SQLGrid.ShowEditingIcon = false;
            this.SQLGrid.Size = new System.Drawing.Size(556, 150);
            this.SQLGrid.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pBox);
            this.groupBox1.Controls.Add(this.fButton);
            this.groupBox1.Controls.Add(this.mfgBox);
            this.groupBox1.Controls.Add(this.cButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path To File:";
            // 
            // flder
            // 
            this.flder.Location = new System.Drawing.Point(484, 16);
            this.flder.Name = "flder";
            this.flder.Size = new System.Drawing.Size(66, 23);
            this.flder.TabIndex = 8;
            this.flder.Text = "Folder";
            this.flder.UseVisualStyleBackColor = true;
            this.flder.Click += new System.EventHandler(this.flder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "MFG Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Folder Contents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stored Checksums";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "New Files";
            // 
            // resGrid
            // 
            this.resGrid.AllowUserToAddRows = false;
            this.resGrid.AllowUserToDeleteRows = false;
            this.resGrid.AllowUserToResizeColumns = false;
            this.resGrid.AllowUserToResizeRows = false;
            this.resGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.resGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resGrid.ColumnHeadersVisible = false;
            this.resGrid.EnableHeadersVisualStyles = false;
            this.resGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resGrid.Location = new System.Drawing.Point(12, 432);
            this.resGrid.Name = "resGrid";
            this.resGrid.ReadOnly = true;
            this.resGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resGrid.RowHeadersVisible = false;
            this.resGrid.RowHeadersWidth = 60;
            this.resGrid.RowTemplate.Height = 25;
            this.resGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resGrid.ShowEditingIcon = false;
            this.resGrid.Size = new System.Drawing.Size(556, 150);
            this.resGrid.TabIndex = 13;
            // 
            // zCount
            // 
            this.zCount.AutoSize = true;
            this.zCount.Location = new System.Drawing.Point(477, 99);
            this.zCount.Name = "zCount";
            this.zCount.Size = new System.Drawing.Size(0, 15);
            this.zCount.TabIndex = 15;
            // 
            // cCount
            // 
            this.cCount.AutoSize = true;
            this.cCount.Location = new System.Drawing.Point(477, 245);
            this.cCount.Name = "cCount";
            this.cCount.Size = new System.Drawing.Size(0, 15);
            this.cCount.TabIndex = 16;
            // 
            // rCount
            // 
            this.rCount.AutoSize = true;
            this.rCount.Location = new System.Drawing.Point(477, 415);
            this.rCount.Name = "rCount";
            this.rCount.Size = new System.Drawing.Size(0, 15);
            this.rCount.TabIndex = 17;
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(12, 587);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(0, 15);
            this.sLabel.TabIndex = 20;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(305, 587);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 15);
            this.status.TabIndex = 21;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 610);
            this.Controls.Add(this.status);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.rCount);
            this.Controls.Add(this.cCount);
            this.Controls.Add(this.zCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SQLGrid);
            this.Controls.Add(this.zipGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formMain";
            this.Text = "MD5 Hash Check";
            ((System.ComponentModel.ISupportInitialize)(this.zipGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SQLGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.TextBox pBox;
        private System.Windows.Forms.TextBox mfgBox;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView zipGrid;
        private System.Windows.Forms.DataGridView SQLGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView resGrid;
        private System.Windows.Forms.Label zCount;
        private System.Windows.Forms.Label cCount;
        private System.Windows.Forms.Label rCount;
        private System.Windows.Forms.Button flder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label status;
    }
}

