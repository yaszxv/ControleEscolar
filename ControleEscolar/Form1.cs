using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEscolar
{
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           // Criando as variaveis
           // Boa pratica criar as variaveis no começo do codigo
           decimal nota1;
           decimal nota2;
           decimal nota3;
           decimal nota4;
           decimal media1, media2, mediaFinal; 
           // O C# é case sensitive, faz diferenciação entre maiúsculo e minúsculo
           // Parse = Transformar, neste caso em decimal 
            nota1 = decimal.Parse(txtN1.Text);
            nota2 = decimal.Parse(txtN2.Text);
            nota3 = decimal.Parse(txtN3.Text); 
            nota4 = decimal.Parse(txtN4.Text);
           // Fazer validação dos números
           /* Para tomar uma decisão usamos o comando if (se)
           // If é sempre comparação
           //tipos de comparações:
           // == igualdade
           // >= 
           // <=
           // >
           // <
           // != diferente
           // || (o nome deste símbolo é pipe) significa OU
           && significa E 
           */

            if (nota1 > 10 || nota1 < 0) {
                txtN1.Focus();
                // Mostrar mensagem para o usuário
                MessageBox.Show("A nota 1 está errada, notas entre 0 e 10", "Erro Nota 1",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Finalize o código, quando aparece o return o código é finalizado.
                return;
            }
            if (nota2 > 10 || nota2 < 0)
            {
                txtN1.Focus();
                // Mostrar mensagem para o usuário
                MessageBox.Show("A nota 2 está errada, notas entre 0 e 10", "Erro Nota 2",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Finalize o código, quando aparece o return o código é finalizado.
                return;
            }
            if (nota3 > 10 || nota3 < 0)
            {
                txtN1.Focus();
                // Mostrar mensagem para o usuário
                MessageBox.Show("A nota 3 está errada, notas entre 0 e 10", "Erro Nota 3",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Finalize o código, quando aparece o return o código é finalizado.
                return;
            }
            if (nota4 > 10 || nota4 < 0)
            {
                txtN1.Focus();
                // Mostrar mensagem para o usuário
                MessageBox.Show("A nota 4 está errada, notas entre 0 e 10", "Erro Nota 4",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Finalize o código, quando aparece o return o código é finalizado.
                return;
            }
            // Cálculo das médias
            media1 = ((nota1 * 4) + (nota2 * 6)) / 10;
            media2 = ((nota3 * 4) + (nota4 * 6)) / 10;
            mediaFinal = (media1 + media2) / 2;
           // Mostrar as medidas
           // .ToString() = Transformar em texto, isto é um método/função
           // Como saber se é um método, ícone do cubo roxo
            txtBim1.Text = media1.ToString();
            txtBim2.Text = media2.ToString();
            txtMedia.Text = mediaFinal.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
