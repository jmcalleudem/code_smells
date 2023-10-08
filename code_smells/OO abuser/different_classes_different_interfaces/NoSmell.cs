using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.different_classes_different_interfaces
{
    // Interfaz común para todas las conexiones de bases de datos
    public interface IDatabaseConnection
    {
        void Connect();
        void ExecuteCommand(string sqlCommandOrNoSqlCommand);
        void Disconnect();
    }

    // Clase que representa una conexión SQL
    public class SqlConnectionRF : IDatabaseConnection
    {
        public void Connect()
        {
            // Lógica para abrir una conexión SQL
        }

        public void ExecuteCommand(string sqlCommandOrNoSqlCommand)
        {
            // Lógica para ejecutar un comando SQL
        }

        public void Disconnect()
        {
            // Lógica para cerrar una conexión SQL
        }
    }

    // Clase que representa una conexión NoSQL
    public class NoSqlConnectionRF : IDatabaseConnection
    {
        public void Connect()
        {
            // Lógica para conectar a una base de datos NoSQL
        }

        public void ExecuteCommand(string sqlCommandOrNoSqlCommand)
        {
            // Lógica para ejecutar un comando NoSQL
        }

        public void Disconnect()
        {
            // Lógica para desconectar de una base de datos NoSQL
        }
    }

}
