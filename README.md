TDD-ComXUnitDotNetCore
# **Construindo TDD (Test Driven Development) com XUnit e .NET Core 3.0**
* Desenvolvimento baseado na codificação de testes unitários;
* Abordagem que tem "início" em 2002, com a publicação do livro "Test-Driven Development: By Example" por Kent Beck ("pai" do XP - Extreme Programming);
* SUT ("System Under Test") ou CUT ("Class Under Test" ou "Code Under Test") -> alguns termos comuns dentro do TDD  

## **Objetivos dos testes em um software**
* Garantir que o produto atende aquilo que foi especificado para o projeto;
* Verificação do correto funcionamento de uma aplicação;
* Detecção de falhas e defeitos que poderiam passar em branco até a subida em Produção.

## **Benefícios em se adotar TDD**
* Código mais claro, já que os testes são escritos com o objetivo de checar;
* Porções menos extensas de um projeto;
* Testes unitários podem ser encarados como uma forma de se documentar o código -> entendimento de como o método ou classe funciona;
* Um rápido feedback, com a geração de alertas diante de eventuais problemas;
* Algo extremamente importante ao se efetuarem testes de regressão;
* Uma maior cobertura de diferentes trechos de código, o que poderia não acontecer com outros tipos de testes;
* Falhas são apontadas durante o desenvolvimento, economizando assim tempo e recursos financeiros.
  
## **Motivo que contribuem a falta de testes**
A realização de teste é muitas vezes negligenciada;
* Falta de planejamento;
* Tempo escasso;
* Equipes reduzidas e sobrecarregadas, trabalhando simultanamente em vários projetos;
* Falta de hábito;
* Excesso de confiança de alguns profissionais.
  
## **Quais os impactos da falta de testes?**
* Retrabalho;
* Custos que excedem o orçamento;
* Conflitos entre membos de uma equipe técnica ou junto à área de negócios;
* Prejuízos à imagem da equipe ou empresa responsável por um projeto.

## **Boas práticas usando TDD**
* Ao buscar um código mais simples e de fácil manutenção, a adoção de TDD acaba por favorecer uma melhor assimilação de boas práticas de desenvolvimento/arquitetura de software;
* Separação de Responsabilidades (ao isolar a lógica de negócios ou de acesso a dados das camadas de visualização de uma aplicação);
* Maior coesão (evitando a implementação de classes "faz-tudo");
* Menor acoplamento (a simplificação do código visando a escrita de testes eficazes contribuiu para uma menor dependência entre diferentes partes de uma aplicação)

## **TDD e a implementação de softwares**
* Construção de soluções de uma maneira que facilite a integração a ferramentas para a execução de testes unitários;
* Codificação de teste unitários antes mesmo da implementação das partes que serão submetidas a análises -> evitando assim a elaboração de testes "viciados";
* A implementação de uma funcionalidade segue um ciclo conhecido como Red-Green-Refactor (com a exeução dos testes unitários em todos os estágios).  
  
  RED = Write a test! thats fails.
  Teste elaborado antes mesmo da funcionalidade ter sido codificado (apenas a estrutura básica foi definida), de forma a ser evitar uma verificação "viciada".
  Exemplo de definição de classe com funcionalidades ainda não implementadas:
  
           namespace TesteNF.Utils
           {
             public static class TributacaoHelper
             {
               public static double CalcularPIS(double valorBase)
               {
                 return 0;
               }
               public static double CalcularCONFINS(double valorBase)
               {
                 return 0;
               }
               public static double CalcularIRPJ(double valorBase)
               {
                 return 0;
               }
               public static double CalcularCSLL(double valorBase)
               {
                 return 0;
               }               
             }
           }

  GREEN = Make the code work.
  Funcionalidade codificada da forma mais simples possível, de maneira a garantir a execução com sucesso dos testes.
  Exemplo anterior com funcionalidade já implementada:
     
           using System.     
           namespace TesteNF.Utils
           {
             public static class TributacaoHelper
             {
               public static double CalcularPIS(double valorBase)
               {
                 return Math.Round(valorBase * 0.65 / 100, 2);
               }
               public static double CalcularCONFINS(double valorBase)
               {
                 return Math.Round(valorBase * 3 / 100, 2);
               }
               public static double CalcularIRPJ(double valorBase)
               {
                 return Math.Round(valorBase * 1.5 / 100, 2);
               }
               public static double CalcularCSLL(double valorBase)
               {
                 return Math.Round(valorBase * 1 / 100, 2);
               }               
             }
           }        

  REFACTOR: Eliminate redundancy.
  Eliminação de instruções duplicadas e eventuais melhorias no código.
     
         using System.
         namespace TesteNF.Utils
         {
           public static class TributacaoHelper
           {
             private static double CalcularImposto(double valorBase, double aliquota)
             {
               return Math.Round(valorBase * aliquota / 100, 2);
             }     
             public static double CalcularPIS(double valorBase)
             {
               return CalcularImposto(valorBase, 0.65);
             }
             public static double CalcularCONFINS(double valorBase)
             {
               return CalcularImposto(valorBase, 3);
             }
             public static double CalcularIRPJ(double valorBase)
             {
               return CalcularImposto(valorBase, 1.5);
             }
             public static double CalcularCSLL(double valorBase)
             {
               return CalcularImposto(valorBase, 1);
             }               
           }
         }



