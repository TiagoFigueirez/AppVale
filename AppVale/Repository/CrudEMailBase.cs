using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AppVale.Repository
{
    public abstract class CrudEMailBase
    {
        public abstract bool CreateEMail(string email, string senha = null, string stmpAdress = null, int portNumber = 0);

        public List<string> GetEmails(string filePath)
        {
            
            List<string> emails = new List<string>();

            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while((line = sr.ReadLine()) != null)
                        {
                            emails.Add(line);
                        }

                        return emails;
                    }
                }
                catch
                {
                    return emails = null;
                }
            }
            else
            {
                return emails =  null;
            }
        }

        public  bool DeleteEMail(string filePath, string emailDelete)
        {
            try
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();

                bool removed = lines.Remove(emailDelete);

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
