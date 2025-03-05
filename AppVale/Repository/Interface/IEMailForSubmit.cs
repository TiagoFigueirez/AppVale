using System.Data;

namespace AppVale.Repository.Interface
{
    public interface IEMailForSubmit : ICrudBase
    {
        bool FormatCreate(string email, string password, string stmpAdress, string portNumber);
        DataTable GetEspecific(string filePath);
    }
}
