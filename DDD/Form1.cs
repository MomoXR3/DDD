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
using System.Media;
using System.Runtime.Remoting.Messaging;
using NAudio;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using RandomNumber;
using System.Security.Permissions;
using System.Runtime.CompilerServices;

namespace DDD
{

    public partial class Form1 : Form
    {
        public sbyte runde = 0;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font Fallout;




        public Form1()
        {
            InitializeComponent();
            DDD.Properties.Settings.Default.hps = 5;
            DDD.Properties.Settings.Default.hpm = 2;
            DDD.Properties.Settings.Default.hpb = 1;


            byte[] fontData = Properties.Resources.Overseer;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Overseer.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Overseer.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            Fallout = new Font(fonts.Families[0], 16.0F);

        }




        private int LPF = 0;

        private void attack_Click(object sender, EventArgs e)
        {
            int ab = Convert.ToInt32(attackbox.Text) * 5;
            int random = Randomness.getNextInt(1, 30) + ab;

            LPF = healthE.Value;
            LPF = LPF - random;
            if (LPF < 0)
            {
                LPF = 0;
            }

            healthE.Value = LPF;
            Schlagsound1();

            runde = (sbyte)(runde + 1);
            DDD.Properties.Settings.Default.runde = runde.ToString();
        }






        private void magic_Click(object sender, EventArgs e)
        {
            if (spells.Visible == true)
            {
                Closesound();
                spells.Visible = false;
            }
            else
            {
                Opensound();
                spells.Visible = true;

            }

        }

        private void character_Click(object sender, EventArgs e)
        {
            if (characterbox.Visible == true)
            {
                Closesound();
                characterbox.Visible = false;
            }
            else
            {
                Opensound();
                characterbox.Visible = true;

            }
        }




        private void inventory_Click(object sender, EventArgs e)
        {

            if (inventarbox.Visible == true)
            {
                Closesound();
                inventarbox.Visible = false;
                inventorytimer.Stop();
            }
            else
            {
                Opensound();
                inventarbox.Visible = true;
                inventorytimer.Start();
            }
        }


        private void Attacktimer_Tick(object sender, EventArgs e)
        {
            if (runde < 1)
            {
                attack.Enabled = true;
                yourturn.Visible = true;
                enemyturn.Visible = false;
            }
            else
            {
                attack.Enabled = false;
                enemytimer1.Start();
                yourturn.Visible = false;
                enemyturn.Visible = true;



            }
        }

        private void inventorytimer_Tick(object sender, EventArgs e)
        {



        }

        private void music_Tick(object sender, EventArgs e)
        {
            if (musicbox.Checked == true)
            {
                waveOut = null;
                Music();
            }

            else
            {
                waveOut.Stop();

            }
        }


        private void musicbox_CheckedChanged(object sender, EventArgs e)
        {
            music.Start();
        }

        private void hp_Click(object sender, EventArgs e)
        {

        }

        public void methoderunde()
        {
            deathtimer.Start();
            int hp = health.Value;
        LOOP:
            if (runde > 0)
            {
                int random = Randomness.getNextInt(1, 30) - Convert.ToInt32(defencebox.Text);
                if (random < 0)
                {
                    random = 0;
                }
                hp = hp - random;
                if (hp < 0)
                {
                    hp = 0;
                }
                Schlagsound2();
                health.Value = hp;
                runde = (sbyte)(runde - 1);
                attack.Enabled = true;
                goto LOOP;
            }
            else
            {
                runde.ToString(DDD.Properties.Settings.Default.runde);
                health.Value = hp;
            }


        }

