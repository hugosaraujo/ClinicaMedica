using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Paciente
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
        public double peso;

        public string InfoPaciente()
        {
            return $"Nome: {nome} \n" +
                   $"Idade: {idade} anos \n" +
                   $"Altura: {altura} m \n" +
                   $"Peso: {peso} kg \n";
        }
    }
}
