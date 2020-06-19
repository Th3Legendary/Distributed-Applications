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
    public partial class StorageForm : Form
    {
        public int StorageId;
        public StorageForm()
        {
            InitializeComponent();
            PopulateTable();
        }
        public void DestroyTextInTextBox()
        {
            ManufacturerTextBox.Clear();
            ModelTextBox.Clear();
            CapacityTextBox.Clear();
            TypeTextBox.Clear();
            InterfaceTextBox.Clear();
            PriceUpDown.Value = 0.01m;
            ReleaseDatePicker.Value = DateTime.UtcNow;
        }
        public Storage GetStorageFromSpecs(bool flag)
        {
            Storage storage = null;
            try
            {
                storage = new Storage()
                {
                    Manufacturer = ManufacturerTextBox.Text,
                    Model = ModelTextBox.Text,
                    Capacity = int.Parse(CapacityTextBox.Text),
                    Type = TypeTextBox.Text,
                    Interface = InterfaceTextBox.Text,
                    Price = PriceUpDown.Value,
                    ReleaseDate = ReleaseDatePicker.Value
                };
                if (flag)
                {
                    storage.StorageId = StorageId;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return storage;
        }
        public void PopulateTable(string model = null)
        {
            CPUGridView.Rows.Clear();
            var response = MainForm.client.GetStringAsync("storages").Result;
            var data = JsonConvert.DeserializeObject<List<Storage>>(response);
            if (!string.IsNullOrEmpty(model))
            {
                data = data.Where(d => d.Model == model).ToList();
            }
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)CPUGridView.Rows[0].Clone();
                StorageId = data.ElementAt(i).StorageId;
                row.Cells[0].Value = data.ElementAt(i).Manufacturer;
                row.Cells[1].Value = data.ElementAt(i).Model;
                row.Cells[2].Value = data.ElementAt(i).Capacity;
                row.Cells[3].Value = data.ElementAt(i).Type;
                row.Cells[4].Value = data.ElementAt(i).Interface;
                row.Cells[5].Value = data.ElementAt(i).Price;
                row.Cells[6].Value = data.ElementAt(i).ReleaseDate;
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
                TypeTextBox.Text = CPUGridView.Rows[rowId].Cells[3].Value.ToString();
                InterfaceTextBox.Text = CPUGridView.Rows[rowId].Cells[4].Value.ToString();
                PriceUpDown.Value = (decimal)CPUGridView.Rows[rowId].Cells[5].Value;
                ReleaseDatePicker.Value = (DateTime)CPUGridView.Rows[rowId].Cells[6].Value;
            }
            catch (Exception)
            {

            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Storage storage = GetStorageFromSpecs(false);

            if (storage != null && storage.Model.Length <= 200)
            {
                var chakame = MainForm.client.PostAsJsonAsync("storages", storage).Result;
            }
            PopulateTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Storage storage = GetStorageFromSpecs(true);

            if (storage != null && storage.Model.Length <= 200)
            {
                var chakame = MainForm.client.PutAsJsonAsync("storages/" + storage.StorageId, storage).Result;
            }
            PopulateTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Storage storage = GetStorageFromSpecs(true);

            if (storage != null)
            {
                var chakame = MainForm.client.DeleteAsync("storages/" + storage.StorageId).Result;
            }

            PopulateTable();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            PopulateTable(FindbyModelTextBox.Text.ToString());
        }
    }
}
