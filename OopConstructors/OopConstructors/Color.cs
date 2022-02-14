using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConstructors
{
    public class Color
    {
        private Color(int colorCode)
        {
            ColorCod = colorCode;
        }
        public int ColorCod { get; }

        public static Color FromHex(string hexCode)
        {
            if (string.IsNullOrWhiteSpace(hexCode))
            {
                return null;
            }

            hexCode = hexCode.Replace("#", string.Empty);

            if (!int.TryParse(hexCode, System.Globalization.NumberStyles.HexNumber, null, out int result))
            {
                return null;
            }

            return new Color(result);
        }

        public static Color FromRgb(int red, int green, int blue)
        {
            var hexString = $"{Convert.ToString(red, 16).PadLeft(2, '0')}{Convert.ToString(green, 16).PadLeft(2, '0')}{Convert.ToString(blue, 16).PadLeft(2, '0')}";
            return Color.FromHex(hexString);
        }

        public static Color FromSaturation(int h, int s, int l)
        {
            return new Color(123);
        }
    }
}
