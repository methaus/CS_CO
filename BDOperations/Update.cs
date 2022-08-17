using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Data;

namespace BDOperations
{
    class Update
    {
        static string passworld = "1234";
        static public void UpdateAutor()
        {
            Console.Clear();
            Console.WriteLine("AUTHOR UPDATE\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string nomeAutor;

                Console.Clear();
                Console.Write("AUTHOR UPDATE\n\nNome do Autor: ");
                nomeAutor = Console.ReadLine();

                try
                {
                    using (var DBcontext = new DataContext())
                    {
                        Console.Write("\nChecando Autor no Banco...");

                        var autor = DBcontext.Autores.FirstOrDefault(x => x.Nome == nomeAutor);

                        if (autor == null)
                            throw new Exception("\nAutor não existe.");

                        Console.Write("\n(Novos Dados)\nNome: ");
                        autor.Nome = Console.ReadLine();
                        Console.Write("Email: ");
                        autor.Email = Console.ReadLine();
                        Console.Write("Bio: ");
                        autor.Bio = Console.ReadLine();

                        DBcontext.Update(autor);
                        DBcontext.SaveChanges();
                    }

                    Console.Write("\nDados do Autor alterados com sucesso.");
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
        static public void UpdateAluno()
        {
            Console.Clear();
            Console.WriteLine("STUDENT UPDATE\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string nomeAluno;

                Console.Clear();
                Console.Write("STUDENT UPDATE\n\nNome do Aluno: ");
                nomeAluno = Console.ReadLine();

                try
                {
                    using (var DBcontext = new DataContext())
                    {
                        Console.Write("\nChecando Aluno no Banco...");

                        var aluno = DBcontext.Alunos.FirstOrDefault(x => x.Nome == nomeAluno);

                        if (aluno == null)
                            throw new Exception("\nAluno não existe.");

                        Console.Write("\n(Novos Dados)\nNome: ");
                        aluno.Nome = Console.ReadLine();
                        Console.Write("Email: ");
                        aluno.Email = Console.ReadLine();
                        Console.Write("CPF: ");
                        aluno.CPF = Console.ReadLine();

                        DBcontext.Update(aluno);
                        DBcontext.SaveChanges();
                    }

                    Console.Write("\nDados do Aluno alterados com sucesso.");
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
        static public void UpdateCategoria()
        {
            Console.Clear();
            Console.WriteLine("CATEGORY UPDATE\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string tituloCategoria;

                Console.Clear();
                Console.Write("CATEGORY UPDATE\n\nTítulo da Categoria: ");
                tituloCategoria = Console.ReadLine();

                try
                {
                    using (var DBcontext = new DataContext())
                    {
                        Console.Write("\nChecando Categoria no Banco...");

                        var categoria = DBcontext.Categorias.FirstOrDefault(x => x.Titulo == tituloCategoria);

                        if (categoria == null)
                            throw new Exception("\nCategoria não existe.");

                        Console.Write("\n(Novos Dados)\nTítulo: ");
                        categoria.Titulo = Console.ReadLine();
                        Console.Write("Descrição: ");
                        categoria.Descricao = Console.ReadLine();

                        DBcontext.Update(categoria);
                        DBcontext.SaveChanges();
                    }

                    Console.Write("\nDados da Categoria alterados com sucesso.");
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
        static public void UpdateCurso()
        {
            Console.Clear();
            Console.WriteLine("CLASS UPDATE\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string tituloCurso;

                Console.Clear();
                Console.Write("CLASS UPDATE\n\nTítulo do Curso: ");
                tituloCurso = Console.ReadLine();

                try
                {
                    using (var DBcontext = new DataContext())
                    {
                        Console.Write("\nChecando Curso no Banco...");

                        var curso = DBcontext.Cursos.FirstOrDefault(x => x.Titulo == tituloCurso);

                        if (curso == null)
                            throw new Exception("\nCurso não existe.");

                        Console.Write("\n(Novos Dados)\nTítulo: ");
                        curso.Titulo = Console.ReadLine();
                        Console.Write("Descrição: ");
                        curso.Descricao = Console.ReadLine();
                        Console.Write("Duração (min): ");
                        curso.DuracaoEmMinutos = int.Parse(Console.ReadLine());

                        curso.DataUltimaAtualizacao = DateTime.Now;

                        DBcontext.Update(curso);
                        DBcontext.SaveChanges();
                    }

                    Console.Write("\nDados da Curso alterados com sucesso.");
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
        static public void UpdateMatricula()
        {
            Console.Clear();
            Console.WriteLine("REGISTRY UPDATE\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string tituloCurso, nomeAluno;

                Console.Clear();
                Console.Write("REGISTRY UPDATE\n\nTítulo do Curso: ");
                tituloCurso = Console.ReadLine();

                try
                {
                    using (var DBcontext = new DataContext())
                    {
                        var curso = DBcontext.Cursos.FirstOrDefault(x => x.Titulo == tituloCurso);

                        if (curso == null)
                            throw new Exception("\nCurso não existe.");

                        Console.Write("Nome do Aluno: ");
                        nomeAluno = Console.ReadLine();

                        var aluno = DBcontext.Alunos.FirstOrDefault(x => x.Nome == nomeAluno);

                        if (curso == null)
                            throw new Exception($"\nEste Aluno não existe.");

                        var matricula = DBcontext.Matriculas.FirstOrDefault(x => x.CoursoId == curso.Id && x.AlunoId == aluno.Id);

                        if (matricula == null)
                            throw new Exception($"Não existe nenhuma Matrícula do Aluno \"{aluno.Nome}\" no no Curso \"{curso.Titulo}\".");
//
                        Console.Write("\n(Novos Dados)\nProgresso: ");
                        matricula.Progresso = byte.Parse(Console.ReadLine());

                        matricula.UltimaDataAtualizacao = DateTime.Now;

                        DBcontext.Update(matricula);
                        DBcontext.SaveChanges();
                    }

                    Console.Write("\nDados da Matrícula alterados com sucesso.");
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