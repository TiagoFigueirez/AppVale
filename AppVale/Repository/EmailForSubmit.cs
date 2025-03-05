using System;
using System.Data;
using AppVale.Repository.Interface;

namespace AppVale.Repository
{
    public class EmailForSubmit : CrudBase, IEMailForSubmit
    {
        public bool FormatCreate(string email, string password, string stmpAdress, string portNumber)
        {
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\EmailForSubmit.txt";
            var dataFormat = $"{email}_{password}_{stmpAdress}_{portNumber}";

            var getMail = Get(filePath);

            if (getMail.Length > 0)
            {
                return false;
            }
            else
            {
                bool IsCreateSucess = Create(dataFormat, filePath);

                return IsCreateSucess;
            }
        }

        public DataTable GetEspecific(string filePath)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("E-mail");
            dataTable.Columns.Add("Senha");
            dataTable.Columns.Add("Endereço Smtp");
            dataTable.Columns.Add("Porta");

            string[] lines = Get(filePath);
            string[] eMailSubmit = lines.Length > 0 ? lines[0].Split('_') : Array.Empty<string>();

            if (eMailSubmit.Length > 0)
            {
                dataTable.Rows.Add(eMailSubmit[0], eMailSubmit[1] ,eMailSubmit[2], eMailSubmit[3]);
            }
            
            return dataTable;
            
        }
    }
}
