using AppVale.Repository.Interface;
using System.Data;

namespace AppVale.Repository
{
    public class Vendedor : CrudBase, IFormatData
    {
        public DataTable GetEspecific(string filePath)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Vendedor");
           

            string[] lines = Get(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                dataTable.Rows.Add(lines[i].Trim());
            }

            return dataTable;
        }
    }
}
