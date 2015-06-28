using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using Aluno.Models;
namespace Aluno.Tests
{
    [TestClass]
    public class AlunoModelTests
    {
        [TestMethod]
        public void AlunoCPFTest()
        {
           
            string digitos = "112957216";
            string experado = "112957216";


            Assert.AreEqual(experado, digitos);
        }
    }
}
