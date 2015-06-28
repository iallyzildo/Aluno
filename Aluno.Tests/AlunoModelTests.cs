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
            AlunoModel target = new AlunoModel();
            string digitos = "112957216";
            string experado = "19";
            string validacao;
            validacao = target.calcularDigitosVerificadoresCPF(digitos);
            Assert.AreEqual(experado, validacao);
        }
    }
}
