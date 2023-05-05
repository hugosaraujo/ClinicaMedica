using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
        public double peso;

        public string InfoPaciente()
        {
            return $"Nome: {this.nome} \n" +
                   $"Idade: {this.idade} anos \n" +
                   $"Altura: {this.altura} m \n" +
                   $"Peso: {this.peso} kg \n";
        }
    }
}
