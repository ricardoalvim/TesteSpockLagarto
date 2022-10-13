using Teste;
using Teste.Adapter;
using Teste.Elementos;
using Teste.Enum;

Elemento[] possibilidades = { Elemento.PAPEL,
                              Elemento.TESOURA,
                              Elemento.PEDRA,
                              Elemento.SPOCK,
                              Elemento.LAGARTO};

int escolhaIndice = new Random().Next(0, possibilidades.Length);
var escolhaComputador = new Tentativa().Equivalente(possibilidades[escolhaIndice]);
var escolhaUsuario = new Pedra();
var vencedor = escolhaComputador.Jogar(escolhaUsuario);

Console.WriteLine($"Usuário: {escolhaUsuario.ToString()}" );
Console.WriteLine($"Computador: {escolhaComputador.ToString()}");


if (escolhaUsuario.ToString().Equals(escolhaComputador.ToString()))
{
    Console.WriteLine($"Resultado: EMPATE ({escolhaUsuario.ToString()})");
}
else
{
    Console.WriteLine($"Resultado: {vencedor.ToString()} venceu!");
}