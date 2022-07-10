using ExCSS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSkins
{
    public class CssManager
    {
        //-----------------------------------------------------------------------------------------------------------------------------
        // cala  mechanika zarzadzania css
        //Load css --> uzupelnia liste
        //Lista plikow
        //-----------------------------------------------------------------------------------------------------------------------------

        public List<CssImageItem> ImageList = new List<CssImageItem>();
        public List<CssImageItem> UpdatedImageList = new List<CssImageItem>();
        public List<FileElement> ImagesInPath = new List<FileElement>();
        public List<FileElement> CssFiles = new List<FileElement>();

        public void LoadFiles()
        {
            ImagesInPath = Directory.GetFiles(@"C:\Users\lesni\Downloads\").Where(x => x.EndsWith(".png")).Select(x => new FileElement(x)).ToList();
            CssFiles = Directory.GetFiles(@"C:\Users\lesni\Downloads\").Where(x => x.EndsWith(".css")).Select(x => new FileElement(x)).ToList();
        }

        public void LoadCss(string filename)
        {
            ImageList.Clear();
            string css = File.ReadAllText(filename);
            StylesheetParser parser = new StylesheetParser();
            Stylesheet stylesheet = parser.Parse(css);
            if (stylesheet == null)
            {
                return;
            }

            foreach (IStylesheetNode node in stylesheet.Children)
            {
                Stylesheet style = parser.Parse(node.StylesheetText.Text);
                if (style.StyleRules.First() is StyleRule rule)
                {
                    CssImageItem image = new CssImageItem(node.StylesheetText.Text, rule);
                    ImageList.Add(image);
                }
            }
        }

        public void EnableCssImagesByFilename(string filename)
        {
            UpdatedImageList.Clear();
            ImageList.ToList().ForEach(x =>
            {
                if (x.Filename != null && x.Filename == filename)
                {
                    x.Disabled = false;
                    UpdatedImageList.Add(x);
                }
                else
                {
                    x.Disabled = true;
                }
            });
        }

        public List<string> GetPngOnlyFormCss()
        {
            if(ImagesInPath == null || ImagesInPath.Count == 0)
            {
                return null;
            }

            List<string> listPng = new List<string>();
            List<string> listFilenames = new List<string>();
            List<string> onlyPngFromCss = new List<string>();

            foreach (FileElement file in ImagesInPath)
            {
                listPng.Add(file.Filename);
            }

            foreach (CssImageItem i in ImageList)
            {
                listFilenames.Add(i.Filename);
            }

            foreach (string i in listFilenames)
            {
                foreach (string j in listPng)
                {
                    if (i == j && !onlyPngFromCss.Contains(j))
                    {
                        onlyPngFromCss.Add(j.ToString());
                    }
                }
            }
            return onlyPngFromCss;
        }

        public CssImageItem GetCssByPosition(int x, int y, int scale)
        {
            return UpdatedImageList.FirstOrDefault(item => item.CointainsPosition(x, y, scale));
        }
    }
}
