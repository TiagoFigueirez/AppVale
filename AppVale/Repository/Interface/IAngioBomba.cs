using System.Data;

namespace AppVale.Repository.Interface
{
    public interface IAngioBomba
    {
        bool CreateFormat(string name, string lote);
        DataTable GetEspecific(string filePath);
    }
}
