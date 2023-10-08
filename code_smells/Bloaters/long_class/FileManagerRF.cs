using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Bloaters.long_class
{
    public class FileReader
    {
        public void ReadFile(string filePath)
        {
            // Lógica para leer un archivo
        }
    }

    public class FileWriter
    {
        public void WriteFile(string filePath, string content)
        {
            // Lógica para escribir en un archivo
        }
    }

    public class FileCompressor
    {
        public void CompressFile(string filePath)
        {
            // Lógica para comprimir un archivo
        }
    }

    public class FileEncryptor
    {
        public void EncryptFile(string filePath)
        {
            // Lógica para encriptar un archivo
        }
    }

    public class EmailSender
    {
        public void SendFileByEmail(string filePath, string recipient)
        {
            // Lógica para enviar un archivo por correo electrónico
        }
    }

    public class FileUploader
    {
        public void UploadFileToServer(string filePath, string serverUrl)
        {
            // Lógica para subir un archivo a un servidor
        }
    }

}
