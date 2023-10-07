using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace banka_otomasyonu_210601028_210601048
{
    public partial class musteriListele : Form
    {
        public musteriListele()
        {
            InitializeComponent();
        }

        private void musteriListele_Load(object sender, EventArgs e)
        {
            yeniMusteri yeni = new yeniMusteri();
            //musteriListeleListBox.Items.Add();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
