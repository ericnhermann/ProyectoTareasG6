using System;

public class Tablero
{
        public Tablero()
        {
            Tareas = new List<Tarea>();
        }

         public List<Tarea> Tareas { get; set; }

       
        public void AgregarTarea(Tarea tarea)
        {
            Tareas.Add(tarea);
        }
    }
}
