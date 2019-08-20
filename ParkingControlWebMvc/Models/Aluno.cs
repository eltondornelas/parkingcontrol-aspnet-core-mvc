using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingControlWebMvc.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public string Periodo { get; set; }
        public Veiculo Veiculo { get; set; }        
        
        /*
        public Aluno(string nome, string cpf, string matricula, string curso, string periodo, Veiculo veiculo)        
        {
            Nome = nome;
            CPF = cpf;
            Matricula = matricula;
            Curso = curso;
            Periodo = periodo;
            //Veiculo = veiculo;
        }
        */
    }
}
