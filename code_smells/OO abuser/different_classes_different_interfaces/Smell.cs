using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.different_classes_different_interfaces
{
    // Interfaz para la conexión a bases de datos SQL
    public interface ISqlConnection
    {
        void Open();
        void ExecuteSqlCommand(string sqlCommand);
        void Close();
    }

    // Interfaz para la conexión a bases de datos NoSQL
    public interface INoSqlConnection
    {
        void Connect();
        void ExecuteNoSqlCommand(string noSqlCommand);
        void Disconnect();
    }

    // Clase que representa una conexión SQL
    public class SqlConnection : ISqlConnection
    {
        public void Open()
        {
            // Lógica para abrir una conexión SQL
        }

        public void ExecuteSqlCommand(string sqlCommand)
        {
            // Lógica para ejecutar un comando SQL
        }

        public void Close()
        {
            // Lógica para cerrar una conexión SQL
        }
    }

    // Clase que representa una conexión NoSQL
    public class NoSqlConnection : INoSqlConnection
    {
        public void Connect()
        {
            // Lógica para conectar a una base de datos NoSQL
        }

        public void ExecuteNoSqlCommand(string noSqlCommand)
        {
            // Lógica para ejecutar un comando NoSQL
        }

        public void Disconnect()
        {
            // Lógica para desconectar de una base de datos NoSQL
        }
    }

}
