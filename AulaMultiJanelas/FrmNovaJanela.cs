using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaMultiJanelas
{
    public partial class FrmNovaJanela : Form
    {
        BindingList<Jogadores> jogadores = new BindingList<Jogadores>
        {
            new() { Nome = "Carlos", Idade = 25, Modalidade = "Futebol", NumeroInscricao = "12345", Clube = "ABC" },
            new() { Nome = "Ana", Idade = 22, Modalidade = "Vôlei", NumeroInscricao = "67890", Clube = "Cruzeiro" },
            new() { Nome = "Marcos", Idade = 28, Modalidade = "Natação", NumeroInscricao = "54321", Clube = "Sharknado" },
            new() { Nome = "Beatriz", Idade = 24, Modalidade = "Basquete", NumeroInscricao = "98765", Clube = "Lakers" }
        };
        public FrmNovaJanela()
        {
            InitializeComponent();
            dataGridView1.DataSource = jogadores;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
