using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace testBddIHM
{
    public class Affectation : Crud<Affectation>
    {
        private int numeroD;
        private int numeroM;
        private DateTime date;
        private string commentaire;

        public int NumeroD
        {
            get
            {
                return this.numeroD;
            }

            set
            {
                this.numeroD = value;
            }
        }

        public int NumeroM
        {
            get
            {
                return this.numeroM;
            }

            set
            {
                this.numeroM = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public string Commentaire
        {
            get
            {
                return this.commentaire;
            }

            set
            {
                this.commentaire = value;
            }
        }

        public Affectation()
        {
        }

        public Affectation(int numeroD, int numeroM, DateTime date, string commentaire)
        {
            this.NumeroD = numeroD;
            this.NumeroM = numeroM;
            this.Date = date;
            this.Commentaire = commentaire;
        }

        public void Create()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.openConnection())
                {
                    access.setData($"INSERT INTO AFFECTE_A(NUMEROD, NUMEROM, DATE, COMMENTAIRE) VALUES('{this.NumeroM}', '{this.NumeroD}', '{this.Date}', '{this.Commentaire}')");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("NumeroAffectation : " + ex.Message, " Important Message");
            }
        }

        public void Read()
        {
        }

        public void Update()
        {
            /*DataAccess access = new DataAccess();
            try
            {
                if (access.openConnection())
                {
                    access.getData($"UPDATE AFFECTE_A WHERE NUMEROD = {this.NumeroD} AND NUMEROM = {this.NumeroM} AND DATE = '{this.Date.ToShortDateString()}' AND COMMENTAIRE = '{this.Commentaire}')");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("NumeroDivision : " + ex.Message, " Important Message");
            }*/
        }

        public void Delete()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.openConnection())
                {
                    access.setData($"DELETE FROM AFFECTE_A WHERE NUMEROD = {this.NumeroD} AND NUMEROM = {this.NumeroM} AND DATE = '{this.Date.ToShortDateString()}' AND COMMENTAIRE = '{this.Commentaire}'");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("NumeroAffectation : " + ex.Message, " Important Message");
            }
        }

        public List<Affectation> FindAll()
        {
            List<Affectation> listeAffectation = new List<Affectation>();
            DataAccess access = new DataAccess();
            SqlDataReader reader;
            try
            {
                if (access.openConnection())
                {
                    reader = access.getData("select * from AFFECTE_A;");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Affectation uneAffectation = new Affectation();
                            uneAffectation.NumeroD = (int)reader.GetInt32(0);
                            uneAffectation.NumeroM = (int)reader.GetInt32(1);
                            uneAffectation.Date = reader.GetDateTime(2);
                            uneAffectation.Commentaire = reader.GetString(3);
                            listeAffectation.Add(uneAffectation);
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
                System.Windows.MessageBox.Show("FindAll Affectation : " + ex.Message, "Important Message");
            }
            return listeAffectation;
        }

        public List<Affectation> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}
