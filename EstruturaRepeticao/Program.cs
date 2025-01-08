
for (int i = 1; i <= 10; i++) { Console.WriteLine("A variável i agora vale " + i); }
int numero = -1; while (numero != 10) { Console.Write("Digite um número: "); numero = Convert.ToInt32(Console.ReadLine()); if (numero < 10) { Console.WriteLine("Você errou, tente um número maior."); } else if (numero > 10) { Console.WriteLine("Você errou, tente um número menor."); } else { Console.WriteLine("Parabéns, você acertou!"); } }
int contador = 15; do { Console.WriteLine("O contador vale: " + contador); contador++; } while (contador <= 10);