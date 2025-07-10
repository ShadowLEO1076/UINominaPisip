using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinNominaPisip
{

    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>
        {
            // 🔵 Azules tecnológicos
            "#1E88E5", // Azul primario brillante
            "#1565C0", // Azul oscuro profesional
            "#00ACC1", // Teal moderno
            "#2E3A59", // Gris azulado para texto principal
            "#2196F3", // Azul vívido (acciones)
            "#3949AB", // Indigo moderno
            "#4682B4", // Azul metálico
            "#455A64", // Azul gris oscuro
            "#1E90FF", // Azul juvenil profesional

            // 🌿 Verdes tecnológicos
            "#43A047", // Verde de éxito
            "#2ECC71", // Verde esmeralda elegante
            "#00B894", // Verde menta moderno
            "#00897B", // Teal profundo
            "#16A085", // Verde marino tranquilo

            // 🩶 Grises sofisticados
            "#607D8B", // Gris azulado intermedio
            "#37474F", // Gris carbón

            // 🔥 Rojos y naranjas sobrios
            "#E53935", // Rojo de alerta (base tuya)
            "#F44336", // Rojo moderno
            "#FF7043", // Naranja quemado
            "#FF6F61", // Coral suave
            "#EF5350"  // Rojo intenso suave
            
        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

    }
}     
