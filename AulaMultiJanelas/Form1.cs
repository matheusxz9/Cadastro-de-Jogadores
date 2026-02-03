using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace AulaMultiJanelas
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovaJanela frm = new FrmNovaJanela();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Fechar Aplicativo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogadores objJogador = new Jogadores();
            objJogador.Nome = txtNome.Text.Trim();
            objJogador.Idade = Convert.ToInt32(txtIdade.Text.Trim());
            objJogador.NumeroInscricao = txtNumeroInscricao.Text.Trim();
            objJogador.Modalidade = txtModalidade.Text.Trim();
            objJogador.Clube = txtClube.Text.Trim();

            XmlSerializer writer = new XmlSerializer(typeof(Jogadores));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = Path.Combine(path, "jogador.xml");

            FileStream arquivoXML = File.Create(arquivo);
            writer.Serialize(arquivoXML, objJogador);
            arquivoXML.Close();

            MessageBox.Show("Registro salvo com sucesso!");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
