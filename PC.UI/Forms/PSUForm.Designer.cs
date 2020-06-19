namespace PC.UI.Forms
{
    partial class PSUForm
    {/// <summary>
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
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.FindbyModelTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.FormFactorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EfficiencyTextBox = new System.Windows.Forms.TextBox();
            this.ModularTextBox = new System.Windows.Forms.TextBox();
            this.WattageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FindbyModelLabel = new System.Windows.Forms.Label();
            this.PriceUpDown = new System.Windows.Forms.NumericUpDown();
            this.ReleaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formfactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efficiency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wattage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Releasedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CPUGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CPUGridView
            // 
            this.CPUGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CPUGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manufacturer,
            this.Model,
            this.Formfactor,
            this.Efficiency,
            this.Wattage,
            this.Modular,
            this.Price,
            this.Releasedate});
            this.CPUGridView.Location = new System.Drawing.Point(12, 183);
            this.CPUGridView.Name = "CPUGridView";
            this.CPUGridView.Size = new System.Drawing.Size(504, 255);
            this.CPUGridView.TabIndex = 0;
            this.CPUGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CPUGridView_CellClick);
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(12, 26);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(126, 20);
            this.ManufacturerTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(420, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(96, 24);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(420, 42);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(96, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(420, 71);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(96, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(420, 154);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(96, 23);
            this.Find.TabIndex = 5;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // FindbyModelTextBox
            // 
            this.FindbyModelTextBox.Location = new System.Drawing.Point(420, 128);
            this.FindbyModelTextBox.Name = "FindbyModelTextBox";
            this.FindbyModelTextBox.Size = new System.Drawing.Size(96, 20);
            this.FindbyModelTextBox.TabIndex = 6;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(9, 7);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(73, 13);
            this.ManufacturerLabel.TabIndex = 7;
            this.ManufacturerLabel.Text = "Manufacturer:";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(12, 71);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(126, 20);
            this.ModelTextBox.TabIndex = 8;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(9, 52);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(39, 13);
            this.ModelLabel.TabIndex = 9;
            this.ModelLabel.Text = "Model:";
            // 
            // FormFactorTextBox
            // 
            this.FormFactorTextBox.Location = new System.Drawing.Point(12, 110);
            this.FormFactorTextBox.Name = "FormFactorTextBox";
            this.FormFactorTextBox.Size = new System.Drawing.Size(126, 20);
            this.FormFactorTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Form Factor: ";
            // 
            // EfficiencyTextBox
            // 
            this.EfficiencyTextBox.Location = new System.Drawing.Point(158, 26);
            this.EfficiencyTextBox.Name = "EfficiencyTextBox";
            this.EfficiencyTextBox.Size = new System.Drawing.Size(121, 20);
            this.EfficiencyTextBox.TabIndex = 14;
            // 
            // ModularTextBox
            // 
            this.ModularTextBox.Location = new System.Drawing.Point(158, 110);
            this.ModularTextBox.Name = "ModularTextBox";
            this.ModularTextBox.Size = new System.Drawing.Size(121, 20);
            this.ModularTextBox.TabIndex = 15;
            // 
            // WattageTextBox
            // 
            this.WattageTextBox.Location = new System.Drawing.Point(158, 71);
            this.WattageTextBox.Name = "WattageTextBox";
            this.WattageTextBox.Size = new System.Drawing.Size(121, 20);
            this.WattageTextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Efficiency: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Wattage: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Modular: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Price: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Release Date:";
            // 
            // FindbyModelLabel
            // 
            this.FindbyModelLabel.AutoSize = true;
            this.FindbyModelLabel.Location = new System.Drawing.Point(417, 110);
            this.FindbyModelLabel.Name = "FindbyModelLabel";
            this.FindbyModelLabel.Size = new System.Drawing.Size(76, 13);
            this.FindbyModelLabel.TabIndex = 32;
            this.FindbyModelLabel.Text = "Find by Model:";
            // 
            // PriceUpDown
            // 
            this.PriceUpDown.DecimalPlaces = 2;
            this.PriceUpDown.Location = new System.Drawing.Point(12, 150);
            this.PriceUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PriceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PriceUpDown.Name = "PriceUpDown";
            this.PriceUpDown.Size = new System.Drawing.Size(126, 20);
            this.PriceUpDown.TabIndex = 33;
            this.PriceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // ReleaseDatePicker
            // 
            this.ReleaseDatePicker.Location = new System.Drawing.Point(158, 149);
            this.ReleaseDatePicker.Name = "ReleaseDatePicker";
            this.ReleaseDatePicker.Size = new System.Drawing.Size(121, 20);
            this.ReleaseDatePicker.TabIndex = 34;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Formfactor
            // 
            this.Formfactor.HeaderText = "Form Factor";
            this.Formfactor.Name = "Formfactor";
            // 
            // Efficiency
            // 
            this.Efficiency.HeaderText = "Efficiency";
            this.Efficiency.Name = "Efficiency";
            // 
            // Wattage
            // 
            this.Wattage.HeaderText = "Wattage";
            this.Wattage.Name = "Wattage";
            // 
            // Modular
            // 
            this.Modular.HeaderText = "Modular";
            this.Modular.Name = "Modular";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Releasedate
            // 
            this.Releasedate.HeaderText = "Release Date";
            this.Releasedate.Name = "Releasedate";
            // 
            // PSUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.ReleaseDatePicker);
            this.Controls.Add(this.PriceUpDown);
            this.Controls.Add(this.FindbyModelLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WattageTextBox);
            this.Controls.Add(this.ModularTextBox);
            this.Controls.Add(this.EfficiencyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormFactorTextBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.FindbyModelTextBox);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ManufacturerTextBox);
            this.Controls.Add(this.CPUGridView);
            this.Name = "PSUForm";
            this.Text = "CPUForm";
            ((System.ComponentModel.ISupportInitialize)(this.CPUGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CPUGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox FindbyModelTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox FormFactorTextBox;
        private System.Windows.Forms.TextBox EfficiencyTextBox;
        private System.Windows.Forms.TextBox ModularTextBox;
        private System.Windows.Forms.TextBox WattageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label FindbyModelLabel;
        private System.Windows.Forms.NumericUpDown PriceUpDown;
        private System.Windows.Forms.DateTimePicker ReleaseDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formfactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efficiency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wattage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Releasedate;
    }
}