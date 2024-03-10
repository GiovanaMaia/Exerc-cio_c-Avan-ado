using System;
using System.Collections.Generic;
using System.Text;

class HelloWorld {

  static void Main(string[] args) {

    int escolha, cadastro = 0;
    CadastroJogo cadastro1 = new CadastroJogo();
    CadastroJogo cadastro2 = new CadastroJogo();
    CadastroJogo cadastro3 = new CadastroJogo();
    CadastroJogo cadastro4 = new CadastroJogo();
    CadastroJogo cadastro5 = new CadastroJogo();


     CadastroJogo[] cadastros = new CadastroJogo[5];
      cadastros[0] = cadastro1;
      cadastros[1] = cadastro2;
      cadastros[2] = cadastro3;
      cadastros[3] = cadastro4;
      cadastros[4] = cadastro5;


     while (true) {

         
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1.Cadastrar um jogo");
    Console.WriteLine("2.Exibir todos os jogos cadastrados");
    Console.WriteLine("3.sair do programa");
    escolha = Convert.ToInt32(Console.ReadLine());

       

      if (escolha ==1){

        cadastro++;
        

        if (cadastro == 1){

          Console.WriteLine("Digite o nome do jogo 1;");
          cadastro1.nome = Console.ReadLine();
          Console.WriteLine("Digite gênero");
          cadastro1.genero = Console.ReadLine();
          Console.WriteLine("Digite ano de lançamento");
          cadastro1.anoLancado = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Digite a nota do Metacritic");
          cadastro1.notaMetacritic = Convert.ToInt32(Console.ReadLine());
          }
        else if (cadastro == 2){
        Console.WriteLine("Digite o nome do jogo 2;");
        cadastro2.nome = Console.ReadLine();
        Console.WriteLine("Digite gênero");
        cadastro2.genero = Console.ReadLine();
        Console.WriteLine("Digite ano de lançamento");
        cadastro2.anoLancado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a nota do Metacritic");
        cadastro2.notaMetacritic = Convert.ToInt32(Console.ReadLine());
        
        }

        else if (cadastro == 3){

        Console.WriteLine("Digite o nome do jogo 3;");
        cadastro3.nome = Console.ReadLine();
        Console.WriteLine("Digite gênero");
        cadastro3.genero = Console.ReadLine();
        Console.WriteLine("Digite ano de lançamento");
        cadastro3.anoLancado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a nota do Metacritic");
        cadastro3.notaMetacritic = Convert.ToInt32(Console.ReadLine());
    
          }
          
        else if (cadastro == 4){
        Console.WriteLine("Digite o nome do jogo 4;");
        cadastro4.nome = Console.ReadLine();
        Console.WriteLine("Digite gênero");
        cadastro4.genero = Console.ReadLine();
        Console.WriteLine("Digite ano de lançamento");
        cadastro4.anoLancado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a nota do Metacritic");
        cadastro4.notaMetacritic = Convert.ToInt32(Console.ReadLine());
         
         }
          
          else if (cadastro == 5){

        Console.WriteLine("Digite o nome do jogo 5;");
        cadastro5.nome = Console.ReadLine();
        Console.WriteLine("Digite gênero");
        cadastro5.genero = Console.ReadLine();
        Console.WriteLine("Digite ano de lançamento");
        cadastro5.anoLancado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a nota do Metacritic");
        cadastro5.notaMetacritic = Convert.ToInt32(Console.ReadLine());
         
          }
          else if (cadastro > 5){

        Console.WriteLine("Limite de jogos cadastrados atingido!!");
          }
      
         
        }
       
       else if (escolha == 2){
         
        for (int i = 0; i < cadastro; i++) {
         Console.WriteLine("Nome:" +  cadastros[i].nome);
         Console.WriteLine("Gênero:" +  cadastros[i].genero);
         Console.WriteLine("Ano de lançamento:" +  cadastros[i].anoLancado);
         Console.WriteLine("Nota do Metacritic:" +  cadastros[i].notaMetacritic);
         }
          
       }
       else if (escolha == 3){
           Console.WriteLine("Até a próxima!!"); 

        break;
       }
       else {
           
          Console.WriteLine("Opção inválida"); 

       }
      } 
    }
  


   internal class CadastroJogo
  {
      public string nome;
      public string genero;
      public int anoLancado;
      public int notaMetacritic;

  }
  }

