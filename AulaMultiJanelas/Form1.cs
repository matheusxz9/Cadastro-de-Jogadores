using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AulaMultiJanelas
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            txtNumeroInscricao.Leave += TxtNumeroInscricao_Leave;

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
            if (!CamposValidos())
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.");
                return;
            }

            if (!int.TryParse(txtIdade.Text.Trim(), out int idade))
            {
                MessageBox.Show("Informe uma idade válida.");
                return;
            }

            Jogadores objJogador = new Jogadores();
            objJogador.Nome = txtNome.Text.Trim();
            objJogador.Idade = idade;
            objJogador.NumeroInscricao = txtNumeroInscricao.Text.Trim();
            objJogador.Modalidade = txtModalidade.Text.Trim();
            objJogador.Clube = txtClube.Text.Trim();

            List<Jogadores> jogadores = CarregarJogadores();
            Jogadores existente = jogadores.FirstOrDefault(j => j.NumeroInscricao == objJogador.NumeroInscricao);
            if (existente != null)
            {
                existente.Nome = objJogador.Nome;
                existente.Idade = objJogador.Idade;
                existente.Modalidade = objJogador.Modalidade;
                existente.Clube = objJogador.Clube;
            }
            else
            {
                jogadores.Add(objJogador);
            }

            SalvarJogadores(jogadores);

            MessageBox.Show("Registro salvo com sucesso!");
            LimparCampos();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string numeroInscricao = txtNumeroInscricao.Text.Trim();
            if (string.IsNullOrWhiteSpace(numeroInscricao))
            {
                MessageBox.Show("Informe o número de inscrição para excluir.");
                return;
            }

            List<Jogadores> jogadores = CarregarJogadores();
            Jogadores jogador = jogadores.FirstOrDefault(j => j.NumeroInscricao == numeroInscricao);
            if (jogador == null)
            {
                MessageBox.Show("Jogador não encontrado.");
                return;
            }

            if (MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                jogadores.Remove(jogador);
                SalvarJogadores(jogadores);
                MessageBox.Show("Registro excluído com sucesso!");
                LimparCampos();
            }
        }

        private void TxtNumeroInscricao_Leave(object sender, EventArgs e)
        {
            string numeroInscricao = txtNumeroInscricao.Text.Trim();
            if (string.IsNullOrWhiteSpace(numeroInscricao))
            {
                return;
            }

            List<Jogadores> jogadores = CarregarJogadores();
            Jogadores jogador = jogadores.FirstOrDefault(j => j.NumeroInscricao == numeroInscricao);
            if (jogador == null)
            {
                return;
            }

            txtNome.Text = jogador.Nome;
            txtIdade.Text = jogador.Idade.ToString();
            txtModalidade.Text = jogador.Modalidade;
            txtClube.Text = jogador.Clube;
        }

        private static string ObterCaminhoArquivo()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return Path.Combine(path, "jogadores.xml");
        }

        private static List<Jogadores> CarregarJogadores()
        {
            string arquivo = ObterCaminhoArquivo();
            if (!File.Exists(arquivo))
            {
                return new List<Jogadores>();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Jogadores>));
            using FileStream arquivoXml = File.OpenRead(arquivo);
            return (List<Jogadores>)serializer.Deserialize(arquivoXml);
        }

        private static void SalvarJogadores(List<Jogadores> jogadores)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Jogadores>));
            using FileStream arquivoXml = File.Create(ObterCaminhoArquivo());
            serializer.Serialize(arquivoXml, jogadores);
        }

        private bool CamposValidos()
        {
            return !string.IsNullOrWhiteSpace(txtNome.Text)
                && !string.IsNullOrWhiteSpace(txtIdade.Text)
                && !string.IsNullOrWhiteSpace(txtModalidade.Text)
                && !string.IsNullOrWhiteSpace(txtNumeroInscricao.Text)
                && !string.IsNullOrWhiteSpace(txtClube.Text);
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtModalidade.Clear();
            txtNumeroInscricao.Clear();
            txtClube.Clear();
            txtNome.Focus();
        }
    }
}
