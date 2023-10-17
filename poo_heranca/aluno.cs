using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_heranca
{
    public class aluno : pessoa
    {
        public int num_matricula;
        public string curso;

        public void Exibir()
        {
            System.Windows.Forms.MessageBox.Show("Nome: " + nome + "\nIdade: " + idade.ToString() + "\nMatrícula: " + num_matricula.ToString() + "\nCurso: " + curso);
        }
    }

}
