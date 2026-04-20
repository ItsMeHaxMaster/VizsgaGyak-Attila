using DataAccess;

namespace GUI
{
    public partial class Form1 : Form
    {
        private List<Auto> autok = new List<Auto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBetolt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV fájlok (*.csv)|*.csv|Minden fájl (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                autok = Auto.BeolvasCSV(ofd.FileName);
                dgvAutok.DataSource = null;
                dgvAutok.DataSource = autok;

                dgvAutok.Columns["Sorszam"]!.HeaderText = "Sorszám";
                dgvAutok.Columns["Marka"]!.HeaderText = "Márka";
                dgvAutok.Columns["Modell"]!.HeaderText = "Modell";
                dgvAutok.Columns["GyartasiEv"]!.HeaderText = "Gyártási év";
                dgvAutok.Columns["Szin"]!.HeaderText = "Szín";
                dgvAutok.Columns["EladottDarabszam"]!.HeaderText = "Eladott db";
                dgvAutok.Columns["AtlagosEladasiAr"]!.HeaderText = "Átl. ár (€)";

                SzuresByEv();
            }
        }

        private void tbEv_TextChanged(object sender, EventArgs e)
        {
            SzuresByEv();
        }

        private void SzuresByEv()
        {
            lbAutok.Items.Clear();
            if (int.TryParse(tbEv.Text, out int ev))
            {
                foreach (var auto in autok.Where(a => a.GyartasiEv == ev))
                {
                    lbAutok.Items.Add($"{auto.Marka} {auto.Modell}");
                }
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Valóban ki szeretne lépni?", "Kilépés",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
