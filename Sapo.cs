using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatagridExample
{
    public partial class Sapo : Form
    {
        DataAccess aDataAccess;
        public Sapo()
        {
            InitializeComponent();
            aDataAccess = new DataAccess();
        }

        private void Sapo_Load(object sender, EventArgs e)
        {
            GetPlayers();
        }

        private void GetPlayers()
        {
            playersDataGridView.DataSource = aDataAccess.GetAllPlayers();
        }
    }
}
