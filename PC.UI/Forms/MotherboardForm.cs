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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC.UI.Forms
{
    public partial class MotherboardForm : Form
    {
        public int MotherboardId;
        public MotherboardForm()
        {
            InitializeComponent();
            PopulateTable();
        }
        public void DestroyTextInTextBox()
        {
            ManufacturerTextBox.Clear();
            ModelTextBox.Clear();
            FormFactorTextBox.Clear();
            ChipsetTextBox.Clear();
            MemorySlotsTextBox.Clear();
            PCIESlotsTextBox.Clear();
            SocketTextBox.Clear();
            M2SlotsTextBox.Clear();
            PriceUpDown.Value = 0.01m;
            ReleaseDatePicker.Value = DateTime.UtcNow;
        }
        public Motherboard GetMotherboardFromSpecs(bool flag)
        {
            Motherboard motherboard = null;
            try
            {
                motherboard = new Motherboard()
                {
                    Manufacturer = ManufacturerTextBox.Text,
                    Model = ModelTextBox.Text,
                    FormFactor = FormFactorTextBox.Text,
                    Chipset = ChipsetTextBox.Text,
                    MemorySlots = int.Parse(MemorySlotsTextBox.Text),
                    PCIESlots = int.Parse(PCIESlotsTextBox.Text),
                    Socket = SocketTextBox.Text,
                    M2Slots = int.Parse(M2SlotsTextBox.Text),
                    Price = PriceUpDown.Value,
                    ReleaseDate = ReleaseDatePicker.Value
                };
                if (flag)
                {
                    motherboard.MotherboardId = MotherboardId;  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return motherboard;
        }
        public void PopulateTable(string model = null)
        {
            CPUGridView.Rows.Clear();
            var response = MainForm.client.GetStringAsync("motherboards").Result;
            var data = JsonConvert.DeserializeObject<List<Motherboard>>(response);
            if (!string.IsNullOrEmpty(model))
            {
                data = data.Where(d => d.Model == model).ToList();
            }
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)CPUGridView.Rows[0].Clone();
                MotherboardId = data.ElementAt(i).MotherboardId;
                row.Cells[0].Value = data.ElementAt(i).Manufacturer;
                row.Cells[1].Value = data.ElementAt(i).Model;
                row.Cells[2].Value = data.ElementAt(i).Socket;
                row.Cells[3].Value = data.ElementAt(i).FormFactor;
                row.Cells[4].Value = data.ElementAt(i).Chipset;
                row.Cells[5].Value = data.ElementAt(i).MemorySlots;
                row.Cells[6].Value = data.ElementAt(i).PCIESlots;     
                row.Cells[7].Value = data.ElementAt(i).M2Slots;
                row.Cells[8].Value = data.ElementAt(i).Price;
                row.Cells[9].Value = data.ElementAt(i).ReleaseDate;
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
                SocketTextBox.Text = CPUGridView.Rows[rowId].Cells[2].Value.ToString();
                FormFactorTextBox.Text = CPUGridView.Rows[rowId].Cells[3].Value.ToString();
                ChipsetTextBox.Text = CPUGridView.Rows[rowId].Cells[4].Value.ToString();
                MemorySlotsTextBox.Text = CPUGridView.Rows[rowId].Cells[5].Value.ToString();
                PCIESlotsTextBox.Text = CPUGridView.Rows[rowId].Cells[6].Value.ToString();
                M2SlotsTextBox.Text = CPUGridView.Rows[rowId].Cells[7].Value.ToString();
                PriceUpDown.Value = (decimal)CPUGridView.Rows[rowId].Cells[8].Value;
                ReleaseDatePicker.Value = (DateTime)CPUGridView.Rows[rowId].Cells[9].Value;
            }
            catch(Exception)
            {

            }
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Motherboard motherboard = GetMotherboardFromSpecs(false);

            if (motherboard != null && motherboard.Model.Length <= 200)
            {
                var chakame = MainForm.client.PostAsJsonAsync("motherboards", motherboard).Result;
            }
            PopulateTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Motherboard motherboard = GetMotherboardFromSpecs(true);

            if (motherboard != null && motherboard.Model.Length <= 200)
            {
                var chakame = MainForm.client.PutAsJsonAsync("motherboards/" + motherboard.MotherboardId, motherboard).Result;
            }
            PopulateTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Motherboard motherboard = GetMotherboardFromSpecs(true);

            if (motherboard != null)
            {
                var chakame = MainForm.client.DeleteAsync("motherboards/" + motherboard.MotherboardId).Result;
            }

            PopulateTable();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            PopulateTable(FindbyModelTextBox.Text.ToString());
        }
    }
}
