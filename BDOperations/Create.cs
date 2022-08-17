using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
using Data;

namespace BDOperations
{
    class Create
    {
        static string passworld = "1234";
        static public void NewAutor()
        {
            Console.Clear();
            Console.WriteLine("NEW AUTHOR\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string nome, email, bio;

                Console.Clear();
                Console.Write("NEW AUTHOR\n\nNome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Bio: ");
                bio = Console.ReadLine();

                try
                {
                    Console.Write("\nAcessando Banco de Dados...");

                    using (var DBcontext = new DataContext())
                    {
                        Autor autor = new Autor { 
                            Nome = nome,
                            Bio = bio,
                            Email = email,
                        };

                        DBcontext.Autores.Add(autor);
                        DBcontext.SaveChanges();
                    }

                    Console.Write("\nAutor cadastrado com sucesso.");
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
        static public void NewAluno()
        {
            Console.Clear();
            Console.WriteLine("NEW STUDENT\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string nome, email, cpf;
                var datacriacao = DateTime.Now;

                Console.Clear();
                Console.Write("NEW STUDENT\n\nNome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("CPF (APENAS NÚMEROS): ");
                cpf = Console.ReadLine();

                try
                {
                    Console.Write("\nAcessando Banco de Dados...");

                    using (var DBcontext = new DataContext())
                    {
                        Aluno aluno = new Aluno { 
                            Nome = nome,
                            Email = email,
                            CPF = cpf,
                            DataCriacao = datacriacao
                        };

                        DBcontext.Alunos.Add(aluno);
                        DBcontext.SaveChanges();
                    }

                    Console.Write("\nAluno cadastrado com sucesso.");
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
        static public void NewCategoria()
        {
            Console.Clear();
            Console.WriteLine("NEW CATEGORY\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string titulo, descricao;

                Console.Clear();
                Console.Write("NEW CATEGORY\n\nTitulo: ");
                titulo = Console.ReadLine();
                Console.Write("Descricao: ");
                descricao = Console.ReadLine();

                try
                {
                    Console.Write("\nAcessando Banco de Dados...");

                    using (var DBcontext = new DataContext())
                    {
                        Categoria categoria = new Categoria { 
                            Titulo = titulo,
                            Descricao = descricao
                        };

                        DBcontext.Categorias.Add(categoria);
                        DBcontext.SaveChanges();
                    }

                    Console.Write("\nCategoria cadastrada com sucesso.");
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
        static public void NewCurso()
        {
            Console.Clear();
            Console.WriteLine("NEW CLASS\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string titulo, descricao, nomeAutor, tituloCategoria;
                int duracao;
                DateTime datacriacao = DateTime.Now, dataUltimaAtualizacao = DateTime.Now;
                Guid autorId, categoriaId;

                Console.Clear();
                Console.Write("NEW CLASS\n\nTitulo: ");
                titulo = Console.ReadLine();
                Console.Write("Descricao: ");
                descricao = Console.ReadLine();
                Console.Write("Duração (min): ");
                duracao = int.Parse(Console.ReadLine());

                Console.Write("Titulo do Curso: ");
                tituloCategoria = Console.ReadLine();

                try
                {
                    using (var DBcontext = new DataContext())
                    {
                        var categorias = DBcontext
                            .Categorias
                            .AsNoTracking()
                            .FirstOrDefault(x => x.Titulo == tituloCategoria);

                        if (categorias.Id == null)
                            throw new Exception("\nCurso não existe.");
                        else
                            categoriaId = categorias.Id; 

                        Console.WriteLine("Nome do Autor: ");
                        nomeAutor = Console.ReadLine();

                        var autores = DBcontext
                            .Autores
                            .AsNoTracking()
                            .FirstOrDefault(x => x.Nome == nomeAutor);

                        if (autores.Id == null)
                            throw new Exception("\nAutor não existe.");
                        else
                            autorId = autores.Id; 

                        Console.Write("\nAcessando Banco de Dados...");

                        Curso curso = new Curso {
                            Titulo = titulo,
                            Descricao = descricao,
                            DuracaoEmMinutos = duracao,
                            DataCriacao = datacriacao,
                            DataUltimaAtualizacao = dataUltimaAtualizacao,
                            AutorId = autorId,
                            CategoriaId = categoriaId
                        };

                        DBcontext.Cursos.Add(curso);
                        DBcontext.SaveChanges();
                    }

                    Console.Write("\nCurso cadastrado com sucesso.");
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
        static public void NewMatricula()
        {
            Console.Clear();
            Console.WriteLine("NEW REGISTRY\n\nDigite a senha: ");

            if (passworld == Console.ReadLine())
            {
                string nomeAluno, tituloCurso;
                Guid alunoId, coursoId;
                DateTime dataInicio = DateTime.Now, ultimaDataAtualizacao = DateTime.Now;
                byte progresso = 0;

                Console.Clear();

                try
                {
                    Console.Write("NEW REGISTRY\n\nNome do Aluno: ");
                    nomeAluno = Console.ReadLine();

                    using (var DBcontext = new DataContext())
                    {
                        var alunos = DBcontext
                            .Alunos
                            .AsNoTracking()
                            .FirstOrDefault(x => x.Nome == nomeAluno);

                        if (alunos.Id == null)
                            throw new Exception("\nAluno não existe.");
                        else
                            alunoId = alunos.Id; 

                        Console.Write("Nome do Curso: ");
                        tituloCurso = Console.ReadLine();

                        var cursos = DBcontext
                            .Cursos
                            .AsNoTracking()
                            .FirstOrDefault(x => x.Titulo == tituloCurso);

                        if (cursos.Id == null)
                            throw new Exception("\nCurso não existe.");
                        else
                            coursoId = cursos.Id; 

                        Console.Write("\nAcessando Banco de Dados...");

                        AlunoCurso matricula = new AlunoCurso { 
                            AlunoId = alunoId,
                            CoursoId = coursoId,
                            DataInicio = dataInicio,
                            Progresso = progresso,
                            UltimaDataAtualizacao = ultimaDataAtualizacao
                        };

                        DBcontext.Matriculas.Add(matricula);
                        DBcontext.SaveChanges();
                    }

                    Console.Write("\nMatrícula feita com sucesso.");
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
    }
}