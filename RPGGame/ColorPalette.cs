using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    internal class ColorPalette
    {
        public Color[] colors = new Color[5];
        public ColorPalette(Color color0, Color color1, Color color2, Color color3, Color color4)
        {
            this.colors[0] = color0;
            this.colors[1] = color1;
            this.colors[2] = color2;
            this.colors[3] = color3;
            this.colors[4] = color4;
        }

        public ColorPalette(string color0, string color1, string color2, string color3, string color4)
        {
            this.colors[0] = HexToRGB(color0);
            this.colors[1] = HexToRGB(color1);
            this.colors[2] = HexToRGB(color2);
            this.colors[3] = HexToRGB(color3);
            this.colors[4] = HexToRGB(color4);
        }

        public Color GetColor(byte index)
        {
            return colors[index];
        }
        
        public Color[] GetColors()
        {
            return colors;
        }



        public static Color HexToRGB(string value)
        {
            if (value.Length != 6)
            {
                Debug.WriteLine("Wrong Hex Usage!");
                return Color.FromArgb(0, 0, 0);
            }

            int r = Int32.Parse(value.ToArray()[0] + "" + value.ToArray()[1] + "", System.Globalization.NumberStyles.HexNumber);
            int g = Int32.Parse(value.ToArray()[2] + "" + value.ToArray()[3] + "", System.Globalization.NumberStyles.HexNumber);
            int b = Int32.Parse(value.ToArray()[4] + "" + value.ToArray()[5] + "", System.Globalization.NumberStyles.HexNumber);
            return Color.FromArgb(r, g, b);

        }



    }
}
