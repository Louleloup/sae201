/***********************************************************************
 * Module:  CorpDArmee.cs
 * Author:  meriotl
 * Purpose: Definition of the Class CorpDArmee
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace testBddIHM
{
    public class CorpDArmee : Crud<CorpDArmee>
    {
        public void Create()
        {
            // TODO: implement
        }

        public void Read()
        {
            // TODO: implement
        }

        public void Update()
        {
            // TODO: implement
        }

        public void Delete()
        {
            // TODO: implement
        }
        public List<CorpDArmee> FindAll()
        {
            List<CorpDArmee> listeCorpDArmee = new List<CorpDArmee>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select * from CORPS_D_ARMEE;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CorpDArmee unCorpDArmee = new CorpDArmee();
                            unCorpDArmee.numeroCA = (int)reader.GetInt32(0);
                            unCorpDArmee.libelleCA = reader.GetString(1);
                            listeCorpDArmee.Add(unCorpDArmee);
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
                System.Windows.MessageBox.Show("FindAll Corp d'Armée : " + ex.Message, "Important Message");
            }
            return listeCorpDArmee;
        }

        public List<CorpDArmee> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        public CorpDArmee()
        {
            // TODO: implement
        }

        ~CorpDArmee()
        {
            // TODO: implement
        }

        public Division est_categorise_par;

        public int numeroCA
        {
            get;
            set;
        }

        public String libelleCA
        {
            get;
            set;
        }

    }
}