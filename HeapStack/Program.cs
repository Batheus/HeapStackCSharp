/* Value Types -> Stack 
   Tipos de valores primitivos: int, string, bool...
   ou struct, para classes.
*/
int LadoA = 5;
int LadoB = 10;
int areaQuadrado = CalcularAreaQuadrado(ref LadoA);

Console.WriteLine("Lado A *Stack*: " + LadoA);
Console.WriteLine("Lado B *Stack*: " + LadoB);
Console.WriteLine("Area do quadrado *Stack*: " + areaQuadrado + "\n");

int CalcularAreaQuadrado(ref int lado)
{
    lado *= lado;
    return lado;
}

// Reference Types -> Heap

// new = utilizado para o compilador alocar o ponteiro salvo na memória stack para a memória heap.
var retangulo1 = new Retangulo();
var retangulo2 = new Retangulo();

retangulo1.LadoA = 100;
retangulo1.LadoB = 200;

retangulo2.LadoA = 300;
retangulo2.LadoB = 400;

retangulo1 = retangulo2; //Apontamento de endereço

retangulo2.LadoA = 1;

Console.WriteLine("Retangulo 1 Lado A *Heap*: " + retangulo1.LadoA);
Console.WriteLine("Retangulo 1 Lado B *Heap*: " + retangulo1.LadoB);
Console.WriteLine("Retangulo 2 Lado A *Heap*: " + retangulo2.LadoA);
Console.WriteLine("Retangulo 2 Lado B *Heap*: " + retangulo2.LadoB);

class Retangulo
{
    public int LadoA { get; set; }
    public int LadoB { get; set; }

}