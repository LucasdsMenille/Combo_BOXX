using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_BOXX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Adiciona os itens manualmente no ComboBox
            cboLista.Items.Add(txtTexto.Text);
            //Exibe a quantidade de itens do ComboBox
            lblQtde.Text = cboLista.Items.Count.ToString();
            //Limpa a caixa de texto
            txtTexto.Clear();
            //Move o foco para caixa de texto
            txtTexto.Select();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ativa a propriedade para ordenar a lista no combo
            cboLista.Sorted= true;

        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            //Verificar se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                //remove o item selecionado do combo
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);
                //Exibe a quantidade de intens do ComboBox
                lblQtde.Text = cboLista.Items.Count.ToString();
                //limpa o texto da combo
                cboLista.ResetText();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //Verifica se existe um item selecionado no combo
            if(cboLista.SelectedIndex != -1)
            {
                //Exibe o conteudo ( texto do combo )[]
                txtConteudo.Text = cboLista.SelectedItem.ToString();
                //Exibe o indice (posição) do item no combo
                txtIndice.Text = cboLista.SelectedItem.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
