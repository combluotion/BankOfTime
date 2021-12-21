using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankOfTime.Models;

namespace BankOfTime
{
    public partial class lastRequests : Form
    {
        public lastRequests()
        {
            InitializeComponent();
        }

        private void lastRequests_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        private void refrescar()
        {
            using (masterEntities db = new masterEntities())
            {
                var lista = from d in db.user
                            select new { d.Name, d.Capabilities, d.MonthlyHours };
                dataGridView1.DataSource = lista.ToList();


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (masterEntities db = new masterEntities())
            {
                String findCompabilities = txtBuscar.Text;
                var buscar = from b in db.user
                             where b.Capabilities == findCompabilities
                             select new { b.Name, b.Capabilities, b.MonthlyHours };
                dataGridView1.DataSource = buscar.ToList();

                if (findCompabilities == "")
                {
                    refrescar();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (masterEntities db = new masterEntities())
            {
                String findCompabilities = txtBuscar.Text;
                var buscar = from b in db.user
                             where b.Capabilities == findCompabilities
                             select new { b.Name, b.Capabilities, b.MonthlyHours };
                dataGridView1.DataSource = buscar.ToList();

                if (findCompabilities == "")
                {
                    refrescar();
                }
            }
        }
    }
}
