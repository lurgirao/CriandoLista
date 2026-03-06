using System.Linq;
using System.Collections.Generic;


/*
    List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa() { Nome = "João", Idade = 25, Genero = "Masculino", ClasseSocial = "Classe B" }, //objeto
            new Pessoa() { Nome = "Maria", Idade = 30, Genero = "Feminino", ClasseSocial = "Classe A" },
            new Pessoa() { Nome = "Pedro", Idade = 20, Genero = "Masculino", ClasseSocial = "Classe C" },
            new Pessoa() { Nome = "Ana", Idade = 35, Genero = "Feminino", ClasseSocial = "Classe D" },
            new Pessoa() { Nome = "Lucas", Idade = 28, Genero = "Masculino", ClasseSocial = "Classe C" }
        };

var ordenarPorNome = pessoas.OrderBy/*ordenar por*///(p => p.Nome); //p => p.Nome é a expressão lambda, onde p representa cada pessoa na lista e p.Nome é o critério de ordenação
/*foreach (var o in ordenarPorNome)
{
    Console.WriteLine(o.Idade);
}

class Pessoa //cria as gavetas
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Genero { get; set; }
    public string ClasseSocial { get; set; }
}
*/

//GroupBy - agrupar por
/*List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var agrupar = numeros.GroupBy(c => c % 2 == 0);

foreach (var a in agrupar)//percorreu todos os dados
{
    Console.WriteLine("Chave: " + a.Key);
    foreach (var numero in a)//detecta os números pares e ímpares, onde a.Key é a chave do grupo (true para pares e false para ímpares) e 'a' é a coleção de números que pertencem a esse grupo
    {
     Console.WriteLine(numero);
    }
}*/

//Distinct - Limpa duplicatas
/*List<int> numeros = new List<int> () { 1, 1, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10 };
var semRepeticao = numeros.Distinct(); //Distinct() é um método de extensão que retorna uma nova coleção contendo apenas os elementos distintos da coleção original, ou seja, ele remove os elementos duplicados.

foreach (var rep in semRepeticao)
{
    Console.WriteLine(rep);
}

//Take
var tresPrimeiros = numeros.Take(3); //Take() é um método de extensão que retorna uma nova coleção contendo os primeiros n elementos da coleção original, onde n é o número especificado como argumento.
foreach (var tres in tresPrimeiros)
{
    Console.WriteLine(tres);
}

//Skip
var aposTresPrimeiros = numeros.Skip(3); //Skip() é um método de extensão que retorna uma nova coleção contendo os elementos da coleção original, mas ignorando os primeiros n elementos, onde n é o número especificado como argumento.
foreach (var apos in aposTresPrimeiros)
{
    Console.WriteLine(apos);
}*/


      
    List<Produto> produtos = new List<Produto>()

    {
    new Produto{ Nome="Notebook", Categoria="Eletrônicos", Preco=3500, Estoque=10 },
    new Produto{ Nome="Mouse", Categoria="Eletrônicos", Preco=80, Estoque=50 },
    new Produto{ Nome="Teclado", Categoria="Eletrônicos", Preco=150, Estoque=40 },
    new Produto{ Nome="Cadeira Gamer", Categoria="Móveis", Preco=1200, Estoque=5 },
    new Produto{ Nome="Mesa Escritório", Categoria="Móveis", Preco=900, Estoque=8 },
    new Produto{ Nome="Monitor", Categoria="Eletrônicos", Preco=1100, Estoque=12 },
    new Produto{ Nome="Luminária", Categoria="Decoração", Preco=120, Estoque=25 }
    };

//Mostre todos os produtos que custam mais de R$ 1000
Console.WriteLine("______________________________________________ \n Produtos com preço acima de R$ 1000,00:");
var OrdemPreco = produtos.Where(p => p.Preco > 1000);
foreach (var o in OrdemPreco)
{
    Console.WriteLine(o.Preco);
}

//Liste apenas os nomes dos produtos da categoria Eletrônicos.
Console.WriteLine("______________________________________________ \n Lista de eletrônicos:");
var OrdemEletronicos = produtos.OrderBy(e => e.Categoria == "Eletronicos");
foreach (var e in OrdemEletronicos)
{
        Console.WriteLine(e.Nome);
}

//Mostre os produtos ordenados do mais barato para o mais caro.
Console.WriteLine("______________________________________________ \n Categorizando produtos do mais barato para o mais caro:");
var CaroBarato = produtos.OrderBy(c => c.Preco);
foreach (var c in CaroBarato)
{
    Console.WriteLine($"{c.Nome} + {c.Preco}");
}

//Calcule o valor médio dos produtos
Console.WriteLine("______________________________________________ \n O valor médio dos produtos é:");
var MediaPreco = produtos.Average(m => m.Preco);
Console.WriteLine(MediaPreco);

//Encontre o produto mais caro
Console.WriteLine("______________________________________________ \n Qual o produto mais caro?");
var MaisCaro = produtos.Max(h => h.Preco);
foreach (var mc in produtos)
{
    if (mc.Preco == MaisCaro)
    {
        Console.WriteLine($"O produto mais caro da lista é o {mc.Nome}, custa R$ {MaisCaro}");
    }
}

//Mostre todos os produtos que possuem estoque menor que 10
Console.WriteLine("______________________________________________ \n Produtos com estoque abaixo de 10:");
var EstoqueDez = produtos.Where(ee => ee.Estoque < 10);
foreach (var ee in EstoqueDez)
{
    Console.WriteLine(ee.Nome);
}

//Calcule o valor total do estoque da loja
Console.WriteLine("______________________________________________ \n VALOR DO ESTOQUE");
var EstoqueTotal = produtos.Sum(st => st.Preco * st.Estoque);
Console.WriteLine($"O valor total do estoque da loja é R$ {EstoqueTotal}");

//Agrupe produtos por categoria.
Console.WriteLine("______________________________________________ \n CATEGORIA DE PRODUTOS");
var Categoria = produtos.GroupBy(ca => ca.Categoria);
foreach (var ca in Categoria)
{
    Console.WriteLine($"Categoria: {ca.Key}");
    foreach (var p in ca)
    {
        Console.WriteLine($" - {p.Nome}");
    }
}

class Produto

    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
    }
