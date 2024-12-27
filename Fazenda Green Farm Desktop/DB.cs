using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Fazenda4
{
    internal class DB
    {
        private SqlConnection cn = new SqlConnection( ConfigurationManager.ConnectionStrings["MinhaConexaoSql"].ConnectionString);
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;


        public SqlConnection Connection
        {
            get { return cn; }
        }

        //abrir conexão
        public void OpenConnection()
        {
            try { 
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Estamos enfrentando problemas com nossos servidores, por favor tente mais tarde.");
            }
        }
        //Fechar conexão
        public void CloseConnection()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        //Leitor de comandos SQL
        public SqlDataReader ExecuteReader(string query)
        {
            SqlCommand cm = new SqlCommand(query, cn);
            OpenConnection();
            return cm.ExecuteReader();
        }
    }
}
