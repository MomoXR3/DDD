using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;

namespace DDD
{
    
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            


        }
            
        private int LPF = 0;

        private void attack_Click(object sender, EventArgs e)
        {




            LPF = healthE.Value;
            LPF = LPF - 20;

            healthE.Value = LPF;

            attack.Enabled = false;
            Attacktimer.Start();
            
        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void magic_Click(object sender, EventArgs e)
        {
            if (spells.Visible == true)
            {
                spells.Visible = false;
            }
            else
            {
                spells.Visible = true;

            } 

        }

        private void character_Click(object sender, EventArgs e)
        {
 if (characterbox.Visible == true)
            {
                characterbox.Visible = false;
            }
            else
            {
                characterbox.Visible = true;

            } 
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void inventory_Click(object sender, EventArgs e)
        {
            if (inventarbox.Visible == true)
            {
                inventarbox.Visible = false;
            }
            else
            {
                inventarbox.Visible = true;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 2)
            {
                if (checkedListBox1.GetItemChecked(1))
                {
                    checkedListBox1.SetItemChecked(1, false);
                }
                else
                {
                    if (checkedListBox1.GetItemChecked(2))
                    {
                        checkedListBox1.SetItemChecked(2, false);
                    }
                }

            }
        }

        private void Attacktimer_Tick(object sender, EventArgs e)
        {
            attack.Enabled = true;
            Attacktimer.Stop();
            
        }
    }
}
