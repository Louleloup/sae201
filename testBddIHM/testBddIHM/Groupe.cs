using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace testBddIHM
{
    public class Groupe : Crud<Groupe>
    {
        public long nGroupe
        {
            get; set;
        }
        public string libelleGroupe
        {
            get; set;
        }
        public Groupe()
        {
        }
        public void Create()
        {
            throw new NotImplementedException();
        }
        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Groupe> FindAll()
        {
            List<Groupe> listeGroupes = new List<Groupe>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select * from Groupe;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Groupe unGroupe = new Groupe();
                            unGroupe.nGroupe = reader.GetInt64(0);
                            unGroupe.libelleGroupe = reader.GetString(1);
                            listeGroupes.Add(unGroupe);
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("No rows found.", "Important Message");
                    }
                    reader.Close();
                    access.closeConnection();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Important Message");
            }
            return listeGroupes;
        }

        public List<Groupe> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}
