using Newtonsoft.Json;
using PC.Models.Entities;
using PC.UI.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC.UI.Forms
{
    public partial class PSUForm : Form
    { 
        public int PSUId;
        public PSUForm()
        {
            InitializeComponent();
            PopulateTable();
        }
        public void DestroyTextInTextBox()
        {
            ManufacturerTextBox.Clear();
            ModelTextBox.Clear();
            FormFactorTextBox.Clear();
            EfficiencyTextBox.Clear();
            WattageTextBox.Clear();
            ModularTextBox.Clear();
            PriceUpDown.Value = 0.01m;
            ReleaseDatePicker.Value = DateTime.UtcNow;
        }
        public PSU GetPSUFromSpecs(bool flag)
        {
            PSU psu = null;
            try
            {
                psu = new PSU()
                {
                    Manufacturer = ManufacturerTextBox.Text,
                    Model = ModelTextBox.Text,
                    FormFactor = FormFactorTextBox.Text,
                    Efficiency = EfficiencyTextBox.Text,
                    Wattage = int.Parse(WattageTextBox.Text),
                    Modular = ModularTextBox.Text,
                    Price = PriceUpDown.Value,
                    ReleaseDate = ReleaseDatePicker.Value
                };
                if (flag)
                {
                    psu.PSUId = PSUId;  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return psu;
        }
        public void PopulateTable(string model = null)
        {
            CPUGridView.Rows.Clear();
            var response = MainForm.client.GetStringAsync("psus").Result;
            var data = JsonConvert.DeserializeObject<List<PSU>>(response);
            if (!string.IsNullOrEmpty(model))
            {
                data = data.Where(d => d.Model == model).ToList();
            }
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)CPUGridView.Rows[0].Clone();
                PSUId = data.ElementAt(i).PSUId;
                row.Cells[0].Value = data.ElementAt(i).Manufacturer;
                row.Cells[1].Value = data.ElementAt(i).Model;
                row.Cells[2].Value = data.ElementAt(i).FormFactor;
                row.Cells[3].Value = data.ElementAt(i).Efficiency;
                row.Cells[4].Value = data.ElementAt(i).Wattage;
                row.Cells[5].Value = data.ElementAt(i).Modular;     
                row.Cells[6].Value = data.ElementAt(i).Price;
                row.Cells[7].Value = data.ElementAt(i).ReleaseDate;
                CPUGridView.Rows.Add(row);
            }
        }

        private void CPUGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = CPUGridView.CurrentCell.RowIndex;
            if (rowId == CPUGridView.Rows.Count - 1)
            {
                DestroyTextInTextBox();
                return;
            }
            try
            {
                ManufacturerTextBox.Text = CPUGridView.Rows[rowId].Cells[0].Value.ToString();
                ModelTextBox.Text = CPUGridView.Rows[rowId].Cells[1].Value.ToString();       
                FormFactorTextBox.Text = CPUGridView.Rows[rowId].Cells[2].Value.ToString();
                EfficiencyTextBox.Text = CPUGridView.Rows[rowId].Cells[3].Value.ToString();
                WattageTextBox.Text = CPUGridView.Rows[rowId].Cells[4].Value.ToString();
                ModularTextBox.Text = CPUGridView.Rows[rowId].Cells[5].Value.ToString();
                PriceUpDown.Value = (decimal)CPUGridView.Rows[rowId].Cells[6].Value;
                ReleaseDatePicker.Value = (DateTime)CPUGridView.Rows[rowId].Cells[7].Value;
            }
            catch(Exception)
            {

            }
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PSU psu = GetPSUFromSpecs(false);

            if (psu != null && psu.Model.Length <= 200)
            {
                var chakame = MainForm.client.PostAsJsonAsync("psus", psu).Result;
            }
            PopulateTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            PSU psu = GetPSUFromSpecs(true);

            if (psu != null && psu.Model.Length <= 200)
            {
                var chakame = MainForm.client.PutAsJsonAsync("psus/" + psu.PSUId, psu).Result;
            }
            PopulateTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            PSU psu = GetPSUFromSpecs(true);

            if (psu != null)
            {
                var chakame = MainForm.client.DeleteAsync("psus/" + psu.PSUId).Result;
            }

            PopulateTable();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            PopulateTable(FindbyModelTextBox.Text.ToString());
        }
    }
}
