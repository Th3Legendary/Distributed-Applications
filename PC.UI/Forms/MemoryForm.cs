using Newtonsoft.Json;
using PC.Models.Entities;
using PC.UI.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace PC.UI.Forms
{
    public partial class MemoryForm : Form
    {
        public int MemoryId;
        public MemoryForm()
        {
            InitializeComponent();
            PopulateTable();
        }
        public void DestroyTextInTextBox()
        {
            ManufacturerTextBox.Clear();
            ModelTextBox.Clear();
            CapacityTextBox.Clear();
            ClockSpeedTextBox.Clear();
            TimingsTextBox.Clear();
            VoltageTextBox.Clear();
            PriceUpDown.Value = 0.01m;
            ReleaseDatePicker.Value = DateTime.UtcNow;
        }
        public Memory GetMotherboardFromSpecs(bool flag)
        {
            Memory memory = null;
            try
            {
                memory = new Memory()
                {
                    Manufacturer = ManufacturerTextBox.Text,
                    Model = ModelTextBox.Text,
                    Capacity = int.Parse(CapacityTextBox.Text),
                    Clock = float.Parse(ClockSpeedTextBox.Text),
                    Timings = TimingsTextBox.Text,
                    Voltage = float.Parse(VoltageTextBox.Text),
                    Price = PriceUpDown.Value,
                    ReleaseDate = ReleaseDatePicker.Value
                };
                if (flag)
                {
                    memory.MemoryId = MemoryId;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return memory;
        }
        public void PopulateTable(string model = null)
        {
            CPUGridView.Rows.Clear();
            var response = MainForm.client.GetStringAsync("memories").Result;
            var data = JsonConvert.DeserializeObject<List<Memory>>(response);
            if (!string.IsNullOrEmpty(model))
            {
                data = data.Where(d => d.Model == model).ToList();
            }
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)CPUGridView.Rows[0].Clone();
                MemoryId = data.ElementAt(i).MemoryId;
                row.Cells[0].Value = data.ElementAt(i).Manufacturer;
                row.Cells[1].Value = data.ElementAt(i).Model;
                row.Cells[2].Value = data.ElementAt(i).Capacity;
                row.Cells[3].Value = data.ElementAt(i).Clock;
                row.Cells[4].Value = data.ElementAt(i).Timings;
                row.Cells[5].Value = data.ElementAt(i).Voltage;
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
                CapacityTextBox.Text = CPUGridView.Rows[rowId].Cells[2].Value.ToString();
                ClockSpeedTextBox.Text = CPUGridView.Rows[rowId].Cells[3].Value.ToString();
                TimingsTextBox.Text = CPUGridView.Rows[rowId].Cells[4].Value.ToString();
                VoltageTextBox.Text = CPUGridView.Rows[rowId].Cells[5].Value.ToString();
                PriceUpDown.Value = (decimal)CPUGridView.Rows[rowId].Cells[6].Value;
                ReleaseDatePicker.Value = (DateTime)CPUGridView.Rows[rowId].Cells[7].Value;
            }
            catch (Exception)
            {

            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Memory memory = GetMotherboardFromSpecs(false);

            if (memory != null && memory.Model.Length <= 200)
            {
                var chakame = MainForm.client.PostAsJsonAsync("memories", memory).Result;
            }
            PopulateTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Memory memory = GetMotherboardFromSpecs(true);

            if (memory != null && memory.Model.Length <= 200)
            {
                var chakame = MainForm.client.PutAsJsonAsync("memories/" + memory.MemoryId, memory).Result;
            }
            PopulateTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Memory memory = GetMotherboardFromSpecs(true);

            if (memory != null)
            {
                var chakame = MainForm.client.DeleteAsync("memories/" + memory.MemoryId).Result;
            }

            PopulateTable();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            PopulateTable(FindbyModelTextBox.Text.ToString());
        }
    }
}
