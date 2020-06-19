using PC.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace PC.UI.UI
{
    public partial class MainForm : Form
    {
        public static HttpClient client = new HttpClient();
        public BuildListForm BuildListForm;
        public CPUForm CPUForm;
        public MotherboardForm MotherboardForm;
        public MemoryForm MemoryForm;
        public StorageForm StorageForm;
        public GPUForm GPUForm;
        public PSUForm PSUForm;
        public CaseForm CaseForm;
        public string JWTToken;

        public MainForm()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            var response = client.PostAsync("auth", new StringContent("")).Result.Content;
            JWTToken = response.ReadAsStringAsync().Result;

            if (!string.IsNullOrEmpty(JWTToken))
            {
               client.DefaultRequestHeaders
                    .Add("Authorization",String.Format("Bearer {0}", JWTToken));
            }

        }

        private void BuildListButton_Click(object sender, EventArgs e)
        {
            BuildListForm = new BuildListForm();
            BuildListForm.Visible = true;
        }

        private void CPUButton_Click(object sender, EventArgs e)
        {
            CPUForm = new CPUForm();
            CPUForm.Visible = true;
        }

        private void MotherboardButton_Click(object sender, EventArgs e)
        {
            MotherboardForm = new MotherboardForm();
            MotherboardForm.Visible = true;
        }

        private void MemoryButton_Click(object sender, EventArgs e)
        {
            MemoryForm = new MemoryForm();
            MemoryForm.Visible = true;
        }

        private void StorageButton_Click(object sender, EventArgs e)
        {
            StorageForm = new StorageForm();
            StorageForm.Visible = true;
        }

        private void GPUButton_Click(object sender, EventArgs e)
        {
            GPUForm = new GPUForm();
            GPUForm.Visible = true;
        }

        private void PSUButton_Click(object sender, EventArgs e)
        {
            PSUForm = new PSUForm();
            PSUForm.Visible = true;
        }

        private void CaseButton_Click(object sender, EventArgs e)
        {
            CaseForm = new CaseForm();
            CaseForm.Visible = true;
        }

        
    }
}
