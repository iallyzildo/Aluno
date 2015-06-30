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
            string esperado = "19";
            string validacao;
            validacao = alunoModel.calcularDigitosVerificadoresCPF(digitos);
            Assert.AreEqual(esperado, validacao);
        }
        [TestMethod]
        public void Retornar10quandoSomar9e1()
        {
            int esperado = 10;
            var retorno = alunoModel.Soma(9,1);
            Assert.AreEqual(esperado, retorno);
        }
        [TestMethod]
        public void Retornar5quandoDividir10por2()
        {
            int esperado = 5;
            var retorno = alunoModel.Divisao(10, 2);
            Assert.AreEqual(esperado, retorno);
        }
        [TestMethod]
        public void Retornar4quandoSubtrair10por6()
        {
            int esperado = 4;
            var retorno = alunoModel.Subtração(10, 6);
            Assert.AreEqual(esperado, retorno);
        }
        [TestMethod]
        public void Retornar6quandoMultiplicar3por2()
        {
            int esperado = 6;
            var retorno = alunoModel.Multiplicacao(3, 2);
            Assert.AreEqual(esperado, retorno);
        }
        [TestMethod]
        public void TestarConexaoNoBanco()
        {
            var result = alunoModel.obterAluno(9);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PegarAluno1DoBanco_DeverRetornarAluno1()
        {
            var result = alunoModel.obterAluno(1);
            Assert.AreEqual(alunoModel.obterAluno(1), result);
        }
        [TestMethod]
        public void PegarAluno9DoBanco_RetornarNomeCorretoDoAluno9()
        {
            var result = alunoModel.obterAluno(9);
            Assert.IsNotNull(result);
            Assert.AreEqual(alunoModel.obterAluno(9).Nome, result.Nome);
        }
        [TestMethod]
        public void PegarAluno9DoBanco_GarantirQueNaoENulo()
        {
            var result = alunoModel.obterAluno(9);
            Assert.IsNotNull(result);
        }


           
    }
}
