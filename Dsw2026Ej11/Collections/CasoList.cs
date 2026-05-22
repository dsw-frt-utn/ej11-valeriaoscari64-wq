using System.Collections.Generic;
using System.Linq;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista


public class CasoList
{
    // Crear un campo que represente una lista de alumnos
    private List<Alumno> alumnos = new List<Alumno>();

    // Incluir un método para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    // Incluir un método para retornar la lista
    public List<Alumno> ObtenerTodos()
    {
        return alumnos;
    }

    // Incluir un método para buscar un alumno por nombre
    public Alumno? BuscarPorNombre(string nombre)
    {
        return alumnos.FirstOrDefault(a => a.Nombre.Equals(nombre, System.StringComparison.OrdinalIgnoreCase));
    }

    // Incluir un método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }

    // Incluir un método para eliminar un alumno en una determinada posición de la lista
    public void EliminarEnPosicion(int index)
    {
        if (index >= 0 && index < alumnos.Count)
        {
            alumnos.RemoveAt(index);
        }
    }
}