﻿    int coordinate1, coordinate2;

    Console.Clear();
    Console.WriteLine("*** Bem Vindo ao Quadrante Cartesiano ***");
    Console.ResetColor();

    Console.WriteLine("Onde se encontra a coordenada X? ");
    coordinate1 = int.Parse(Console.ReadLine()!);
      
    Console.WriteLine("Onde se encontra a coordenada Y? ");
    coordinate2 = int.Parse(Console.ReadLine()!);


    if (coordinate1 > 0 && coordinate2 > 0)
    {

        Console.WriteLine("*** Quadrante Cartesiano ***");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");
        
        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no 1º quadrante");
    }

    if (coordinate1 < 0 && coordinate2 > 0)
    {


        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no 2º quadrante");
    }

    if (coordinate1 < 0 && coordinate2 < 0)
    {


        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();
        
        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no 3º quadrante");
    }
    if (coordinate1 > 0 && coordinate2 < 0)
    {

        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no 4º quadrante");
    }

    if (coordinate1 == 0 && coordinate2 == 0)
    {
        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica na origem");
    }

    if (coordinate1 != 0 && coordinate2 == 0)
    {

        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no eixo das abscissas");
    }

    if (coordinate1 == 0 && coordinate2 != 0)
    {

        Console.WriteLine("--- Quadrante Cartesiano ---");
        Console.WriteLine();

        Console.WriteLine($"Coordenada x: {coordinate1}");
        Console.WriteLine($"Coordenada y: {coordinate2}");

        Console.WriteLine();

        Console.WriteLine($"O ponto ({coordinate1}, {coordinate2}) fica no eixo das ordenadas");
    }


    