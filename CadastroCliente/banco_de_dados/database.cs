using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CadastroCliente.banco_de_dados
{
    internal class database
    {
    }
}
internal class Database
{
    private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(ConnectionString);
    }
}
