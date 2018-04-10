using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ViewUsers : Form
    {
        WebControler wc;

        public ViewUsers()
        {
            InitializeComponent();
            
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            wc = new WebControler();
            dataGridView1.DataSource = wc.getDataTable();
        }
    }
}
