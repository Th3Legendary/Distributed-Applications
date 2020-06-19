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
    public partial class GPUForm : Form
    {
        public int GPUId;
        public GPUForm()
        {
            InitializeComponent();
            PopulateTable();
        }
        public void DestroyTextInTextBox()
        {
            ManufacturerTextBox.Clear();
            ModelTextBox.Clear();
            MemoryCapacityTextBox.Clear();
            MemoryType.Clear();
            MemoryClockTextBox.Clear();
            BaseClockTextBox.Clear();
            BoostClockTextBox.Clear();
            TDPTextBox.Clear();
            ChipsetTextBox.Clear();
            PriceUpDown.Value = 0.01m;
            ReleaseDatePicker.Value = DateTime.UtcNow;
        }
        public GPU GetMotherboardFromSpecs(bool flag)
        {
            GPU gpu = null;
            try
            {
                gpu = new GPU()
                {
                    Manufacturer = ManufacturerTextBox.Text,
                    Model = ModelTextBox.Text,
                    MemoryCapacity = int.Parse(MemoryCapacityTextBox.Text),
                    MemoryType = MemoryType.Text,
                    MemoryClock = int.Parse(MemoryClockTextBox.Text),
                    BaseClock = float.Parse(BaseClockTextBox.Text),
                    BoostClock = float.Parse(BoostClockTextBox.Text),
                    TDP = int.Parse(TDPTextBox.Text),
                    Chipset = ChipsetTextBox.Text,
                    Price = PriceUpDown.Value,
                    ReleaseDate = ReleaseDatePicker.Value
                };
                if (flag)
                {
                    gpu.GPUId = GPUId;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return gpu;
        }
        public void PopulateTable(string model = null)
        {
            CPUGridView.Rows.Clear();
            var response = MainForm.client.GetStringAsync("gpus").Result;
            var data = JsonConvert.DeserializeObject<List<GPU>>(response);
            if (!string.IsNullOrEmpty(model))
            {
                data = data.Where(d => d.Model == model).ToList();
            }
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)CPUGridView.Rows[0].Clone();
                GPUId = data.ElementAt(i).GPUId;
                row.Cells[0].Value = data.ElementAt(i).Manufacturer;
                row.Cells[1].Value = data.ElementAt(i).Model;
                row.Cells[2].Value = data.ElementAt(i).MemoryCapacity;
                row.Cells[3].Value = data.ElementAt(i).MemoryType;
                row.Cells[4].Value = data.ElementAt(i).MemoryClock;
                row.Cells[5].Value = data.ElementAt(i).BaseClock;
                row.Cells[6].Value = data.ElementAt(i).BoostClock;
                row.Cells[7].Value = data.ElementAt(i).TDP;
                row.Cells[8].Value = data.ElementAt(i).Chipset;
                row.Cells[9].Value = data.ElementAt(i).Price;
                row.Cells[10].Value = data.ElementAt(i).ReleaseDate;
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
                BoostClockTextBox.Text = CPUGridView.Rows[rowId].Cells[2].Value.ToString();
                MemoryCapacityTextBox.Text = CPUGridView.Rows[rowId].Cells[3].Value.ToString();
                MemoryType.Text = CPUGridView.Rows[rowId].Cells[4].Value.ToString();
                MemoryClockTextBox.Text = CPUGridView.Rows[rowId].Cells[5].Value.ToString();
                BaseClockTextBox.Text = CPUGridView.Rows[rowId].Cells[6].Value.ToString();
                TDPTextBox.Text = CPUGridView.Rows[rowId].Cells[7].Value.ToString();
                ChipsetTextBox.Text = CPUGridView.Rows[rowId].Cells[8].Value.ToString();
                PriceUpDown.Value = (decimal)CPUGridView.Rows[rowId].Cells[9].Value;
                ReleaseDatePicker.Value = (DateTime)CPUGridView.Rows[rowId].Cells[10].Value;
            }
            catch (Exception)
            {

            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            GPU gpu = GetMotherboardFromSpecs(false);

            if (gpu != null && gpu.Model.Length <= 200)
            {
                var chakame = MainForm.client.PostAsJsonAsync("gpus", gpu).Result;
            }
            PopulateTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            GPU gpu = GetMotherboardFromSpecs(true);

            if (gpu != null && gpu.Model.Length <= 200)
            {
                var chakame = MainForm.client.PutAsJsonAsync("gpus/" + gpu.GPUId, gpu).Result;
            }
            PopulateTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            GPU gpu = GetMotherboardFromSpecs(true);

            if (gpu != null)
            {
                var chakame = MainForm.client.DeleteAsync("gpus/" + gpu.GPUId).Result;
            }

            PopulateTable();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            PopulateTable(FindbyModelTextBox.Text.ToString());
        }
    }
}