        private void deathtimer_Tick(object sender, EventArgs e)
        {
            if (health.Value < 1)
            {
                Deadsound();
                attacktimer.Stop();
                dungeonlevel.Visible = false;
                dungeonlevelbox.Visible = false;
                dungeonlevelbox.Text = 0.ToString();
                die.Visible = true;
                restart.Visible = true;
                foreach (Control c in Controls)
                {
                    Button b = c as Button;
                    if (b != null)
                    {
                        b.Enabled = false;
                    }
                    restart.Enabled = true;
                    deathtimer.Stop();

                }

            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Respawnsound();
            health.Value = 100;
            healthE.Value = 100;
            levelxp = 20000;
            levelbox.Text = 1.ToString();
            attackbox.Text = 0.ToString();
            defencebox.Text = 0.ToString();
            magicbox.Text = 0.ToString();
            skillpointsbox.Text = 0.ToString();
            xpbox.Text = 0.ToString();
            nextlevelxp.Text = levelxp.ToString();
            dungeonprogress.Value = 0;
            attacktimer.Start();
            DDD.Properties.Settings.Default.Gold = 0.ToString();
            DDD.Properties.Settings.Default.hps = 5;
            DDD.Properties.Settings.Default.hpm = 2;
            DDD.Properties.Settings.Default.hpb = 1;
            die.Visible = false;
            restart.Visible = false;
            dungeonlevel.Visible = true;
            dungeonlevelbox.Visible = true;
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = true;
                }
                restart.Enabled = false;
                deathtimer.Start();

            }
        }

