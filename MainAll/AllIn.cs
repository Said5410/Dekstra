using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAll
{
    public partial class AllIn : Form
    {
        public AllIn()
        {
            InitializeComponent();
            DekstrBut.FlatStyle = FlatStyle.System;
            FordBut.FlatStyle = FlatStyle.System;
            
        }
        
        private void DekstrBut_Click(object sender, EventArgs e)
        {
            DekstraForm dForm = new DekstraForm();
            dForm.Show();
        }        

        private void FordBut_Click_1(object sender, EventArgs e)
        {
            MaxThreadForm fForm = new MaxThreadForm();
            fForm.Show();
        }
    }
}
