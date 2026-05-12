using arbolbusqbin;

Nodo raiz = new Nodo(15)
{
    Izq = new Nodo(9)
    {
        Izq = new Nodo(6),
        Der = new Nodo(14)
        {
            Izq = new Nodo(13)
        }
    },
    Der = new Nodo(20)
    {
        Izq = new Nodo(17),
        Der = new Nodo(64)
        {
            Izq = new Nodo(26),
            Der = new Nodo(72)
        }
    }
};

static void Preorden(Nodo? nodo)
{
    if (nodo == null) return;

    Console.Write($"{nodo.Dato} ");
    Preorden(nodo.Izq);             
    Preorden(nodo.Der); 
}

static void Inorden(Nodo? nodo)
{
    if (nodo == null) return;

    Inorden(nodo.Izq);              
    Console.Write($"{nodo.Dato} "); 
    Inorden(nodo.Der);              
}

static void Posorden(Nodo? nodo)
{
    if (nodo == null) return;

    Posorden(nodo.Izq);           
    Posorden(nodo.Der);           
    Console.Write($"{nodo.Dato} "); 
}

Console.WriteLine("--- Recorridos del arbol ---");

Console.Write("Preorden: ");
Preorden(raiz);
Console.WriteLine();

Console.Write("Inorden:  ");
Inorden(raiz);
Console.WriteLine();

Console.Write("Posorden: ");
Posorden(raiz);
Console.WriteLine();