        private void Schlagsound1()
        {
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Schlag_1);
            audio.Play();

        }

        private void Schlagsound2()
        {
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Schlag_2);
            audio.Play();

        }

        private void Opensound()
        {
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Open);
            audio.Play();

        }


        private void Closesound()
        {
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Close);
            audio.Play();

        }






        private void Respawnsound()
        {
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Respawn);
            audio.Play();

        }


        private void Deadsound()
        {
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Dead);
            audio.Play();

        }



        private WaveOut waveOut;
        private void Music()
        {

            music.Stop();
            if (waveOut == null)
            {
                WaveFileReader reader = new WaveFileReader(DDD.Properties.Resources.Dunka_Dunka);
                LoopStream loop = new LoopStream(reader);
                waveOut = new WaveOut();
                waveOut.Init(loop);
                waveOut.Play();

            }
            else
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
        }




        private void enemytimer1_Tick(object sender, EventArgs e)
        {
            methoderunde();
            enemytimer1.Stop();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            {
                die.Font = Fallout;
                dungeonlevel.Font = Fallout;
                goldlabel.Font = Fallout;
                goldbox.Font = Fallout;
            }
        }

        private void deathtimerE_Tick(object sender, EventArgs e)
        { 
            if (healthE.Value < 1)
            {
                enemytimer1.Stop();
              
                runde = 0;
                int randomep = Randomness.getNextInt(1000, 10000);
                int epincrease = Convert.ToInt32(levelbox.Text) * (1000 * Convert.ToInt32(levelbox.Text));
                randomep = randomep + epincrease;
                int ep = Convert.ToInt32(xpbox.Text) + randomep;
                xpbox.Text = ep.ToString();
                int gp = Convert.ToInt32(goldbox.Text) + Randomness.getNextInt(100, 5000);
                goldbox.Text = gp.ToString();
                leveltimer.Start();
                int random;
                random = Randomness.getNextInt(1, 50);
                int dp = dungeonprogress.Value;
                dp = dungeonprogress.Value + random;
                if (dp > 100)
                {
                    dp = 100;
                }
                dungeonprogress.Value = dp;
                healthE.Value = 100;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int levelxp = 20000;

        private void leveltimer_Tick(object sender, EventArgs e)
        {

            if (Convert.ToInt32(xpbox.Text) >= levelxp)
            {
                nextlevel();
                leveltimer.Stop();

            }
        }




        private void nextlevel()
        {
            int skillvariable = Convert.ToInt32(skillpointsbox.Text);

            int lb = Convert.ToInt32(levelbox.Text);
            lb = lb + 1;
            levelbox.Text = lb.ToString();
            levelxp = levelxp + levelxp;
            levelxp = levelxp + Randomness.getNextInt(2000, 5000);
            nextlevelxp.Text = levelxp.ToString();
            skillvariable = skillvariable + 1;
            skillpointsbox.Text = skillvariable.ToString();
            health.Value = 100;
            leveltimer.Start();
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Levelup);
            audio.Play();
        }

        private void skillpointstimer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(skillpointsbox.Text) > 0)
            {
                skillpointstimer.Stop();
                defenseplus.Enabled = true;
                attackplus.Enabled = true;
                magicplus.Enabled = true;
                skillpointstimer.Start();
            }


            else
            {
                skillpointstimer.Stop();
                defenseplus.Enabled = false;
                attackplus.Enabled = false;
                magicplus.Enabled = false;
                skillpointstimer.Start();
            }
        }


        private void attackplus_Click(object sender, EventArgs e)
        {
            int ab = Convert.ToInt32(attackbox.Text);
            int spb = Convert.ToInt32(skillpointsbox.Text);
            ab = ab + 1;
            spb = spb - 1;
            attackbox.Text = ab.ToString();
            skillpointsbox.Text = spb.ToString();
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Skill);
            audio.Play();
        }

        private void magicplus_Click(object sender, EventArgs e)
        {
            int ab = Convert.ToInt32(magicbox.Text);
            int spb = Convert.ToInt32(skillpointsbox.Text);
            ab = ab + 1;
            spb = spb - 1;
            magicbox.Text = ab.ToString();
            skillpointsbox.Text = spb.ToString();
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Skill);
            audio.Play();

        }

        private void defenseplus_Click(object sender, EventArgs e)
        {
            int ab = Convert.ToInt32(defencebox.Text);
            int spb = Convert.ToInt32(skillpointsbox.Text);
            ab = ab + 1;
            spb = spb - 1;
            defencebox.Text = ab.ToString();
            skillpointsbox.Text = spb.ToString();
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Skill);
            audio.Play();

        }

        private void dungeontimer_Tick(object sender, EventArgs e)
        {
            if (dungeonprogress.Value == 100)
            {
                if (Convert.ToInt32(dungeonlevelbox.Text) < 10)
                {
                    int dlb = Convert.ToInt32(dungeonlevelbox.Text) + 1;
                    dungeonlevelbox.Text = dlb.ToString();
                    dungeonprogress.Value = 0;
                }
                else
                {
                    newdungeon();
                    attacktimer.Stop();
                    dungeontimer.Stop();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            health.Value = 0;
        }


        private void debugtimer_Tick(object sender, EventArgs e)
        {
        }

        private void shealing_Click(object sender, EventArgs e)
        {
            if (DDD.Properties.Settings.Default.hps > 0)
            {
                healpotion(25);
                DDD.Properties.Settings.Default.hps--;
            }
        }


        private void healpotion(int value)
        {
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.Potion);
            audio.Play();
            int h;
            h = health.Value + value;
            if (h > 100)
            {
                health.Value = 100;
            }
            else
            {
                health.Value = h;
            }

        }

        private void mhealing_Click(object sender, EventArgs e)
        {
            if(DDD.Properties.Settings.Default.hpm >0)
            {
                healpotion(50);
                DDD.Properties.Settings.Default.hpm--;
            }
        }

        private void bhealing_Click(object sender, EventArgs e)
        {

            if (DDD.Properties.Settings.Default.hpb > 0)
            {
                healpotion(100);
                DDD.Properties.Settings.Default.hpb--;
            }
        }

        private void newdungeon()
        {
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = false;
                }
                

            }
                restart.Visible = false;
                shop.Enabled = true;
                shop.Visible = true;
                neu.Enabled = true;
                neu.Visible = true;
        }

        private void neu_Click(object sender, EventArgs e)
        {
            dungeonlevelbox.Text = 0.ToString();
            dungeonprogress.Value = 0;
            health.Value = 100;
            special.Value = 100;
            int xp = Convert.ToInt32(xpbox.Text);
            xp += 100000 * Convert.ToInt32(levelbox.Text);
            xpbox.Text = xp.ToString();
            attacktimer.Start();
            dungeontimer.Start();
            goldbox.Text = DDD.Properties.Settings.Default.Gold;
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = true;
                }


            }
            shop.Enabled = false;
            shop.Visible = false;
            neu.Enabled = false;
            neu.Visible = false;
            SoundPlayer audio = new SoundPlayer(DDD.Properties.Resources.NewDungeon);
            audio.Play();
        }

        private void shop_Click(object sender, EventArgs e)
        {
            DDD.Properties.Settings.Default.Gold = goldbox.Text;
            Shop frm = new Shop();
            frm.Show();
        }

        private void dungeonfinish_Click(object sender, EventArgs e)
        {
            dungeonlevelbox.Text = 10.ToString();
            dungeonprogress.Value = 100;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            healthE.Value = 0;
        }


    }
}


