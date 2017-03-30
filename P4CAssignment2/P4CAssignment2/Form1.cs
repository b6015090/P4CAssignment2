using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4CAssignment2
{
    public partial class Form1 : Form
    {
        int LetterIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void lb_btn7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_mode_Click(object sender, EventArgs e)
        {
            if (tb_modestatus.Text == "Multi-Press")
            {
                tb_modestatus.Text ="Prediction";
            }
            else{
                tb_modestatus.Text = "Multi-Press";
            }
        }

        //private void typing
       
            
        
        

        private void tb_wordBuilder_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
             

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btn8.Items[LetterIndex].ToString();
        }
    }
}
