﻿using System;
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
    }
}
