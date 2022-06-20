using Microsoft.VisualStudio.TestTools.UnitTesting;
using testBddIHM;
using System;
using System.Collections.Generic;
using System.Text;

namespace testBddIHM.Tests
{

    [TestClass()]
    public class AffectationTests
    {
        [TestMethod()]
        public void AffectationTest()
        {

        }

        [TestMethod()]

        [ExpectedException(typeof(ArgumentException),
            "date inférieure à celle d'aujourd'hui,cela va lancer une exception")]
        public void AffectationTest1()
        {
            Affectation affecationMauvaiseDate = new Affectation(10, 11, new DateTime(2015, 8, 12), " ");

        }



        [TestMethod()]
        public void CreateTest()
        {
            //Arrange

            Affectation testCreate = new Affectation(6, 7, new DateTime(2024, 12, 3), " ");


            //Act

            testCreate.Create();

            //Assert
            ApplicationData.listeAffectation.Find(D => D.NumeroD == 6 && D.NumeroM == 7 && D.Date == new DateTime(2024, 12, 3) && D.Commentaire == " ");


        }

        [TestMethod()]
        public void ReadTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            //Arrange
            Affectation testDelete = new Affectation(6, 7, new DateTime(2024, 12, 3), " ");

            //Act
            ApplicationData.listeAffectation.Add(testDelete);

            ApplicationData.listeAffectation.Remove(testDelete);

            //Assert
            var resultat = ApplicationData.listeAffectation.Find(D => D.NumeroD == 6 && D.NumeroM == 7 && D.Date == new DateTime(2024, 12, 3) && D.Commentaire == " ");
            Assert.IsNull(resultat);
        }

        [TestMethod()]
        public void FindAllTest()
        {
            //Arrange

            Affectation uneAffectation = new Affectation();

            //Act
            ApplicationData.listeAffectation = uneAffectation.FindAll();

            //Assert
            int nombreAffectation = ApplicationData.listeAffectation.Count;
            Assert.AreEqual(nombreAffectation, 5);
        }

        [TestMethod()]
        public void FindBySelectionTest()
        {
            Assert.Fail();
        }
    }
}