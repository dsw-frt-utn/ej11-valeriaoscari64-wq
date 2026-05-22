using System.Collections.Generic;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave

public class CasoDictionary
{
    // Crear un diccionario donde la clave sea el legajo y el valor el alumno
    private Dictionary<int, Alumno> alumnosDiccionario = new Dictionary<int, Alumno>();

    // Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        alumnosDiccionario[legajo] = alumno;
    }

    // Incluir un método para buscar un alumno utilizando la clave
    public Alumno? BuscarPorClave(int legajo)
    {
        
        alumnosDiccionario.TryGetValue(legajo, out Alumno? alumno);
        return alumno;
    }

    // Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerTodos()
    {
        return alumnosDiccionario;
    }

    // Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarPorClave(int legajo)
    {
        alumnosDiccionario.Remove(legajo);
    }
}