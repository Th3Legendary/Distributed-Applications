using Newtonsoft.Json;
using PC.Models.Entities;
using PC.UI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace PC.UI.Forms
{
    public partial class BuildListForm : Form
    {
        public int BuildId;
        public List<BuildList> OldData { get; set; }
        public List<Case> Cases { get; set; }
        public List<CPU> CPUs { get; set; }
        public List<GPU> GPUs { get; set; }
        public List<Motherboard> Motherboards { get; set; }
        public List<Memory> Memories { get; set; }
        public List<Storage> Storages { get; set; }
        public List<PSU> PSUs { get; set; }
        public List<Case> CasesSortedById { get; set; }
        public List<CPU> CPUsSortedById { get; set; }
        public List<GPU> GPUsSortedById { get; set; }
        public List<Motherboard> MotherboardsSortedById { get; set; }
        public List<Memory> MemoriesSortedById { get; set; }
        public List<Storage> StoragesSortedById { get; set; }
        public List<PSU> PSUsSortedById { get; set; }

        public BuildListForm()
        {
            InitializeComponent();
            GetAll();
            UpdateComboBoxes();
            PopulateTable();
        }

        public void DestroyItemsinComboBoxes()
        {
            NameTextbox.Text = "";
            CPUComboBox.Items.Clear();
            MotherboardComboBox.Items.Clear();
            StorageComboBox.Items.Clear();
            PSUComboBox.Items.Clear();
            GPUComboBox.Items.Clear();
            MemoryComboBox.Items.Clear();
            CaseComboBox.Items.Clear();
        }

        public void GetAll()
        {
            var responseCPUs = MainForm.client.GetStringAsync("cpus").Result;
            CPUs = JsonConvert.DeserializeObject<List<CPU>>(responseCPUs);
            var responseGPUs = MainForm.client.GetStringAsync("gpus").Result;
            GPUs = JsonConvert.DeserializeObject<List<GPU>>(responseGPUs);
            var responseMotherboards = MainForm.client.GetStringAsync("motherboards").Result;
            Motherboards = JsonConvert.DeserializeObject<List<Motherboard>>(responseMotherboards);
            var responseMemories = MainForm.client.GetStringAsync("memories").Result;
            Memories = JsonConvert.DeserializeObject<List<Memory>>(responseMemories);
            var responseStorages = MainForm.client.GetStringAsync("storages").Result;
            Storages = JsonConvert.DeserializeObject<List<Storage>>(responseStorages);
            var responsePSUs = MainForm.client.GetStringAsync("psus").Result;
            PSUs = JsonConvert.DeserializeObject<List<PSU>>(responsePSUs);
            var responseCases = MainForm.client.GetStringAsync("cases").Result;
            Cases = JsonConvert.DeserializeObject<List<Case>>(responseCases);
        }

        public void UpdateComboBoxes()
        {
            DestroyItemsinComboBoxes();
            foreach (var cpu in CPUs)
            {
                CPUComboBox.Items.Add(cpu.Model);
            }
            foreach (var gpu in GPUs)
            {
                GPUComboBox.Items.Add(gpu.Model);
            }
            foreach (var motherboard in Motherboards)
            {
                MotherboardComboBox.Items.Add(motherboard.Model);
            }
            foreach (var memory in Memories)
            {
                MemoryComboBox.Items.Add(memory.Model);
            }
            foreach (var psu in PSUs)
            {
                PSUComboBox.Items.Add(psu.Model);
            }
            foreach (var storage in Storages)
            {
                StorageComboBox.Items.Add(storage.Model);
            }
            foreach (var case1 in Cases)
            {
                CaseComboBox.Items.Add(case1.Model);
            }
        }

        public void PopulateTable(string search = null)
        {
            CasesSortedById = new List<Case>();
            CPUsSortedById = new List<CPU>();
            GPUsSortedById = new List<GPU>();
            MotherboardsSortedById = new List<Motherboard>();
            MemoriesSortedById = new List<Memory>();
            StoragesSortedById = new List<Storage>();
            PSUsSortedById = new List<PSU>();

            CPUGridView.Rows.Clear();
            var response = MainForm.client.GetStringAsync("buildlists").Result;
            var data = JsonConvert.DeserializeObject<List<BuildList>>(response);
            OldData = data;
            if (!string.IsNullOrEmpty(search))
            {
                data = data.Where(d => d.Name == search).ToList();
            }
            for (int i = 0; i < data.Count; i++)
            {
                try
                {
                    DataGridViewRow row = (DataGridViewRow)CPUGridView.Rows[0].Clone();
                    BuildId = data[i].BuildId;
                    row.Cells[0].Value = data[i].Name;
                    row.Cells[1].Value = CPUs.Where(c => c.CPUId == data[i].CPUId).FirstOrDefault().Model;
                    CPUsSortedById.Add(CPUs.Where(c => c.CPUId == data[i].CPUId).FirstOrDefault());
                    row.Cells[2].Value = Motherboards.Where(m => m.MotherboardId == data[i].MotherboardId).FirstOrDefault().Model;
                    MotherboardsSortedById.Add(Motherboards.Where(c => c.MotherboardId == data[i].MotherboardId).FirstOrDefault());
                    row.Cells[3].Value = Memories.Where(c => c.MemoryId == data[i].MemoryId).FirstOrDefault().Model;
                    MemoriesSortedById.Add(Memories.Where(c => c.MemoryId == data[i].MemoryId).FirstOrDefault());
                    row.Cells[4].Value = Storages.Where(c => c.StorageId == data[i].StorageId).FirstOrDefault().Model;
                    StoragesSortedById.Add(Storages.Where(c => c.StorageId == data[i].StorageId).FirstOrDefault());
                    row.Cells[5].Value = GPUs.Where(c => c.GPUId == data[i].GPUId).FirstOrDefault().Model;
                    GPUsSortedById.Add(GPUs.Where(c => c.GPUId == data[i].GPUId).FirstOrDefault());
                    row.Cells[6].Value = PSUs.Where(c => c.PSUId == data[i].PSUId).FirstOrDefault().Model;
                    PSUsSortedById.Add(PSUs.Where(c => c.PSUId == data[i].PSUId).FirstOrDefault());
                    row.Cells[7].Value = Cases.Where(c => c.CaseId == data[i].CaseId).FirstOrDefault().Model;
                    CasesSortedById.Add(Cases.Where(c => c.CaseId == data[i].CaseId).FirstOrDefault());
                    CPUGridView.Rows.Add(row);
                }
                catch(Exception)
                {
                    Console.WriteLine("Marto e nerealen pedalnik");
                }                
            }
        }
        public BuildList GetBuildListFromSpecs(bool flag)
        {
            BuildList buildList = null;
            try
            {
                buildList = new BuildList()
                {
                    Name = NameTextbox.Text,
                    CPUId = CPUs[CPUComboBox.SelectedIndex].CPUId,
                    MotherboardId = Motherboards[MotherboardComboBox.SelectedIndex].MotherboardId,
                    MemoryId = Memories[MemoryComboBox.SelectedIndex].MemoryId,
                    StorageId = Storages[StorageComboBox.SelectedIndex].StorageId,
                    GPUId = GPUs[GPUComboBox.SelectedIndex].GPUId,
                    PSUId = PSUs[PSUComboBox.SelectedIndex].PSUId,
                    CaseId = Cases[CaseComboBox.SelectedIndex].CaseId
                };
                if (flag)
                {
                    buildList.BuildId = BuildId;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return buildList;
        }
        private void CPUGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = CPUGridView.CurrentCell.RowIndex;
            if (rowId == CPUGridView.Rows.Count - 1)
            {
                DestroyItemsinComboBoxes();
                return;
            }
            BuildId = OldData[rowId].BuildId;
            NameTextbox.Text = OldData[rowId].Name;
            CPUComboBox.SelectedIndex = CPUs.IndexOf(CPUsSortedById[rowId]);
            CaseComboBox.SelectedIndex = Cases.IndexOf(CasesSortedById[rowId]);
            GPUComboBox.SelectedIndex = GPUs.IndexOf(GPUsSortedById[rowId]);
            PSUComboBox.SelectedIndex = PSUs.IndexOf(PSUsSortedById[rowId]);
            StorageComboBox.SelectedIndex = Storages.IndexOf(StoragesSortedById[rowId]);
            MemoryComboBox.SelectedIndex = Memories.IndexOf(MemoriesSortedById[rowId]);
            MotherboardComboBox.SelectedIndex = Motherboards.IndexOf(MotherboardsSortedById[rowId]);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            BuildList buildList = GetBuildListFromSpecs(false);

            if (buildList != null)
            {
                var chakame = MainForm.client.PostAsJsonAsync("buildlists", buildList).Result;
            }
            OldData.Add(buildList);
            PopulateTable(null);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            BuildList buildList = GetBuildListFromSpecs(true);

            if (buildList != null)
            {
                var chakame = MainForm.client.PutAsJsonAsync("buildlists/" + buildList.BuildId, buildList).Result;
            }
            PopulateTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            BuildList buildList = GetBuildListFromSpecs(true);

            if (buildList != null)
            {
                var chakame = MainForm.client.DeleteAsync("buildlists/" + buildList.BuildId).Result;
            }

            PopulateTable();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            PopulateTable(FindbyNameTextBox.Text.ToString());
        }

        
    }
}
