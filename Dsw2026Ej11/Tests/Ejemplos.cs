using System;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();
        var a1 = new Alumno(100, "Carlos", 8.5);
        var a2 = new Alumno(101, "Sofia", 9.2);
        var a3 = new Alumno(102, "Miguel", 7.0);

        // Agregar 3 alumnos a la lista
        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        // Listar por consola los alumnos
        Console.WriteLine("--- Lista Inicial de Alumnos ---");
        foreach (var al in casoList.ObtenerTodos()) Console.WriteLine(al);

        // Buscar por nombre un alumno que exista
        Console.WriteLine("\n--- Buscar Alumno: Sofia ---");
        var sofia = casoList.BuscarPorNombre("Sofia");
        Console.WriteLine(sofia != null ? sofia.ToString() : "No existe");

        // Buscar por nombre un alumno que no exista
        Console.WriteLine("\n--- Buscar Alumno: Ana ---");
        var ana = casoList.BuscarPorNombre("Ana");
        Console.WriteLine(ana != null ? ana.ToString() : "No existe");

        // Eliminar un alumno y listar
        Console.WriteLine("\n--- Eliminar a Carlos ---");
        casoList.EliminarAlumno(a1);
        foreach (var al in casoList.ObtenerTodos()) Console.WriteLine(al);

        // Eliminar el primer elemento y listar
        Console.WriteLine("\n--- Eliminar el primer elemento (Sofia) ---");
        casoList.EliminarEnPosicion(0);
        foreach (var al in casoList.ObtenerTodos()) Console.WriteLine(al);
    }

    public static void EjemploDictionary()
    {
        CasoDictionary casoDict = new CasoDictionary();
        var a1 = new Alumno(200, "Lucia", 8.8);
        var a2 = new Alumno(201, "Martin", 6.5);
        var a3 = new Alumno(202, "Valeria", 9.8);

        // Agregar 3 alumnos al diccionario
        casoDict.AgregarAlumno(200, a1);
        casoDict.AgregarAlumno(201, a2);
        casoDict.AgregarAlumno(202, a3);

        // Listar por consola
        Console.WriteLine("--- Diccionario Inicial ---");
        foreach (var kvp in casoDict.ObtenerTodos())
            Console.WriteLine($"Clave: {kvp.Key} -> {kvp.Value}");

        // Buscar alumno por clave
        Console.WriteLine("\n--- Buscar Clave 201 ---");
        var encontrado = casoDict.BuscarPorClave(201);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        // Buscar alumno por clave inexistente
        Console.WriteLine("\n--- Buscar Clave 999 ---");
        var noEncontrado = casoDict.BuscarPorClave(999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        // Eliminar por clave y listar
        Console.WriteLine("\n--- Eliminar Clave 200 ---");
        casoDict.EliminarPorClave(200);
        foreach (var kvp in casoDict.ObtenerTodos())
            Console.WriteLine($"Clave: {kvp.Key} -> {kvp.Value}");
    }

    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();
        Console.WriteLine("--- Consultas LINQ ---");

        Console.WriteLine($"1. Primer libro: {casoLinq.GetPrimero().Titulo}");
        Console.WriteLine($"2. Último libro: {casoLinq.GetUltimo().Titulo}");
        Console.WriteLine($"3. Suma total de precios: {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"4. Promedio de precios: {casoLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\n5. Libros con Id > 15:");
        foreach (var lib in casoLinq.GetListById()) Console.WriteLine($"   - {lib.Titulo}");

        Console.WriteLine("\n6. Lista de Libros (Título y Precio Moneda):");
        foreach (var libStr in casoLinq.GetLibros()) Console.WriteLine($"   {libStr}");

        Console.WriteLine($"\n7. Libro más caro: {casoLinq.GetMayorPrecio().Titulo}");
        Console.WriteLine($"8. Libro más barato: {casoLinq.GetMenorPrecio().Titulo}");

        Console.WriteLine("\n9. Libros con precio mayor al promedio:");
        foreach (var lib in casoLinq.GetMayorPromedio()) Console.WriteLine($"   - {lib.Titulo} ({lib.Precio:C})");

        Console.WriteLine("\n10. Libros ordenados por título descendente (Primeros 5 para resumir):");
        // Mostramos solo los primeros 5 para que la consola no sea infinita, pero el método retorna todos
        foreach (var lib in casoLinq.GetOrdenadosPorTituloDesc().Take(5))
            Console.WriteLine($"   - {lib.Titulo}");
    }
}