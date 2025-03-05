using System.Data;

namespace AppVale.Repository.Interface
{
    public interface ICrudBase
    {
        bool Create(string data, string filePath);
        string[] Get(string filePath);
        bool Delete(string filePath, string dataDelete);
    }
}
