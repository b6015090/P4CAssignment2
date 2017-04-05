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

        //Buttons. Identifies which button is being selected by the user
        bool[] boolsButtonPressed = new bool[19];
        int intWhichButton = 0; 

        //Timer
        Timer myTimer = new Timer();

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

        private void Frm_MainWindow_Load(object sender, EventArgs e)
        {
            for (int intWhichButton = 0; intWhichButton <= 18; intWhichButton++)
                boolsButtonPressed[intWhichButton] = false;
        }

        private void timer()
        {
            Timer letterTimer = new Timer();
            myTimer.Interval = 2000;
            letterTimer.Start();
        }
        
        

        private void tb_wordBuilder_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btn7.Items[LetterIndex].ToString();
            timer();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btn8.Items[LetterIndex].ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btn9.Items[LetterIndex].ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btn4.Items[LetterIndex].ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btn5.Items[LetterIndex].ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btn6.Items[LetterIndex].ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btn1.Items[LetterIndex].ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btn2.Items[LetterIndex].ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btn3.Items[LetterIndex].ToString();
        }

        private void btn_star_Click(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btnstar.Items[LetterIndex].ToString();
        }

        private void lb_btnhash_SelectedIndexChanged(object sender, EventArgs e)
        {
            LetterIndex++;
            tb_wordBuilder.Text = lb_btnhash.Items[LetterIndex].ToString();
        }
    }
}
