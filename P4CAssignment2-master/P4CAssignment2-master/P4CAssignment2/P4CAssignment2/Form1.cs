using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyDialogs;


namespace P4CAssignment2
{
    public partial class Form1 : Form
    {

        bool firstvisit = true;
        int LetterIndex = -1;

        bool wordAdded = false;

        string Application_Path = Directory.GetCurrentDirectory() + "\\";

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
                tb_modestatus.Text = "Prediction";
            }
            else
            {
                tb_modestatus.Text = "Multi-Press";
            }
        }

        private void Frm_MainWindow_Load(object sender, EventArgs e)
        {

        }





        private void tb_wordBuilder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();

                //copy the right list box = global list box
                lb_Global.Items.AddRange(lb_btn7.Items);
            }

            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();

                //copy the right list box = global list box
                lb_Global.Items.AddRange(lb_btn8.Items);
            }

            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();
                //copy the right list box = global list box


                lb_Global.Items.AddRange(lb_btn9.Items);

            }

            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();

                //copy the right list box = global list box
                lb_Global.Items.AddRange(lb_btn4.Items);
            }

            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();

                //copy the right list box = global list box
                lb_Global.Items.AddRange(lb_btn5.Items);
            }

            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();

                //copy the right list box = global list box
                lb_Global.Items.AddRange(lb_btn6.Items);
            }

            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();

                //copy the right list box = global list box
                lb_Global.Items.AddRange(lb_btn1.Items);
            }

            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();

                //copy the right list box = global list box
                lb_Global.Items.AddRange(lb_btn2.Items);
            }

            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();

                //copy the right list box = global list box
                lb_Global.Items.AddRange(lb_btn3.Items);
            }

            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;
        }

        private void btn_star_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();

                //copy the right list box = global list box
                lb_Global.Items.AddRange(lb_btnstar.Items);
            }

            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;
        }

        private void lb_btnhash_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void letterBuilder_Tick(object sender, EventArgs e)
        {
            //turning timer off
            letterBuilder.Enabled = false;

            //appends individual letter from the list of letters
            tb_wordBuilder.AppendText(lb_Global.Items[LetterIndex].ToString());
            LetterIndex = -1;

            firstvisit = true;
        }

        private void btn_hash_Click(object sender, EventArgs e)
        {
            if (firstvisit == true)
            {
                lb_Global.Items.Clear();

                //copy the right list box = global list box
                lb_Global.Items.AddRange(lb_btnhash.Items);
            }
            letterBuilder.Enabled = false;
            LetterIndex++;

            letterBuilder.Enabled = true;
        }

        private void tb_modestatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_notepad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            wordAdded = true;

            if (wordAdded == true)
            {
                tb_notepad.AppendText(" " + tb_wordBuilder.Text);
                //Clears the textbox
                tb_wordBuilder.Clear();

            }

            //Adding to dictionary
            if (tb_notepad.Text != "")
            {
                
                //open the stream
                StreamWriter My_Output_Stream = File.CreateText(Application_Path + "Dictionary.txt");

                int lines = tb_notepad.Lines.Count();
                for (int i = 0; i < lines; i++)
                {
                    My_Output_Stream.WriteLine(tb_notepad.Lines[i]); //write the stream
                }

                My_Output_Stream.Close(); //close the stream
            }
        }

        private void lb_Global_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            tb_notepad.AppendText(Environment.NewLine);
            tb_notepad.Focus();

        }

        private void btn_configure_Click(object sender, EventArgs e)
        {


        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            letterBuilder.Interval = 500;
            int letterInt = Convert.ToInt32(My_Dialogs.InputBox("Please enter the delay value you require between 500-5000. 1000= 1 second. Currently set at:" + letterBuilder.Interval));
            letterBuilder.Interval = letterInt;


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // New File
            if (tb_notepad.Text != "")
            {
                tb_notepad.Clear();
            }
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (tb_notepad.Text != "")
            {
                string fileName = My_Dialogs.InputBox("File name: ");
                //open the stream
                StreamWriter My_Output_Stream = File.CreateText(Application_Path + fileName + ".txt");

                int lines = tb_notepad.Lines.Count();
                for (int i = 0; i < lines; i++)
                {
                    My_Output_Stream.WriteLine(tb_notepad.Lines[i]); //write the stream
                }

                My_Output_Stream.Close(); //close the stream
            }
            else
            {
                MessageBox.Show("You must enter text before saving!");
            }
        }
    }
}

