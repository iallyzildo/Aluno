using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aluno.Entity;

namespace Aluno.Models
{
    public class AlunoModel
    {
        private AlunoEntities db = new AlunoEntities();

        public List<aluno> todosAlunos()
        {
            var lista = from a in db.Aluno
                        select a;
            return lista.ToList();
        }

        public string adicionarAluno(aluno a)
        {
            string erro = null;
            try
            {
                db.Aluno.AddObject(a);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
        public aluno obterAluno(int idAluno)
        {
            var lista = from a in db.Aluno
                        where a.IdAluno == idAluno
                        select a;
            return lista.ToList().FirstOrDefault();
        }
        public List<aluno> listarAlunos(string pesquisa)
        {
            var lista = from a in db.Aluno
                        where a.Nome.Contains(pesquisa)
                        select a;
            return lista.ToList();
        }

        public string editarAluno(aluno a)
        {
            string erro = null;
            try
            {
                if (a.EntityState == System.Data.EntityState.Detached)
                {
                    db.Aluno.Attach(a);
                }
                db.ObjectStateManager.ChangeObjectState(a, System.Data.EntityState.Modified);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirAluno(aluno a)
        {
            string erro = null;
            try
            {
                db.Aluno.DeleteObject(a);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
        public string validarAluno(aluno a)
        {
            if (a.Nome == null || a.Nome == "")
            {
                return "O nome não pode ser vazio!";
            }
            if (a.CPF == null || a.CPF.Length > 11)
            {
                return "CPF inválido";
            }
            if (a.Matricula == null || a.Matricula == "")
            {
                return "Matricula Invalida";
            }
            return null;
        }
        private string digitos;

        public string calcularDigitosVerificadoresCPF(string digitos)
        {
            this.digitos = digitos;
            int[] array = new int[digitos.Length + 1];
            int[] peso = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int digito10;
            int digito11;
            int soma = 0;

            for (int i = 0; i < digitos.Length; i++)
            {
                int digitoUnico = Int32.Parse(digitos.Substring(i, 1));
                array[i] = digitoUnico;
            }

            for (int i = 0; i < digitos.Length; i++)
            {
                soma = soma + (array[i] * peso[i + 1]);
            }
            digito10 = soma % 11;

            if (digito10 < 2)
            {
                digito10 = 0;
            }
            else
            {
                digito10 = 11 - digito10;
            }
            soma = 0;
            array[9] = digito10;

            for (int i = 0; i < array.Length; i++)
            {
                soma = soma + (array[i] * peso[i]);
            }
            digito11 = soma % 11;

            if (digito11 < 2)
            {
                digito11 = 0;
            }
            else
            {
                digito11 = 11 - digito11;
            }

            return (digito10 + "" + digito11);
        }
        public int Soma(int valor1, int valor2)
        {
            return valor1+valor2;
        }
        public int Divisao(int valor1, int valor2)
        {
            return valor1/valor2;        
        }
        public int Multiplicacao(int valor1, int valor2)
        {
            return valor1*valor2;
        }
        public int Subtração(int valor1, int valor2)
        {
            return valor1-valor2;
        }
       
    }
}