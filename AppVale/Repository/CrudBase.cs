using AppVale.Repository.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AppVale.Repository
{
    public abstract class CrudBase : ICrudBase
    {
        public bool Create(string data, string filePath)
        {
            try
            {

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                   sw.WriteLine(data);
                }

;               return true;
            }
            catch
            {
                return false;
            }
        }

        public string[] Get(string filePath)
        {

            if (File.Exists(filePath))
            {
                try
                {
                    string[] linhas = File.ReadAllLines(filePath);
                     
                    if (linhas.Length > 0)
                    {
                        return linhas;
                    }
                    else
                    {
                        return Array.Empty<string>();
                    }
                
                }
                catch
                {
                    return Array.Empty<string>();
                }
            }
            else
            {
                return Array.Empty<string>();
            }
        }

        public bool Delete(string filePath, string dataDelete)
        {
            try
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                bool removed = lines.Remove(dataDelete);

                if (removed)
                {
                    File.WriteAllLines(filePath, lines);
                }
                else
                {
                    return removed;
                }
                return removed;
            }
            catch
            {
                return false;
            }

        }

    }
}
