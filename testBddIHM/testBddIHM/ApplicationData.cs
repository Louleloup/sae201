using System;
using System.Collections.Generic;
using System.Text;

namespace testBddIHM
{
    public class ApplicationData
    {
        public static List<Groupe> listeGroupes
        {
            get;
            set;
        }
        public static List<CorpDArmee> listeCorpDArmee
        {
            get;
            set;
        }
        public static List<Division> listeDivision
        {
            get;
            set;
        }
        public static List<Mission> listeMission
        {
            get;
            set;
        }
        public static List<Affectation> listeAffectation
        {
            get;
            set;
        }
        public static void loadApplicationData()
        {
            Groupe unGroupe = new Groupe();
            CorpDArmee unCorpDArmee = new CorpDArmee();
            Division unDivision = new Division();
            Mission uneMission = new Mission();
            Affectation uneAffectation = new Affectation();

            listeGroupes = unGroupe.FindAll();
            listeCorpDArmee = unCorpDArmee.FindAll();
            listeDivision = unDivision.FindAll();
            listeMission = uneMission.FindAll();
            listeAffectation = uneAffectation.FindAll();

        }
    }
}
