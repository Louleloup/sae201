/***********************************************************************
 * Module:  Division.cs
 * Author:  meriotl
 * Purpose: Definition of the Class Division
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace testBddIHM
{
    public class Division : Crud<Division>
    {
        public void Create()
        {
        }

        public void Read()
        {
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }

        public List<Division> FindAll()
        {
            List<Division> listeDivision = new List<Division>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select * from DIVISION;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Division uneDivision = new Division();
                            uneDivision.NumeroDivision = (int)reader.GetInt32(0);
                            uneDivision.LibelleDivision = reader.GetString(2);
                            listeDivision.Add(uneDivision);
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
                System.Windows.MessageBox.Show("FindAll Division : " + ex.Message, "Important Message");
            }
            return listeDivision;

        }

        public List<Division> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        public Division()
        {
            // TODO: implement
        }

        public Division(int numD)
        {
            this.NumeroDivision = numD;
        }

        ~Division()
        {
            // TODO: implement
        }

        public CorpDArmee[] categorise;
        public Mission[] est_compose_de;

        public int NumeroDivision
        {
            get;
            set;
        }

        public String LibelleDivision
        {
            get;
            set;
        }
    }
}