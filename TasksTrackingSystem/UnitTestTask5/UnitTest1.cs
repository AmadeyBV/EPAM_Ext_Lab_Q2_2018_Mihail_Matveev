using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTS;

namespace UnitTestTask5
{
    [TestClass]
    public class UnitTest1
    {
        #region bool Delete(int id)
        [TestMethod]
        public void UnitTestDelete_LessZero()
        {
            var dataBase = new DataBase();
            var help = dataBase.Delete(-1);

            Assert.AreEqual(false, help);
        }

        [TestMethod]
        public void UnitTestDelete()
        {
            var dataBase = new DataBase();
            var help = dataBase.Delete(3);

            Assert.AreEqual(true, help);
        }

        [TestMethod]
        public void UnitTestDelete_Higher()
        {
            var dataBase = new DataBase();
            var help = dataBase.Delete(10);

            Assert.AreEqual(false, help);
        }
        #endregion

        #region T Get(int id)
        [TestMethod]
        public void UnitTestGet_LessZero()
        {
            var dataBase = new DataBase();
            var help = dataBase.Get(-1);

            Assert.AreEqual(null, help);
        }

        [TestMethod]
        public void UnitTestGet()
        {
            var dataBase = new DataBase();
            var help = dataBase.Get(3);
            var worker = dataBase.list[3];

            Assert.AreEqual(worker, help);
        }

        [TestMethod]
        public void UnitTestGet_Higher()
        {
            var dataBase = new DataBase();
            var help = dataBase.Get(10);

            Assert.AreEqual(null, help);
        }
        #endregion

        #region List<T> GetAll()
        [TestMethod]
        public void UnitTestGetAll()
        {
            var dataBase = new DataBase();
            var help = dataBase.GetAll();

            Assert.AreEqual(dataBase.list, help);
        }
        #endregion

        #region bool Save(T entity)
        [TestMethod]
        public void UnitTestSave_NULL()
        {
            var dataBase = new DataBase();
            var help = dataBase.Save(null);

            Assert.AreEqual(false, help);
        }

        [TestMethod]
        public void UnitTestSave()
        {
            var dataBase = new DataBase();


            var help = dataBase.Save(new Worker());

            Assert.AreEqual(true, help);
        }
        #endregion
    }
}
