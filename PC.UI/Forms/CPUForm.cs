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
    public partial class CPUForm : Form
    {
        public int CPUId;
        public CPUForm()
        {
            InitializeComponent();
            PopulateTable();
        }
        public void DestroyTextInTextBox()
        {
            ManufacturerTextBox.Clear();
            ModelTextBox.Clear();
            CoreCountTextBox.Clear();
            BaseClockTextBox.Clear();
            BoostClockTextBox.Clear();
            TDPTextBox.Clear();
            SocketTextBox.Clear();
            LithographyTextBox.Clear();
            IntegratedGPUCheckBox.Checked = false;
            SMTCheckBox.Checked = false;
            PriceUpDown.Value = 0.01m;
            ReleaseDatePicker.Value = DateTime.UtcNow;
        }
        public CPU GetCPUFromSpecs(bool flag)
        {
            CPU cpu = null;
            try
            {
                cpu = new CPU()
                {
                    Manufacturer = ManufacturerTextBox.Text,
                    Model = ModelTextBox.Text,
                    CoreCount = int.Parse(CoreCountTextBox.Text),
                    BaseClock = float.Parse(BaseClockTextBox.Text),
                    BoostClock = float.Parse(BoostClockTextBox.Text),
                    TDP = int.Parse(TDPTextBox.Text),
                    Socket = SocketTextBox.Text,
                    Lithography = int.Parse(LithographyTextBox.Text),
                    IntegrateGraphics = IntegratedGPUCheckBox.Checked,
                    SimultaniousMultithreading = SMTCheckBox.Checked,
                    Price = PriceUpDown.Value,
                    ReleaseDate = ReleaseDatePicker.Value
                };
                if (flag)
                {
                    cpu.CPUId = CPUId;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return cpu;
        }
        public void PopulateTable(string model = null)
        {
            CPUGridView.Rows.Clear();
            var response = MainForm.client.GetStringAsync("cpus").Result;
            var data = JsonConvert.DeserializeObject<List<CPU>>(response);
            if (!string.IsNullOrEmpty(model))
            {
                data = data.Where(d => d.Model == model).ToList();
            }
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)CPUGridView.Rows[0].Clone();
                CPUId = data.ElementAt(i).CPUId;
                row.Cells[0].Value = data.ElementAt(i).Manufacturer;
                row.Cells[1].Value = data.ElementAt(i).Model;
                row.Cells[2].Value = data.ElementAt(i).CoreCount;
                row.Cells[3].Value = data.ElementAt(i).BaseClock;
                row.Cells[4].Value = data.ElementAt(i).BoostClock;
                row.Cells[5].Value = data.ElementAt(i).TDP;
                row.Cells[6].Value = data.ElementAt(i).Socket;
                row.Cells[7].Value = data.ElementAt(i).Lithography;
                row.Cells[8].Value = data.ElementAt(i).IntegrateGraphics;
                row.Cells[9].Value = data.ElementAt(i).SimultaniousMultithreading;
                row.Cells[10].Value = data.ElementAt(i).Price;
                row.Cells[11].Value = data.ElementAt(i).ReleaseDate;
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
            ManufacturerTextBox.Text = CPUGridView.Rows[rowId].Cells[0].Value.ToString();
            ModelTextBox.Text = CPUGridView.Rows[rowId].Cells[1].Value.ToString();
            CoreCountTextBox.Text = CPUGridView.Rows[rowId].Cells[2].Value.ToString();
            BaseClockTextBox.Text = CPUGridView.Rows[rowId].Cells[3].Value.ToString();
            BoostClockTextBox.Text = CPUGridView.Rows[rowId].Cells[4].Value.ToString();
            TDPTextBox.Text = CPUGridView.Rows[rowId].Cells[5].Value.ToString();
            SocketTextBox.Text = CPUGridView.Rows[rowId].Cells[6].Value.ToString();
            LithographyTextBox.Text = CPUGridView.Rows[rowId].Cells[7].Value.ToString();
            IntegratedGPUCheckBox.Checked = (bool)CPUGridView.Rows[rowId].Cells[8].Value;
            SMTCheckBox.Checked = (bool)CPUGridView.Rows[rowId].Cells[9].Value;
            PriceUpDown.Value = (decimal)CPUGridView.Rows[rowId].Cells[10].Value;
            ReleaseDatePicker.Value = (DateTime)CPUGridView.Rows[rowId].Cells[11].Value;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CPU cpu = GetCPUFromSpecs(false);

            if (cpu != null && cpu.Model.Length <= 200)
            {
                var chakame = MainForm.client.PostAsJsonAsync("cpus", cpu).Result;
            }
            PopulateTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            CPU cpu = GetCPUFromSpecs(true);

            if (cpu != null && cpu.Model.Length <= 200)
            {
                var chakame = MainForm.client.PutAsJsonAsync("cpus/" + cpu.CPUId, cpu).Result;
            }
            PopulateTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CPU cpu = GetCPUFromSpecs(true);

            if (cpu != null)
            {
                var chakame = MainForm.client.DeleteAsync("cpus/" + cpu.CPUId).Result;
            }
            
            PopulateTable();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            PopulateTable(FindbyModelTextBox.Text.ToString());
        }      
    }
}
