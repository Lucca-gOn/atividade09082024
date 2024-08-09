//Criar uma lista de nomes:
List<string> nomes = new List<string>();

//Digite o nome:
for (int i = 0; i < 5; i++) {
Console.WriteLine("Digite um nome:");
nomes.Add(Console.ReadLine());
}
//Ordenar a lista:
Console.WriteLine("Nomes em ordem alfabética:");
nomes.Sort();

//Exibir os nomes:
foreach (var nome in nomes) {
Console.WriteLine(nome);
}



