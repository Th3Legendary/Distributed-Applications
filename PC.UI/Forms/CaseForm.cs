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
    public partial class CaseForm : Form
    {
        public int CaseId;
        public CaseForm()
        {
            InitializeComponent();
            PopulateTable();
        }
        public void DestroyTextInTextBox()
        {
            ManufacturerTextBox.Clear();
            ModelTextBox.Clear();
            TypeTextBox.Clear();
            SidePanelTextBox.Clear();
            PriceUpDown.Value = 0.01m;
            ReleaseDatePicker.Value = DateTime.UtcNow;
        }
        public Case GetCaseFromSpecs(bool flag)
        {
            Case case1 = null;
            try
            {
                case1 = new Case()
                {
                    Manufacturer = ManufacturerTextBox.Text,
                    Model = ModelTextBox.Text,
                    Type = TypeTextBox.Text,
                    SidePanel = SidePanelTextBox.Text,
                    Price = PriceUpDown.Value,
                    ReleaseDate = ReleaseDatePicker.Value
                };
                if (flag)
                {
                    case1.CaseId = CaseId;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return case1;
        }
        public void PopulateTable(string model = null)
        {
            CPUGridView.Rows.Clear();
            var response = MainForm.client.GetStringAsync("cases").Result;
            var data = JsonConvert.DeserializeObject<List<Case>>(response);
            if (!string.IsNullOrEmpty(model))
            {
                data = data.Where(d => d.Model == model).ToList();
            }
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)CPUGridView.Rows[0].Clone();
                CaseId = data.ElementAt(i).CaseId;
                row.Cells[0].Value = data.ElementAt(i).Manufacturer;
                row.Cells[1].Value = data.ElementAt(i).Model;
                row.Cells[2].Value = data.ElementAt(i).Type;
                row.Cells[3].Value = data.ElementAt(i).SidePanel;
                row.Cells[4].Value = data.ElementAt(i).Colour;
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
                TypeTextBox.Text = CPUGridView.Rows[rowId].Cells[2].Value.ToString();
                SidePanelTextBox.Text = CPUGridView.Rows[rowId].Cells[3].Value.ToString();
                MemorySlotsTextBox.Text = CPUGridView.Rows[rowId].Cells[4].Value.ToString();
                PriceUpDown.Value = (decimal)CPUGridView.Rows[rowId].Cells[5].Value;
                ReleaseDatePicker.Value = (DateTime)CPUGridView.Rows[rowId].Cells[6].Value;
            }
            catch (Exception)
            {

            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Case case1 = GetCaseFromSpecs(false);

            if (case1 != null && case1.Model.Length <= 200)
            {
                var chakame = MainForm.client.PostAsJsonAsync("cases", case1).Result;
            }
            PopulateTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Case case1 = GetCaseFromSpecs(true);

            if (case1 != null && case1.Model.Length <= 200)
            {
                var chakame = MainForm.client.PutAsJsonAsync("cases/" + case1.CaseId, case1).Result;
            }
            PopulateTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Case case1 = GetCaseFromSpecs(true);

            if (case1 != null)
            {
                var chakame = MainForm.client.DeleteAsync("cases/" + case1.CaseId).Result;
            }

            PopulateTable();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            PopulateTable(FindbyModelTextBox.Text.ToString());
        }
    }
}
