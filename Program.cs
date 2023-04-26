using System;

class Program
{
    static void Main(string[] args)
    {
        // Definindo os preços das melancias
        const double precoComum = 5.50;
        const double precoBaby = 8.54;

        // Definindo as variáveis de controle
        double totalComum = 0;
        double totalBaby = 0;
        double totalGeral = 0;
        int tentativas = 0;
        bool autenticado = false;
        string mensagem=null;

        // Loop principal
   
        while (true)
        {
            // Verificando se o usuário foi autenticado
            if (!autenticado)
            {
                // Pedindo as credenciais de acesso
                
                Console.Write("Usuário: ");
                string usuario = Console.ReadLine();
                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                // Verificando se as credenciais estão corretas
                if (usuario == "joão" && senha == "123")
                {
                    autenticado = true;
                }
                else
                {
                    tentativas++;
                    if (tentativas >= 3)
                    {
                        mensagem ="Você excedeu o número de tentativas. O programa será encerrado, e sua conta bloqueada.";
                        //Mostrando Mensagem de Finalização
                        Console.WriteLine(mensagem);
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("Credenciais inválidas. Por favor, tente novamente.");
                    continue;
                }
            }

            // Pedindo a placa do caminhão
            Console.Write("Digite a placa do caminhão (ou 'sair' para encerrar o programa): ");
            string placa = Console.ReadLine();

            // Verificando se o usuário quer sair
            if (placa == "sair")
            {
                break;
            }

            // Pedindo o tipo de melancia
            Console.Write("Digite o tipo de melancia (comum ou baby): ");
            string tipo = Console.ReadLine();

            // Pedindo a quantidade de melancia
            Console.Write("Digite a quantidade de melancia (em quilos): ");
            double quantidade = double.Parse(Console.ReadLine());

            // Verificando o dia da semana
            Console.Write("Digite o dia da semana (1 a 5): Sabendo que SEGUNDA-FEIRA é (1) e SEXTA-FEIRA é (5)  ");
            int diaSemana = int.Parse(Console.ReadLine());
            double desconto = 0;
            string mensagemPromocao = "";

            switch (diaSemana)
            {
                case 2:
                    desconto = 0.15;
                    mensagemPromocao = "Terça verde";
                    Console.ForegroundColor = ConsoleColor.Green; // adicionando cor verde  
                    break;
                case 3:
                    desconto = 0.01;
                    break;
                case 4:
                    desconto = 0.17;
                    mensagemPromocao = "Quarta Verde";
                    Console.ForegroundColor = ConsoleColor.Green; // adicionando cor verde
                    break;
                case 5:
                    desconto = 0.03;
                    break;
                default:
                    desconto = 0.02;
                    break;
            }

            if (!string.IsNullOrEmpty(mensagemPromocao))
            {
                Console.ForegroundColor = ConsoleColor.Green; // adicionando cor verde
                Console.WriteLine(mensagemPromocao);
                Console.ResetColor();
                // resetando a cor do texto para a cor padrão
            }

            // Calculando o valor total da compra
            double valorTotal = tipo == "comum" ? precoComum * quantidade : precoBaby * quantidade;
            valorTotal -= valorTotal * desconto;

            // Atualizando os totais
            if (tipo == "comum")
            {
                totalComum += valorTotal;
            }
            else
            {
                totalBaby += valorTotal;
            }
            totalGeral += valorTotal;

            // Mostrando o resumo da compra
            Console.WriteLine("Resumo da compra:");
            Console.WriteLine("Placa do caminhão: " + placa);
            Console.WriteLine("Valor Gasto: " + valorTotal);


          
       

        }
    }
}
            

            
