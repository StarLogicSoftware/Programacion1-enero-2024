
// crear matriz de asientos
string[,] asientos = new string[3,10];

// cargamos la matriz con "L"
for (int fila = 0; fila < 3; fila++)
{
	for (int columna = 0; columna < 10; columna++)
	{
        asientos[fila, columna] = "L";
    }
}

// mostrar todos los asientos
for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 10; columna++)
    {
        //Console.Write( asientos[fila, columna] ); // forma facil
        Console.Write($" {asientos[fila, columna]} "); // con interpolacion
    }

    Console.WriteLine();
}
