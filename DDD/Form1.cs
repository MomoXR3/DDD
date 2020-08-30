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
using System.Drawing.Text;

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
                inventorytimer.Stop();
            }
            else
            {
                inventarbox.Visible = true;
                inventorytimer.Start();
            }
        }


        private void Attacktimer_Tick(object sender, EventArgs e)
        {
            attack.Enabled = true;
            Attacktimer.Stop();
            
        }

        private void inventorytimer_Tick(object sender, EventArgs e)
        {   
            string ausrüstung;
            ausrüstung = Inventar.Resource1.Schwert;
            ListViewItem ausr = new ListViewItem(ausrüstung);
            bool sword = listView1.Items.Contains(ausr);

            if (sword == false)
            {
                listView1.Items.Add(ausr);
                inventorytimer.Stop();
                
            }



        }
    }
}
