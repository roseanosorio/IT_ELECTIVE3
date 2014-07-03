using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class frmB : Form
    {
        public frmB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();

                int result = Convert.ToInt32(f2.txtReplace.Text) + Convert.ToInt32(btnResult.Text);
                btnResult.Text = result.ToString();

            }
            catch (Exception ex)
            {
                
               MessageBox.Show("Error : BAwal ang LETTER! numbers only" + ex.Message);
            }
            
          
            
        }

        private void frmB_Load(object sender, EventArgs e)
        {
            
        }
    }
}