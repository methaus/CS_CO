using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Data;

namespace BDOperations
{
    class Delete
    {
        static string passworld = "1234";
        static public void RemoveAutor()
        {
            Console.Clear();
            Console.WriteLine("AUTHOR DELETE\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string nomeAutor;
                bool deleted = false;

                Console.Clear();
                Console.Write("AUTHOR DELETE\n\nNome do Autor: ");
                nomeAutor = Console.ReadLine();

                try
                {
                    using (var DBcontext = new DataContext())
                    {
                        Console.Write("\nChecando Autor no Banco...");

                        var autor = DBcontext.Autores.FirstOrDefault(x => x.Nome == nomeAutor);

                        if (autor == null)
                            throw new Exception("\nAutor não existe.");

                        Console.Write($"\nTem certeza de que deseja remover o Autor \"{autor.Nome}\" do Banco? Se sim: ENTER.");
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            DBcontext.Remove(autor);
                            DBcontext.SaveChanges();
                            deleted = true;
                        }
                    }

                    if (deleted == true)
                        Console.Write("\nAutor excluído com sucesso.");
                    else
                        Console.Write("\nNenhum Autor foi excluído.");

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
        static public void RemoveAluno()
        {
            Console.Clear();
            Console.WriteLine("STUDENT DELETE\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string nomeAluno;
                bool deleted = false;

                Console.Clear();
                Console.Write("STUDENT DELETE\n\nNome do Aluno: ");
                nomeAluno = Console.ReadLine();

                try
                {
                    using (var DBcontext = new DataContext())
                    {
                        Console.Write("\nChecando Aluno no Banco...");

                        var aluno = DBcontext.Alunos.FirstOrDefault(x => x.Nome == nomeAluno);

                        if (aluno == null)
                            throw new Exception("\nAluno não existe.");

                        Console.Write($"\nTem certeza de que deseja remover o Aluno \"{aluno.Nome}\" do Banco? Se sim: ENTER.");
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            DBcontext.Remove(aluno);
                            DBcontext.SaveChanges();
                            deleted = true;
                        }
                    }

                    if (deleted == true)
                        Console.Write("\nAluno excluído com sucesso.");
                    else
                        Console.Write("\nNenhum Aluno foi excluído.");

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
        static public void RemoveCategoria()
        {
            Console.Clear();
            Console.WriteLine("CATEGORY DELETE\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string tituloCategoria;
                bool deleted = false;

                Console.Clear();
                Console.Write("CATEGORY DELETE\n\nTítulo da Categoria: ");
                tituloCategoria = Console.ReadLine();

                try
                {
                    using (var DBcontext = new DataContext())
                    {
                        Console.Write("\nChecando Categoria no Banco...");

                        var categoria = DBcontext.Categorias.FirstOrDefault(x => x.Titulo == tituloCategoria);

                        if (categoria == null)
                            throw new Exception("\nCategoria não existe.");

                        Console.Write($"\nTem certeza de que deseja remover a Categoria \"{categoria.Titulo}\" do Banco? Se sim: ENTER.");
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            DBcontext.Remove(categoria);
                            DBcontext.SaveChanges();
                            deleted = true;
                        }
                    }

                    if (deleted == true)
                        Console.Write("\nCategoria excluída com sucesso.");
                    else
                        Console.Write("\nNenhuma Categoria foi excluída.");

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
        static public void RemoveCurso()
        {
            Console.Clear();
            Console.WriteLine("CLASS DELETE\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string tituloCurso;
                bool deleted = false;

                Console.Clear();
                Console.Write("CLASS DELETE\n\nTítulo do Curso: ");
                tituloCurso = Console.ReadLine();

                try
                {
                    using (var DBcontext = new DataContext())
                    {
                        Console.Write("\nChecando Curso no Banco...");

                        var curso = DBcontext.Cursos.FirstOrDefault(x => x.Titulo == tituloCurso);

                        if (curso == null)
                            throw new Exception("\nCurso não existe.");

                        Console.Write($"\nTem certeza de que deseja remover o Curso \"{curso.Titulo}\" do Banco? Se sim: ENTER.");
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            DBcontext.Remove(curso);
                            DBcontext.SaveChanges();
                            deleted = true;
                        }
                    }

                    if (deleted == true)
                        Console.Write("\nCurso excluído com sucesso.");
                    else
                        Console.Write("\nNenhum Curso foi excluído.");

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
        static public void RemoveMatricula()
        {
            Console.Clear();
            Console.WriteLine("REGISTRY DELETE\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string tituloCurso, nomeAluno;
                bool deleted = false;

                Console.Clear();
                Console.Write("REGISTRY DELETE\n\nTítulo do Curso: ");
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

                        Console.Write($"\nTem certeza de que deseja remover a Matricula do \"{aluno.Nome}\" do Curso \"{curso.Titulo}\" do Banco? Se sim: ENTER.");

                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            DBcontext.Remove(matricula);
                            DBcontext.SaveChanges();
                            deleted = true;
                        }
                    }

                    if (deleted == true)
                        Console.Write("\nMatricula excluída com sucesso.");
                    else
                        Console.Write("\nNenhuma Matrícula foi excluída.");

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