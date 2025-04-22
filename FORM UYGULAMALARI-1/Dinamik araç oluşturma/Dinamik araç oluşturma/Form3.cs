using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_araç_oluşturma
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int btnsayi = 10;
            int baslaX = 1;
            int baslaY = 1;
            int boyutbul;
            boyutbul =Convert.ToInt32(Math.Ceiling(Math.Sqrt(btnsayi)));

            for (int i = 0; i < btnsayi; i++)
            {
                Button button = new Button();
                button.Name = i.ToString();
                button.AutoSize = false;
                button.Size= new Size(this.Width/boyutbul, this.Height/(boyutbul*2));
                button.Text = "Buton " +i.ToString();
                button.Font = new Font(Name, 12);
                button.Location = new Point(baslaX, baslaY);
                this.Controls.Add(button);
                baslaX += button.Width + 10;

                if (baslaX + this.Height/boyutbul > this.Width)
                {
                    baslaX = 1;
                    baslaY += this.Height/(boyutbul * 2) + 5;
                }
            }

        }
    }
}
