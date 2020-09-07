using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace DDD
{
    public class KI
    {

        
        

            public void runde()
            {

                sbyte runde;
                runde = Convert.ToSByte(DDD.Properties.Settings.Default.runde);
                int hp = Convert.ToInt32(DDD.Properties.Settings.Default.HP);
                int hpe = Convert.ToInt32(DDD.Properties.Settings.Default.HPE);
                LOOP:
                if (runde < 1)
                {
                    hp = hp - 10;
                    runde = (sbyte)(runde + 1);
                    goto LOOP;
                }
                else
                {
                    runde.ToString(DDD.Properties.Settings.Default.runde);
                    DDD.Properties.Settings.Default.HP = hp;
                    DDD.Properties.Settings.Default.HPE = hpe;
                }
            }

        
        

        
            
        
    }
}
