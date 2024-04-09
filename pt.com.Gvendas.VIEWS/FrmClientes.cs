using C__GestaoVendas.pt.com.Gvendas.CONEXAO;
using C__GestaoVendas.pt.com.Gvendas.DAO;
using C__GestaoVendas.pt.com.Gvendas.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__GestaoVendas.pt.com.Gvendas.VIEWS
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            MySqlToDataGrid();
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente();
            novoCliente.Nome = txtNome.Text;
            novoCliente.Nif = int.Parse(txtNif.Text);
            novoCliente.Profissao = txtProfissao.Text;
            novoCliente.Empresa = txtEmpresa.Text;
            novoCliente.Pos = txtPos.Text;
            novoCliente.Email = txtEmail.Text;
            novoCliente.Telem = txtTelem.Text;
            novoCliente.Endereco = txtEndereco.Text;
            novoCliente.Cidade = txtCidade.Text;
            novoCliente.Freguesia = txtFreguesia.Text;
            novoCliente.Pais = txtPais.Text;

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.Registo(novoCliente);
            MySqlToDataGrid();
        }

        private void atualizarBtn_Click(object sender, EventArgs e)
        {
            MySqlToDataGrid();
        }

        private void MySqlToDataGrid()
        {
            ClienteDAO con = new ClienteDAO();
            con.connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string selectAll = "select * FROM tb_clientes;";
            adapter.SelectCommand = new MySqlCommand(selectAll, con.connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            con.connection.Close();
        }

        private void ValidarCampo(TextBox txtBox, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                e.Cancel = true;
                txtBox.Focus();
                errorProvider1.SetError(txtBox, "Insira um valor válido.");
            }
            else
            {
                if (int.TryParse(txtBox.Text, out _))
                {
                    e.Cancel = true;
                    txtBox.Focus();
                    errorProvider1.SetError(txtBox, "Verifique o valor inserido.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtBox, "");
                }
            }
        }

        private void ValidarNif(TextBox txtBox, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                e.Cancel = true;
                txtBox.Focus();
                errorProvider1.SetError(txtBox, "Insira um valor válido.");
            }
            else
            {
                if (!int.TryParse(txtBox.Text, out _))
                {
                    e.Cancel = true;
                    txtBox.Focus();
                    errorProvider1.SetError(txtBox, "O valor inserido tem de ser numérico.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtBox, "");
                }
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtNome, e);
        }

        private void txtNif_Validating(object sender, CancelEventArgs e)
        {
            ValidarNif(txtNif, e);
        }

        private void txtProfissao_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtProfissao, e);
        }

        private void txtEmpresa_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtEmpresa, e);
        }

        private void txtEndereco_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtEndereco, e);
        }

        private void txtPos_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtPos, e);
        }

        private void txtPais_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtPais, e);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtEmail, e);
        }

        private void txtTelem_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtTelem, e);
        }

        private void txtCidade_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtCidade, e);
        }

        private void txtFreguesia_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampo(txtFreguesia, e);
        }

        private void filtrarBTn_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[0].HeaderText.ToString() + " LIKE '%" + txtSearchNome.Text + "%'";
            dataGridView1.DataSource = bs;
        }
    }
}
