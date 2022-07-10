using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCSS;

namespace CSSSkins
{
    public class CssImageItem
    {
        public string Css { get; set; }
        public string CssName { get; set; }
        public string Background { get; private set; } //set moze byc ustawiony tylko przez nas
       
        public string Filename { get; set; }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Disabled { get; set; }

        public CssImageItem(string css, StyleRule rules)
        {
            Css = css;
            Background = rules.Style.Background;
            CssName = rules.SelectorText;
            Width = rules.Style.Width.ToNumber();
            Height = rules.Style.Height.ToNumber();

            string[] elements = rules.Style.Background.Split(' ');
            if (elements.Length >= 3)
            {
                Filename = Path.GetFileName(elements[0].Replace("url(\"", "").Replace("\")", ""));
                PositionX = elements[1].ToNumber();
                PositionY = elements[2].ToNumber();
            }
        }

        public override string ToString()
        {
            return CssName; /*+ "\nW: " + Width + " H: " + Height + " X: " + PositionX + " Y: " + PositionY + "\nfile: " + Filename;*/
        }

        public bool CointainsPosition(int x, int y, int scale)
        {
            int scaledX = PositionX * scale;
            int scaledY = PositionY * scale;
            int scaledWidth = Width * scale;
            int scaledHeight = Height * scale;
            return x >= scaledX && y >= scaledY && x <= scaledX + scaledWidth && y <= scaledY + scaledHeight;
        }
    }
}
