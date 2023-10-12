using System;

public class Usuario
{
    public Usuario (string nombre, string apellido, string institucion, string mail) {
        Nombre = nombre;
        Apellido = apellido;
        Institucion = institucion;
        Mail = mail;

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Institucion { get; set; }
    public string Mail { get; set; }
}

