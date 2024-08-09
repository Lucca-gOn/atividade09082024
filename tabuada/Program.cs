//Recebe um número
Console.WriteLine("Digite um número para ver a tabuada:");
//Converte o número para inteiro
int numero = Convert.ToInt32(Console.ReadLine());
//Imprime a tabuada
for (int i = 1; i <= 10; i++) {
    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
}


