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
       4 - Depois da página funcionando, apagou o AlunosControllers e a pasta de Alunos em Views e criou um arquivo no Controllers clicando em add- New Scaffolded item.
       5 - Escolhe a opcção MVC com Entity Framework e depois escolque qual o model que vai ficar conectado e segue os passos. Para que ele não dê erro é necessário escrever [Key] na sua classe principal ou apenas criar um inteiro com o no Id.
       6 - Em appsettings.json precisa modificar o caminho da conexão com o mysql
       7 - Em Startup.cs é necessário fazer uma modificação em no método ConfigureServices.
       8 - Após feito o passo anterior o nome UseMySql ainda continua em vermelho, pois falta incluir a dependência com o MySql. 
            Clica na aba aqui embaixo em "Package Manager Console" e digita "Install-Package Pomelo.EntityFrameworkCore.MySql.Signed -Version 2.1.0" . É bom sempre confirmar a última versão se não da erro.
       9 - Iniciar o serviço Mysql entrando ferramentas administrativas -> MySql e executar (caso ainda não esteja nesse todo processo)
       10 - Novamente em Package Manager Console digita Add-Migration Projeto1 (o nome Projeto1 poderia ser qualquer nome). Após isso será criada uma pasta com o nome Migrations e um arquivo script.cs com a data e hora que foi criado (baseado em outro fuso horario)
       11 - Para executar a migration e criar a base de dados no servidor SQL digita Update-Database

    */
}
