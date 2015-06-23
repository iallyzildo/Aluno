using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aluno.Controllers;

namespace Alunoteste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var soma = new AlunoController();
            var retorno = soma.Soma(9, 1);


            Assert.AreEqual(10, retorno);
        }
    }
}
