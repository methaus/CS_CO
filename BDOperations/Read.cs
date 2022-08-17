using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Data;

namespace BDOperations
{
    class Read
    {
        static string passworld = "1234";
        static public void GetAutores()
        {
            Console.Clear();
            Console.WriteLine("AUTHORS LIST\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                Console.Clear();
                Console.WriteLine("AUTHORS LIST");

                try
                {
                    Console.Write("\nAcessando Banco de Dados...\n");

                    using (var DBcontext = new DataContext())
                    {
                        var autores = DBcontext.Autores.AsNoTracking().ToList();

                        foreach (var autor in autores)
                        {
                            Console.WriteLine($"\nNome:  {autor.Nome};\nEmail: {autor.Email};\nBio:   {autor.Bio};\n------------------");
                        }
                    }

                    Console.Write("\nFim da lista.");
                    Console.ReadKey(true);
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                    Console.ReadKey(true);
                }
            }
            else
            {
                Console.Write("\nSenha inválida!");
                Console.ReadKey(true);
            }
        }
        static public void GetAlunos()
        {
            Console.Clear();
            Console.WriteLine("STUDENTS LIST\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                Console.Clear();
                Console.WriteLine("STUDENTS LIST");

                try
                {
                    Console.Write("\nAcessando Banco de Dados...\n");

                    using (var DBcontext = new DataContext())
                    {
                        var alunos = DBcontext.Alunos.AsNoTracking().ToList();

                        foreach (var aluno in alunos)
                        {
                            Console.WriteLine($"\nNome:  {aluno.Nome};\nEmail: {aluno.Email};\nCPF:   {aluno.CPF};\nData de Inscrição: {aluno.DataCriacao.ToString()};\n------------------");
                        }
                    }

                    Console.Write("\nFim da lista.");
                    Console.ReadKey(true);
                }
                catch (Exception e)
                {
                    Console.Write(e);
                    Console.ReadKey(true);
                }
            }
            else
            {
                Console.Write("\nSenha inválida!");
                Console.ReadKey(true);
            }
        }
        static public void GetCategorias()
        {
            Console.Clear();
            Console.WriteLine("CATEGORIES LIST\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                Console.Clear();
                Console.WriteLine("CATEGORIES LIST");

                try
                {
                    Console.Write("\nAcessando Banco de Dados...\n");

                    using (var DBcontext = new DataContext())
                    {
                        var categorias = DBcontext.Categorias.AsNoTracking().ToList();

                        foreach (var categoria in categorias)
                        {
                            Console.WriteLine($"\nCategoria - Titulo: {categoria.Titulo};\nDescrição: {categoria.Descricao};\n------------------");
                        }
                    }

                    Console.Write("\nFim da lista.");
                    Console.ReadKey(true);
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                    Console.ReadKey(true);
                }
            }
            else
            {
                Console.Write("\nSenha inválida!");
                Console.ReadKey(true);
            }
        }
        static public void GetCursos()
        {
            Console.Clear();
            Console.WriteLine("CLASSES LIST\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                Console.Clear();
                Console.WriteLine("CLASSES LIST");

                try
                {
                    Console.Write("\nAcessando Banco de Dados...\n");

                    using (var DBcontext = new DataContext())
                    {
                        var cursos = DBcontext.Cursos.AsNoTracking().ToList();

                        foreach (var curso in cursos)
                        {
                            var categoria = DBcontext.Categorias.First(x => x.Id == curso.CategoriaId);
                            var autor = DBcontext.Autores.First(x => x.Id == curso.AutorId);

                            Console.WriteLine($"\nCurso - Titulo: {curso.Titulo};\nDescrição: {curso.Descricao};\nDuração (min): {curso.DuracaoEmMinutos};\nData de Abertura: {curso.DataCriacao.ToString()};\nData da Última Atualização: {curso.DataUltimaAtualizacao.ToString()};\nCategoria: {categoria.Titulo};\nAutor: {autor.Nome}\n------------------");
                        }
                    }

                    Console.Write("\nFim da lista.");
                    Console.ReadKey(true);
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                    Console.ReadKey(true);
                }
            }
            else
            {
                Console.Write("\nSenha inválida!");
                Console.ReadKey(true);
            }
        }
        static public void GetMatriculas()
        {
            Console.Clear();
            Console.WriteLine("REGISTRYS LIST\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                Console.Clear();
                Console.WriteLine("REGISTRYS LIST");

                try
                {
                    Console.Write("\nAcessando Banco de Dados...\n");

                    using (var DBcontext = new DataContext())
                    {
                        var matriculas = DBcontext.Matriculas.AsNoTracking().ToList();

                        foreach (var matricula in matriculas)
                        {
                            var aluno = DBcontext.Alunos.First(x => x.Id == matricula.AlunoId);
                            var curso = DBcontext.Cursos.First(x => x.Id == matricula.CoursoId);

                            Console.WriteLine($"\nAluno: {aluno.Nome};\nCurso: {curso.Titulo};\nData início: {matricula.DataInicio.ToString()};\nUltima Atualização: {matricula.UltimaDataAtualizacao.ToString()};\nProgresso (%): {matricula.Progresso};\n------------------");
                        }
                    }

                    Console.Write("\nFim da lista.");
                    Console.ReadKey(true);
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                    Console.ReadKey(true);
                }
            }
            else
            {
                Console.Write("\nSenha inválida!");
                Console.ReadKey(true);
            }
        }
    }
}