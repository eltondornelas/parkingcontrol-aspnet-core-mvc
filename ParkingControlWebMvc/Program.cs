using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ParkingControlWebMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        //ctrl+shift+b para compilar apenas na primeira vez que o projeto é criado.

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }

    /* 1- Cria as classes na pasta Models, depois cria arquivos "Controllers" com o mesmo nome da classe (aluno nesse caso) criada em models
            só que no plural seguida do nome controllers.
       2 - Cria uma pasta com o nome da classe Alunos (plural para ficar identica à que está em Controllers), depois clica nessa pasta e cria uma View com o nome Index.
       3 - Depois clica com o botão direito em Alunos - Add - View -> troca o nome para Index (vai estar como view), no template escolhe "list" e em Model Class clica em aluno.
    */
}
