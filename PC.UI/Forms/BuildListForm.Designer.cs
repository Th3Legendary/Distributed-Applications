namespace PC.UI.Forms
{
    partial class BuildListForm
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
            this.CPUGridView = new System.Windows.Forms.DataGridView();
            this.ListName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motherboard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Storage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Case = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.FindbyNameTextBox = new System.Windows.Forms.TextBox();
            this.FindbyNameLabel = new System.Windows.Forms.Label();
            this.CPUComboBox = new System.Windows.Forms.ComboBox();
            this.CaseComboBox = new System.Windows.Forms.ComboBox();
            this.PSUComboBox = new System.Windows.Forms.ComboBox();
            this.GPUComboBox = new System.Windows.Forms.ComboBox();
            this.StorageComboBox = new System.Windows.Forms.ComboBox();
            this.MemoryComboBox = new System.Windows.Forms.ComboBox();
            this.MotherboardComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CPUGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CPUGridView
            // 
            this.CPUGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CPUGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListName,
            this.Cpu,
            this.Motherboard,
            this.Memory,
            this.Storage,
            this.Gpu,
            this.psu,
            this.Case});
            this.CPUGridView.Location = new System.Drawing.Point(9, 158);
            this.CPUGridView.Name = "CPUGridView";
            this.CPUGridView.Size = new System.Drawing.Size(504, 255);
            this.CPUGridView.TabIndex = 0;
            this.CPUGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CPUGridView_CellClick);
            // 
            // ListName
            // 
            this.ListName.HeaderText = "Name";
            this.ListName.Name = "ListName";
            // 
            // Cpu
            // 
            this.Cpu.HeaderText = "CPU";
            this.Cpu.Name = "Cpu";
            // 
            // Motherboard
            // 
            this.Motherboard.HeaderText = "Motherboard";
            this.Motherboard.Name = "Motherboard";
            // 
            // Memory
            // 
            this.Memory.HeaderText = "Memory";
            this.Memory.Name = "Memory";
            // 
            // Storage
            // 
            this.Storage.HeaderText = "Storage";
            this.Storage.Name = "Storage";
            // 
            // Gpu
            // 
            this.Gpu.HeaderText = "GPU";
            this.Gpu.Name = "Gpu";
            // 
            // psu
            // 
            this.psu.HeaderText = "PSU";
            this.psu.Name = "psu";
            // 
            // Case
            // 
            this.Case.HeaderText = "Case";
            this.Case.Name = "Case";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(420, 18);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(96, 24);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(420, 48);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(96, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(420, 77);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(96, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(420, 129);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(96, 23);
            this.Find.TabIndex = 5;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // FindbyNameTextBox
            // 
            this.FindbyNameTextBox.Location = new System.Drawing.Point(284, 129);
            this.FindbyNameTextBox.Name = "FindbyNameTextBox";
            this.FindbyNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.FindbyNameTextBox.TabIndex = 6;
            // 
            // FindbyNameLabel
            // 
            this.FindbyNameLabel.AutoSize = true;
            this.FindbyNameLabel.Location = new System.Drawing.Point(281, 111);
            this.FindbyNameLabel.Name = "FindbyNameLabel";
            this.FindbyNameLabel.Size = new System.Drawing.Size(75, 13);
            this.FindbyNameLabel.TabIndex = 32;
            this.FindbyNameLabel.Text = "Find by Name:";
            // 
            // CPUComboBox
            // 
            this.CPUComboBox.FormattingEnabled = true;
            this.CPUComboBox.Location = new System.Drawing.Point(9, 35);
            this.CPUComboBox.Name = "CPUComboBox";
            this.CPUComboBox.Size = new System.Drawing.Size(121, 21);
            this.CPUComboBox.TabIndex = 33;
            // 
            // CaseComboBox
            // 
            this.CaseComboBox.FormattingEnabled = true;
            this.CaseComboBox.Location = new System.Drawing.Point(9, 128);
            this.CaseComboBox.Name = "CaseComboBox";
            this.CaseComboBox.Size = new System.Drawing.Size(121, 21);
            this.CaseComboBox.TabIndex = 34;
            // 
            // PSUComboBox
            // 
            this.PSUComboBox.FormattingEnabled = true;
            this.PSUComboBox.Location = new System.Drawing.Point(284, 82);
            this.PSUComboBox.Name = "PSUComboBox";
            this.PSUComboBox.Size = new System.Drawing.Size(121, 21);
            this.PSUComboBox.TabIndex = 35;
            // 
            // GPUComboBox
            // 
            this.GPUComboBox.FormattingEnabled = true;
            this.GPUComboBox.Location = new System.Drawing.Point(148, 82);
            this.GPUComboBox.Name = "GPUComboBox";
            this.GPUComboBox.Size = new System.Drawing.Size(121, 21);
            this.GPUComboBox.TabIndex = 36;
            // 
            // StorageComboBox
            // 
            this.StorageComboBox.FormattingEnabled = true;
            this.StorageComboBox.Location = new System.Drawing.Point(9, 82);
            this.StorageComboBox.Name = "StorageComboBox";
            this.StorageComboBox.Size = new System.Drawing.Size(121, 21);
            this.StorageComboBox.TabIndex = 37;
            // 
            // MemoryComboBox
            // 
            this.MemoryComboBox.FormattingEnabled = true;
            this.MemoryComboBox.Location = new System.Drawing.Point(284, 35);
            this.MemoryComboBox.Name = "MemoryComboBox";
            this.MemoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.MemoryComboBox.TabIndex = 38;
            // 
            // MotherboardComboBox
            // 
            this.MotherboardComboBox.FormattingEnabled = true;
            this.MotherboardComboBox.Location = new System.Drawing.Point(148, 35);
            this.MotherboardComboBox.Name = "MotherboardComboBox";
            this.MotherboardComboBox.Size = new System.Drawing.Size(121, 21);
            this.MotherboardComboBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Motherboard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Memory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Storage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "GPU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "PSU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Case";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(148, 128);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(121, 20);
            this.NameTextbox.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Name:";
            // 
            // BuildListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 419);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MotherboardComboBox);
            this.Controls.Add(this.MemoryComboBox);
            this.Controls.Add(this.StorageComboBox);
            this.Controls.Add(this.GPUComboBox);
            this.Controls.Add(this.PSUComboBox);
            this.Controls.Add(this.CaseComboBox);
            this.Controls.Add(this.CPUComboBox);
            this.Controls.Add(this.FindbyNameLabel);
            this.Controls.Add(this.FindbyNameTextBox);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CPUGridView);
            this.Name = "BuildListForm";
            this.Text = "CPUForm";
            ((System.ComponentModel.ISupportInitialize)(this.CPUGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CPUGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.TextBox FindbyNameTextBox;
        private System.Windows.Forms.Label FindbyNameLabel;
        private System.Windows.Forms.ComboBox CPUComboBox;
        private System.Windows.Forms.ComboBox CaseComboBox;
        private System.Windows.Forms.ComboBox PSUComboBox;
        private System.Windows.Forms.ComboBox GPUComboBox;
        private System.Windows.Forms.ComboBox StorageComboBox;
        private System.Windows.Forms.ComboBox MemoryComboBox;
        private System.Windows.Forms.ComboBox MotherboardComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motherboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Storage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn psu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case;
    }
}