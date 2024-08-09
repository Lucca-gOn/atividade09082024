//Elemntos de um array
int[] elementos = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
//Soma dos números pares
int soma = 0;
//Percorrendo o array
foreach (int numero in elementos) {
     if (numero % 2 == 0) soma += numero;
}
//Imprimindo o resultado
Console.WriteLine("A soma dos números pares é: " + soma);