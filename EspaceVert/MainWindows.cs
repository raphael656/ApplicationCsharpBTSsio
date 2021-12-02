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
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Quitter(object sender, EventArgs e)
        {
            Dasboard f = new Dasboard();
            f.Close();
            this.Close();
           
        }

        private void Seconnecter(object sender, EventArgs e)
        {
            this.Close();
            
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
