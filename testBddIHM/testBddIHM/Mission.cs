/***********************************************************************
 * Module:  Mission.cs
 * Author:  landrece
 * Purpose: Definition of the Class Mission
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace testBddIHM
{
    public class Mission : Crud<Mission>
    {
        public void Create()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.openConnection())
                {
                    access.setData($"INSERT INTO AFFECTE_A(NUMEROM) VALUES('{this.NumeroMission}')");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("NumeroMission : " + ex.Message, " Important Message");
            }
        }

        public void Read()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.openConnection())
                {
                    access.setData($"SELECT * FROM AFFECTE_A(NUMEROM) VALUES('{this.NumeroMission}')");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("NumeroMission : " + ex.Message, " Important Message");
            }
        }

        public void Update()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.openConnection())
                {
                    access.setData($"UPDATE AFFECTE_A(NUMEROM) SET NUMEROM = '{this.NumeroMission}')");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("NumeroMission : " + ex.Message, " Important Message");
            }
        }

        public void Delete()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.openConnection())
                {
                    access.setData($"DELETE FROM AFFECTE_A(NUMEROM) where NUMEROM = '{this.NumeroMission}')");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("NumeroMission : " + ex.Message, " Important Message");
            }
        }

        public List<Mission> FindAll()
        {
            List<Mission> listeMission = new List<Mission>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select * from MISSION;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Mission uneMission = new Mission();
                            uneMission.NumeroMission = (int)reader.GetInt32(0);
                            uneMission.LibelleMission = reader.GetString(1);
                            uneMission.Commentaire = reader.GetString(2);
                            listeMission.Add(uneMission);
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
                System.Windows.MessageBox.Show("FindAll Mission : " + ex.Message, "Important Message");
            }
            return listeMission;
        }

        public List<Mission> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        public Mission()
        {
            // TODO: implement
        }

        ~Mission()
        {
            // TODO: implement
        }

        public Division[] compose;

        public int NumeroMission
        {
            get;
            set;
        }

        public String LibelleMission
        {
            get;
            set;
        }

        public String Commentaire
        {
            get;
            set;
        }

    }
}