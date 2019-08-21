using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingControlWebMvc.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public string Periodo { get; set; }
        //public Veiculo Veiculo { get; set; }

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

        List<Aluno> alunos = new List<Aluno>();

            Veiculo padrao = new Veiculo(null, null, null);
            Veiculo v;

            //sintaxe de iniciação automática. Sem construtor
            alunos.Add(new Aluno { Nome = "Elton", CPF = "08251920485", Matricula = "2009108453", Curso = "Engenharia", Periodo = "3º", Veiculo = v = new Veiculo("PFX5107", "FORD", "FIESTA") });
            alunos.Add(new Aluno { Nome = "Everton", CPF = "12345678900", Matricula = "2003504984", Curso = "Programação", Periodo = "8º", Veiculo = padrao });
            alunos.Add(new Aluno { Nome = "Amanda", CPF = "10333445368", Matricula = "2009108459", Curso = "Contabilidade", Periodo = "1º", Veiculo = padrao });            

            //alunos.Add(new Aluno("Elton", "08251920485", "2009108453", "Programacao", "1º", padrao));            

            return View(alunos);
            //NÃO PODE ESQUECER DE RETORNAR A LISTA! OU A PÁGINA NÃO FUNCIONA!


        */
    }
}
