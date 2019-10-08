using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        Cell[] cells = new Cell[16];

        public Form1()
        {
            for(int i = 0; i < 16; i++)
            {
                cells[i] = new Cell();
                cells[i].GetBox.BackColor = cells[i].Colors[cells[i].Power];
                cells[i].GetBox.Text = cells[i].GetNum.ToString();
                cells[i].GetBox = cells[i].GetBox;

                cells[i].GetBox.Location = new Point(50 + 100 * (i % 4), 50 + 100 * (i / 4));     
                Controls.Add(cells[i].GetBox);
            }

            InitializeComponent();
            Paint += Form1_Paint;
            Load += Form1_Load;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 800;
            Height = 600;
        }

        void moveUp()
        {

        }

        void moveDown()
        {

        }

        void moveRight()
        {

        }

        void moveLeft()
        {

        }

        void GenerateNum()
        {

        }

        


    }
}
