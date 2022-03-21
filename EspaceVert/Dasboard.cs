using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspaceVert
{
    public partial class Dasboard : Form
    {
        public Dasboard()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MainWindows main = new MainWindows();
            main.ShowDialog();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dashButton_Click(object sender, EventArgs e)
        {
            loadform(new ContenuDashboard());
        }

        private void gestProdButton(object sender, EventArgs e)
        {
            loadform(new gestionProduitForms());
        }

        private void addProdButtonS(object sender, EventArgs e)
        {
            loadform(new ajoutProduit());
        }

        private void gestAdminButton(object sender, EventArgs e)
        {
            loadform(new gestionAdmin());
        }
    }
}
