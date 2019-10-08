using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    class Cell
    {
        int num;        // 2~2048 (OR MORE)
        int cellNum;    // 0~15
        int power;      // 1~
        TextBox CellTextBox;

        public Cell()
        {
            CellTextBox = new TextBox();
            CellTextBox.Multiline = true;
            CellTextBox.TextAlign = HorizontalAlignment.Center;
            CellTextBox.Font = new Font(CellTextBox.Font.FontFamily, 60);
            CellTextBox.Width = 100;
            CellTextBox.Height = 100;
        }
    
        Color[] colors = new Color[] { Color.Gray, Color.Orange,Color.LightBlue,
            Color.LightGreen,Color.LightPink, Color.LightYellow, Color.Magenta,
            Color.LightSalmon, Color.LemonChiffon,Color.Lavender,Color.Red };

        bool HitEnd = false;        // true when hit boundary
        bool isBlank;               

        public int GetNum { get => num; set => num = value; }
        public Color[] Colors { get => colors; set => colors = value; }
        public bool IsBlank { get => isBlank; set => isBlank = value; }
        public int Power { get => power; set => power = value; }
        public TextBox GetBox { get => CellTextBox; set => CellTextBox = value; }
    }
}
