using System;

public class Tarea
{
    public Tarea(string texto)
    {
        Texto = texto;
        SubTarea = new List<SubTarea>();
    }
}

public string Text { get; set; }

    public List<SubTarea> SubTarea { get; set; }

	}

     public void AgregarSubTarea(SubTarea subTarea)
{
    SubTareas.Add(subTarea);
}
}
}
