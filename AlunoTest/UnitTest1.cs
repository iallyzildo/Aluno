using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aluno.Controllers;


namespace AlunoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Somando9e1Retorna10()
        {
            var alunoController = new AlunoController();
            var retorno = alunoController.Soma(9, 1);

            Assert.AreEqual(10, retorno);
        }
    }
}
