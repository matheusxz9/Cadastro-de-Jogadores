using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace AulaMultiJanelas
{
    public partial class FrmNovaJanela : Form
    {
        private readonly BindingList<Jogadores> jogadores = new BindingList<Jogadores>();
        public FrmNovaJanela()
        {
            InitializeComponent();
            dataGridView1.DataSource = jogadores;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            CarregarJogadores();
        }

        private void CarregarJogadores()
        {
            jogadores.Clear();

            string arquivo = ObterCaminhoArquivo();
            if (!File.Exists(arquivo))
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Jogadores>));
            using FileStream arquivoXml = File.OpenRead(arquivo);
            List<Jogadores> lista = (List<Jogadores>)serializer.Deserialize(arquivoXml);
            foreach (Jogadores jogador in lista)
            {
                jogadores.Add(jogador);
            }
        }

        private static string ObterCaminhoArquivo()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return Path.Combine(path, "jogadores.xml");
        }
    }
}
