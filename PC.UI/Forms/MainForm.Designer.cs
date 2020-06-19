namespace PC.UI.UI
{
    partial class MainForm
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
            this.BuildListsButton = new System.Windows.Forms.Button();
            this.CPUButton = new System.Windows.Forms.Button();
            this.MotherboardButton = new System.Windows.Forms.Button();
            this.MemoryButton = new System.Windows.Forms.Button();
            this.StorageButton = new System.Windows.Forms.Button();
            this.GPUButton = new System.Windows.Forms.Button();
            this.PSUButton = new System.Windows.Forms.Button();
            this.CaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuildListsButton
            // 
            this.BuildListsButton.Location = new System.Drawing.Point(12, 12);
            this.BuildListsButton.Name = "BuildListsButton";
            this.BuildListsButton.Size = new System.Drawing.Size(278, 48);
            this.BuildListsButton.TabIndex = 0;
            this.BuildListsButton.Text = "Build Lists";
            this.BuildListsButton.UseVisualStyleBackColor = true;
            this.BuildListsButton.Click += new System.EventHandler(this.BuildListButton_Click);
            // 
            // CPUButton
            // 
            this.CPUButton.Location = new System.Drawing.Point(12, 66);
            this.CPUButton.Name = "CPUButton";
            this.CPUButton.Size = new System.Drawing.Size(278, 47);
            this.CPUButton.TabIndex = 0;
            this.CPUButton.Text = "CPU";
            this.CPUButton.UseVisualStyleBackColor = true;
            this.CPUButton.Click += new System.EventHandler(this.CPUButton_Click);
            // 
            // MotherboardButton
            // 
            this.MotherboardButton.Location = new System.Drawing.Point(12, 119);
            this.MotherboardButton.Name = "MotherboardButton";
            this.MotherboardButton.Size = new System.Drawing.Size(278, 48);
            this.MotherboardButton.TabIndex = 0;
            this.MotherboardButton.Text = "Motherboard";
            this.MotherboardButton.UseVisualStyleBackColor = true;
            this.MotherboardButton.Click += new System.EventHandler(this.MotherboardButton_Click);
            // 
            // MemoryButton
            // 
            this.MemoryButton.Location = new System.Drawing.Point(12, 173);
            this.MemoryButton.Name = "MemoryButton";
            this.MemoryButton.Size = new System.Drawing.Size(278, 48);
            this.MemoryButton.TabIndex = 0;
            this.MemoryButton.Text = "Memory";
            this.MemoryButton.UseVisualStyleBackColor = true;
            this.MemoryButton.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // StorageButton
            // 
            this.StorageButton.Location = new System.Drawing.Point(12, 227);
            this.StorageButton.Name = "StorageButton";
            this.StorageButton.Size = new System.Drawing.Size(278, 48);
            this.StorageButton.TabIndex = 0;
            this.StorageButton.Text = "Storage";
            this.StorageButton.UseVisualStyleBackColor = true;
            this.StorageButton.Click += new System.EventHandler(this.StorageButton_Click);
            // 
            // GPUButton
            // 
            this.GPUButton.Location = new System.Drawing.Point(12, 281);
            this.GPUButton.Name = "GPUButton";
            this.GPUButton.Size = new System.Drawing.Size(278, 48);
            this.GPUButton.TabIndex = 0;
            this.GPUButton.Text = "GPU";
            this.GPUButton.UseVisualStyleBackColor = true;
            this.GPUButton.Click += new System.EventHandler(this.GPUButton_Click);
            // 
            // PSUButton
            // 
            this.PSUButton.Location = new System.Drawing.Point(12, 335);
            this.PSUButton.Name = "PSUButton";
            this.PSUButton.Size = new System.Drawing.Size(278, 48);
            this.PSUButton.TabIndex = 0;
            this.PSUButton.Text = "PSU";
            this.PSUButton.UseVisualStyleBackColor = true;
            this.PSUButton.Click += new System.EventHandler(this.PSUButton_Click);
            // 
            // CaseButton
            // 
            this.CaseButton.Location = new System.Drawing.Point(12, 389);
            this.CaseButton.Name = "CaseButton";
            this.CaseButton.Size = new System.Drawing.Size(278, 48);
            this.CaseButton.TabIndex = 0;
            this.CaseButton.Text = "Case";
            this.CaseButton.UseVisualStyleBackColor = true;
            this.CaseButton.Click += new System.EventHandler(this.CaseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 444);
            this.Controls.Add(this.CaseButton);
            this.Controls.Add(this.PSUButton);
            this.Controls.Add(this.GPUButton);
            this.Controls.Add(this.StorageButton);
            this.Controls.Add(this.MemoryButton);
            this.Controls.Add(this.MotherboardButton);
            this.Controls.Add(this.CPUButton);
            this.Controls.Add(this.BuildListsButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BuildListsButton;
        private System.Windows.Forms.Button CPUButton;
        private System.Windows.Forms.Button MotherboardButton;
        private System.Windows.Forms.Button MemoryButton;
        private System.Windows.Forms.Button StorageButton;
        private System.Windows.Forms.Button GPUButton;
        private System.Windows.Forms.Button PSUButton;
        private System.Windows.Forms.Button CaseButton;
    }
}