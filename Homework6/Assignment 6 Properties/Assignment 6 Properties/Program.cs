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

        public int Volume 
        {
            get
            { return volume; }
            set { volume = 10; }
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

        public int Channel
        {
            get
            { return channel; }
            set { channel = 2; }
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

                tv.Channel = 3;

                tv.Volume++;
                tv.Volume++;
                tv.Volume++;
                tv.Volume++;

                tv.isOn = false;
            }
        }
    }
}

        
    
