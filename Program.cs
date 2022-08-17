using System;

namespace CS_CursoOnline
{
    class Program
    {
        public static void Main()
        {
            bool exitMenu = false;
            string menuInput;

            while (!exitMenu)
            {
                Console.Clear();
                Console.WriteLine("CURSOS ONLINE\n\nVer Categorias [1]\n    Autores    [2]\n    Cursos     [3]\n    Alunos     [4]\n    Matriculas [5]\n\n    SAIR       [0]");

                Console.Write("\n > ");
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        CategoriasMenu();
                        break;
                    case "2":
                        AutoresMenu();
                        break;
                    case "3":
                        CursosMenu();
                        break;
                    case "4":
                        AlunosMenu();
                        break;
                    case "5":
                        MatriculasMenu();
                        break;
                    case "0":
                        exitMenu = true;
                        break;
                    default:
                        Console.Write("\nOpção inválida...");
                        Console.ReadKey(true);
                        break;
                }
            } 
        }
        public static void AutoresMenu()
        {
            bool exitMenu = false;
            string menuInput;

            while (!exitMenu)
            {
                Console.Clear();
                Console.WriteLine("CURSOS ONLINE - Autores\n\nCriar Autor    [1]\nAlterar Autor  [2]\nDeletar Autor  [3]\n\nListar Autores [4]\n\nVOLTAR         [0]");

                Console.Write("\n > ");
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        BDOperations.Create.NewAutor();
                        break;
                    case "2":
                        BDOperations.Update.UpdateAutor();
                        Console.ReadKey(true);
                        break;
                    case "3":
                        BDOperations.Delete.RemoveAutor();
                        Console.ReadKey(true);
                        break;
                    case "4":
                        BDOperations.Read.GetAutores();
                        break;
                    case "0":
                            exitMenu = true;
                            break;
                    default:
                        Console.Write("\nOpção inválida...");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
        public static void AlunosMenu()
        {
            bool exitMenu = false;
            string menuInput;

            while (!exitMenu)
            {
                Console.Clear();
                Console.WriteLine("CURSOS ONLINE - Alunos\n\nCriar Aluno   [1]\nAlterar Aluno [2]\nDeletar Aluno [3]\n\nListar Alunos [4]\n\nVOLTAR        [0]");

                Console.Write("\n > ");
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        BDOperations.Create.NewAluno();
                        break;
                    case "2":
                        BDOperations.Update.UpdateAluno();
                        Console.ReadKey(true);
                        break;
                    case "3":
                        BDOperations.Delete.RemoveAluno();
                        Console.ReadKey(true);
                        break;
                    case "4":
                        BDOperations.Read.GetAlunos();
                        break;
                    case "0":
                            exitMenu = true;
                            break;
                    default:
                        Console.Write("\nOpção inválida...");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
        public static void CategoriasMenu()
        {
            bool exitMenu = false;
            string menuInput;

            while (!exitMenu)
            {
                Console.Clear();
                Console.WriteLine("CURSOS ONLINE - Categorias\n\nCriar Categoria   [1]\nAlterar Categoria [2]\nDeletar Categoria [3]\n\nListar Categorias [4]\n\nVOLTAR            [0]");

                Console.Write("\n > ");
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        BDOperations.Create.NewCategoria();
                        break;
                    case "2":
                        BDOperations.Update.UpdateCategoria();
                        Console.ReadKey(true);
                        break;
                    case "3":
                        BDOperations.Delete.RemoveCategoria();
                        Console.ReadKey(true);
                        break;
                    case "4":
                        BDOperations.Read.GetCategorias();
                        break;
                    case "0":
                            exitMenu = true;
                            break;
                    default:
                        Console.Write("\nOpção inválida...");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
        public static void CursosMenu()
        {
            bool exitMenu = false;
            string menuInput;

            while (!exitMenu)
            {
                Console.Clear();
                Console.WriteLine("CURSOS ONLINE - Cursos\n\nCriar Cursos   [1]\nAlterar Cursos [2]\nDeletar Cursos [3]\n\nListar Cursos  [4]\n\nVOLTAR         [0]");

                Console.Write("\n > ");
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        BDOperations.Create.NewCurso();
                        break;
                    case "2":
                        BDOperations.Update.UpdateCurso();
                        Console.ReadKey(true);
                        break;
                    case "3":
                        BDOperations.Delete.RemoveCurso();
                        Console.ReadKey(true);
                        break;
                    case "4":
                        BDOperations.Read.GetCursos();
                        break;
                    case "0":
                            exitMenu = true;
                            break;
                    default:
                        Console.Write("\nOpção inválida...");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
        public static void MatriculasMenu()
        {
            bool exitMenu = false;
            string menuInput;

            while (!exitMenu)
            {
                Console.Clear();
                Console.WriteLine("CURSOS ONLINE - Matriculas\n\nCriar Matricula   [1]\nAlterar Matricula [2]\nDeletar Matricula [3]\n\nListar Matriculas [4]\n\nVOLTAR            [0]");

                Console.Write("\n > ");
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        BDOperations.Create.NewMatricula();
                        break;
                    case "2":
                        BDOperations.Update.UpdateMatricula();
                        Console.ReadKey(true);
                        break;
                    case "3":
                        BDOperations.Delete.RemoveMatricula();
                        Console.ReadKey(true);
                        break;
                    case "4":
                        BDOperations.Read.GetMatriculas();
                        break;
                    case "0":
                            exitMenu = true;
                            break;
                    default:
                        Console.Write("\nOpção inválida...");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}
