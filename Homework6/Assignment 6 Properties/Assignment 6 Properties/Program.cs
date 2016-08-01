using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Properties
{
    class Television
    {
        private bool isOn;
        private int channel;
        private int volume;

        public bool IsOn
        {
            get
            { return isOn; }
        }

        public bool TurnOn
        {
            get
            { return isOn; }
            set
            { isOn = true; }
        }

        public bool TurnOff
        {
            get
            { return isOn; }
            set
            { isOn = false; }
        }

        public int CurrentVolume
        {
            get
            { return volume; }
        }

        public int IncreaseVolume
        {
            get { if (volume < 100); 
             return volume; }
            set
            {
                volume = volume + 1;
            }
        }

        public int DecreaseVolume
        {
            get
            { if (volume < 100);  return volume; }
            set { volume = volume - 1; }
        }

        public int CurrentChannel
        {
            get
            { return channel; }
        }

        public int IncreaseChannel
        {get { if (channel > 0 && channel < 50) ;  return channel; }
            set { channel = channel + 1; }
        }

        public int DecreaseChannel
        {
            get { if (channel > 0 && channel < 50) ; return channel; }
            set { channel = channel - 1; }
        }


        class TestTV
        {
            static void Main()
            {
                Television tv = new Television();

                if (!tv.IsOn)
                {
                    tv.isOn = true;
                }

                tv.channel = 3;

                tv.volume++;
                tv.volume++;
                tv.volume++;
                tv.volume++;

                tv.isOn = false;
            }
        }
    }
}

        
    
