using RandomNumber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD
{
    public partial class Shop : Form
    {
        

        public Shop()
        {
            InitializeComponent();
            goldbox.Text = DDD.Properties.Settings.Default.Gold;
            hpbcounter.Text = DDD.Properties.Settings.Default.hpb.ToString();
            hpmcounter.Text = DDD.Properties.Settings.Default.hpm.ToString();
            hpscounter.Text = DDD.Properties.Settings.Default.hps.ToString();
            
        }

        private void shopkeepersound_Tick(object sender, EventArgs e)
        {

                int sound = Randomness.getNextInt(1, 3);
                switch(sound)
                {
                    case 1:
                        SoundPlayer audio1 = new SoundPlayer(DDD.Properties.Resources.Shopkeeper1);
                        audio1.Play();
                        break;

                    case 2:
                        SoundPlayer audio2 = new SoundPlayer(DDD.Properties.Resources.Shopkeeper2);
                        audio2.Play();
                        break;

                    case 3:
                        SoundPlayer audio3 = new SoundPlayer(DDD.Properties.Resources.Shopkeeper3);
                        audio3.Play();
                        break;


                }

            

        }

 
        private void gold_Click(object sender, EventArgs e)
        {

        }

        private void HPS_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(goldbox.Text) >= 100)
            {
                DDD.Properties.Settings.Default.hps++;
                int goldint = Convert.ToInt32(goldbox.Text);
                goldint -= 100;
                goldbox.Text = goldint.ToString();
                DDD.Properties.Settings.Default.Gold = goldbox.Text;
                SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Gold);
                audio.Play();
                hpscounter.Text = DDD.Properties.Settings.Default.hps.ToString();

            }
        }

        private void HPM_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(goldbox.Text) >= 500)
            {
                DDD.Properties.Settings.Default.hpm++;
                int goldint = Convert.ToInt32(goldbox.Text);
                goldint -= 500;
                goldbox.Text = goldint.ToString();
                DDD.Properties.Settings.Default.Gold = goldbox.Text;
                SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Gold);
                audio.Play();
                hpmcounter.Text = DDD.Properties.Settings.Default.hpm.ToString();

            }
        }

        private void HPB_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(goldbox.Text) >= 1000)
            {
                DDD.Properties.Settings.Default.hpb++;
                int goldint = Convert.ToInt32(goldbox.Text);
                goldint -= 1000;
                goldbox.Text = goldint.ToString();
                DDD.Properties.Settings.Default.Gold = goldbox.Text;
                SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Gold);
                audio.Play();
                hpbcounter.Text = DDD.Properties.Settings.Default.hpb.ToString();

            }
        }







    }
}
