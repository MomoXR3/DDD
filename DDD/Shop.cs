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
    }
}
