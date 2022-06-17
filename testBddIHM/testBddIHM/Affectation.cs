using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace testBddIHM
{
    /// <summary>
    /// Permet d'accéder, de modifier, et de supprimer des affectations présentes dans la base de données.
    /// </summary>
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

        /// <summary>
        /// Ajoute les données à la base de donnée
        /// </summary>
        /// <exception cref="System.Exception">Déclenchée si la connexion, l'écriture en base ou la déconnexion échouent.</exception> 
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
                System.Windows.MessageBox.Show(ex.Message, " Important Message");
            }
        }

        public void Read()
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.openConnection())
                {
                    access.getData($"SELECT FROM AFFECTE_A WHERE NUMEROD = {this.NumeroD} AND NUMEROM = {this.NumeroM} AND DATE = '{this.Date.ToShortDateString()}' AND COMMENTAIRE = '{this.Commentaire}'");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, " Important Message Affectation");
            }
        }
        public void Update()
        {
        }

        /// <summary>
        /// Modifie des données par d'autres
        /// </summary>
        /// <param name="numD">Paramètre permettant de récupérer le numéro de Division concernant une affectation et de modifier des données dans la base de donnée.</param>
        /// <param name="numM">Paramètre permettant de récupérer le numéro de Mission concernant une affectation et de modifier des données dans la base de donnée.</param>
        /// <param name="date">Paramètre permettant de récupérer la date concernant une affectation et de modifier des données dans la base de donnée.</param>
        /// <param name="commentaire">Paramètre permettant de récupérer le commentaire concernant une affectation et de modifier des données dans la base de donnée.</param>
        /// <exception cref="System.Exception">Déclenchée si la connexion, la modification en base ou la déconnexion échouent.</exception> 
        public void Update(int numD, int numM, DateTime date, string commentaire)
        {
            DataAccess access = new DataAccess();
            try
            {
                if (access.openConnection())
                {
                    access.getData($"UPDATE AFFECTE_A SET NUMEROD = '{numD}', NUMEROM = '{numM}', DATE = '{date.ToShortDateString()}', COMMENTAIRE = '{commentaire}' WHERE NUMEROD = {this.NumeroD} AND NUMEROM = {this.NumeroM} AND DATE = '{this.Date.ToShortDateString()}' AND COMMENTAIRE = '{this.Commentaire}'");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, " Important Message Affectation");
            }
        }

        /// <summary>
        /// Supprime une affectation
        /// </summary>
        /// <exception cref="System.Exception">Déclenchée si la connexion, la suppression en base ou la déconnexion échouent.</exception> 
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
                System.Windows.MessageBox.Show(ex.Message, " Important Message");
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
