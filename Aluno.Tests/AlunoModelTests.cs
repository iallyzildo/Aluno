using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using Aluno.Models;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;
using Aluno.Entity;
using Aluno.Controllers;

namespace Aluno.Tests
{
    [TestClass]
    public class AlunoModelTests
    {

        private AlunoModel alunoModel;

        [TestInitialize]
        public void IniciarTestes()
        {
            alunoModel = new AlunoModel();
        }

        [TestCleanup]
        public void FinalizarTestes()
        {
            Debug.WriteLine("Teste finalizado");
        }




        [TestMethod]
        public void TestarDigitosVerificadoresCpf()
        {          
            string digitos = "112957216";
            string experado = "11";
            string validacao;
            validacao = alunoModel.calcularDigitosVerificadoresCPF(digitos);
            Assert.AreEqual(experado, validacao);
        }
        //[TestMethod]
        //public void PegarAluno1_DeverRetornarAluno1()
        //{
        //    var result = alunoModel.obterAluno(1);
        //    Assert.AreEqual(alunoModel.obterAluno(1), result);
        //}
        //[TestMethod]
        //public void PegarAluno_RetornarNomeCorreto()
        //{
        //    var result = alunoModel.obterAluno(1);
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(alunoModel.obterAluno(1).Nome, result.Nome);
        //}
           
    }
}
