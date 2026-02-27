using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class frmCadastro : Form
    {
        List<Pessoa> pessoas;
        public frmCadastro()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();
            cboEstadoCivil.Items.Add("Solteiro");
            cboEstadoCivil.Items.Add("Casado");
            cboEstadoCivil.Items.Add("Divorciado");
            cboEstadoCivil.Items.Add("Viúvo");
            cboEstadoCivil.Items.Add("Separado");

            cboEstadoCivil.SelectedIndex = 0;
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {

        }

        private void cmdCadastro_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach(Pessoa pessoa in pessoas) {
                if (pessoa.Nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }
             
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o nome!");
                txtNome.Focus();
                return;
            }

            if (txtTelefone.Text == "")
            {
                MessageBox.Show("Informe o telefone!");
                txtTelefone.Focus();
                return;
            }

            char Genero;

            if (optHomem.Checked)
            {
                Genero = 'H';
            }
            else if (optMulher.Checked)
            {
                Genero = 'M';
            } 
            else if (optNaoBinario.Checked)
            {
                Genero = 'N';
            } 
            else if (optOutro.Checked)
            {
                Genero = 'O';
            } 
            else
            {
                Genero = 'S';
            }

            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.DataNascimento = txtData.Text;
            p.EstadoCivil = cboEstadoCivil.SelectedItem.ToString();
            p.Telefone = txtTelefone.Text;
            p.Genero = Genero;
            p.CasaPropria = chkCasa.Checked;
            p.Veiculo = chkPossuiVeiculo.Checked;
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            lista.Items.Clear();

            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }
    }
}
