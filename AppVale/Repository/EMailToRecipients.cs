using System.Data;

namespace AppVale.Repository.Interface
{
    public class EMailToRecipients : CrudBase, IFormatData
    {
        public DataTable GetEspecific(string filePath)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("E-mail");

            string[] lines = Get(filePath);

            if (lines.Length > 0)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    dataTable.Rows.Add(lines[i]);
                }
            }

            return dataTable;
        }
    }
}
