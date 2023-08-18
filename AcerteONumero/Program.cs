using System;


Random numAleatorio = new Random();

int pontos = 0;
bool sair = false;

while (sair == false)
{
    Console.WriteLine("Adivinhe o numero de 1 a 9 gerado aleatoriamente!!");

    int NumeroA = numAleatorio.Next(1, 9);

    Console.WriteLine("Digite um numero de 1 a 9");
    //int NumeroE = Convert.ToInt32(Console.ReadLine());
    int NumeroE = 0;
    while (NumeroE == 0)
    {
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            NumeroE = numero;
        }
        else
        {
            //throw new ArgumentException("O valor digitado tem que ser um numero de 1 a 9!!");
            Console.WriteLine("O valor digitado tem que ser um numero de 1 a 9!!");
            NumeroE = 0;
        }
    }

    if (NumeroE == NumeroA)
    {
        Console.WriteLine("Parabens, você acertou!!");
        pontos ++;
        Console.WriteLine("Quantidade de pontos: " + pontos);

        Console.WriteLine("Deseja continuar a jogar? Se sim aperte 1, Se não aperte qualquer outra tecla");
        string SimouNao = Console.ReadLine();
        if (SimouNao != "1")
        {
           sair = true;
        }

    } else
    {
        Console.WriteLine("Você errou!");
        Console.WriteLine("Quantidade de pontos: " + pontos);

        Console.WriteLine("Deseja continuar a jogar? Se sim aperte 1, Se não aperte qualquer outra tecla");
        string SimouNao = Console.ReadLine();
        if (SimouNao != "1")
        {
            sair = true;
        }
    } 
}


