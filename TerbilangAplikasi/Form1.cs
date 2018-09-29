using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerbilangLibrary;

namespace TerbilangAplikasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int buatvariabelbaru = int.Parse(textBoxAngka.Text);
            Terbilang terbilang = new Terbilang();
            listBoxHasil.Items.Clear();
            listBoxHasil.Items.Add(terbilang.TerbilangIndonesia(buatvariabelbaru));
          

        }
    }
}
