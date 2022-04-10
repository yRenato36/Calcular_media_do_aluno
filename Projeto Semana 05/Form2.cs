using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Semana_05
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();

        }

        private void btMedia_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(text1.Text);
            double nota2 = Convert.ToDouble(text2.Text);
            double nota3 = Convert.ToDouble(text3.Text);
            double media = (nota1 + nota2 + nota3) / 3;
            
            resultMedia.Text = "Sua média é: " + (media.ToString("F"));
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            text1.Text = " ";
            text2.Text = " ";
            text3.Text = " ";
            resultMedia.Text = "Seu média aparecerá aqui: ";
            resultAluno.Text = "Situação do aluno: ";
        }

        private void btAnalizar_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(text1.Text);
            double nota2 = Convert.ToDouble(text2.Text);
            double nota3 = Convert.ToDouble(text3.Text);
            double media = (nota1 + nota2 + nota3) / 3;

            if (media < 0 || media > 10)
            {
                resultAluno.Text = "Algum dos números digitados são maiores/menores que 10";
            }
            else
            { 
                if (media >= 0 && media <= 5.9)
                {
                    resultAluno.Text = "Aluno(a) Reprovado(a)";
                }
                else
                {
                    resultAluno.Text = "Aluno(a) Aprovado(a)";
                }
            }
        }

        private void resultMedia_Click(object sender, EventArgs e)
        {

        }

        private void resultAluno_Click(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
