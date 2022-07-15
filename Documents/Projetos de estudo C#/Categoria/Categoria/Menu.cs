using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Categorias
{
    internal class Menu : Categoria
    {

        public static void MenuNavegar()
        {
            Categoria categoria = new Categoria();
            SubCategoria subCategoria = new SubCategoria();

            bool loopMenu = true;
            while (loopMenu)
            {
                Console.WriteLine("Digite a opção desejada: \n" +
                                                            "1- Cadastrar categoria \n" +
                                                            "2- Editar categoria \n" +
                                                            "3- Cadastrar subcategoria \n" +
                                                            "4- Editar subCategoria \n" +
                                                            "0- Para sair");


                
                    

                    string opcaoMenu = Console.ReadLine();
                    switch (opcaoMenu)
                    {
                        case "1":
                            Console.WriteLine(categoria.CadastrarCategoria());
                            break;

      
                        case "2":
                            Console.WriteLine(categoria.EditarCategoria());
                            break;
                        
                        case "3":
                        Console.WriteLine(subCategoria.CadastrarCategoria());
                        break;

                        case "4":
                        Console.WriteLine(subCategoria.EditarCategoria());
                        break;

                        case "0":
                            Console.WriteLine("Obrigado por utilizar nosso Sistema");
                            loopMenu = false;
                        break;

                    default:
                            Console.WriteLine("Opção invalida, digite uma das opções disponíveis");
                            break;
                    }

                

            }
        }

    }
}