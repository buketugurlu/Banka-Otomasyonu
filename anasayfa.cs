using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_otomasyonu_210601028_210601048
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        

        }

        private void paraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            paraCekme paraCekme = new paraCekme();
            paraCekme.Show();
        }

        private void paraYatırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paraYatırma paraYatırma = new paraYatırma();
            paraYatırma.Show();
        }

        private void havaleYapmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            havaleBireysel havaleB = new havaleBireysel();
            havaleB.Show();
        }

        private void hesapÖzetiGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapOzeti hesapOzeti = new hesapOzeti();
            hesapOzeti.Show();
        }

        private void hesapKapmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapKapama hesapKapama = new hesapKapama();
            hesapKapama.Show();
        }

        private void yeniHesapAçmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapAcma hesapacma = new hesapAcma();
            hesapacma.Show();
        }

        private void paraÇekmeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            paraCekme paraCekme = new paraCekme();
            paraCekme.Show();
        }

        private void paraYatırmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            paraYatırma paraYatırma = new paraYatırma();
            paraYatırma.Show();
        }

        private void havaleYapmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            havaleTicari havaleT = new havaleTicari();
            havaleT.Show();
        }

        private void hesapÖzetiGörüntüleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hesapOzeti hesapOzeti = new hesapOzeti();
            hesapOzeti.Show();
        }

        private void hesapKapamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapKapama hesapKapama = new hesapKapama();
            hesapKapama.Show();
        }

        private void yeniHesapAçmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hesapAcma hesapacma = new hesapAcma();
            hesapacma.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yeniMüşteriEklemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniMusteri yeni = new yeniMusteri();
            yeni.Show();
        }

        private void hesapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapListesi hesaplist = new hesapListesi();
            hesaplist.Show();
        }

        private void bankaRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankaRaporu bankaRaporu = new bankaRaporu();
            bankaRaporu.Show();
        }
    }
}
