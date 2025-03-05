using System.Data;

namespace AppVale.Repository.Interface
{
    public interface IFormatData
    {
        DataTable GetEspecific(string filePath);
    }
}
