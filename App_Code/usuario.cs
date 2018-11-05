using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Clase del objeto usuario
/// </summary>
public class usuarioo : conexion
{
    // declarar las variables globales
    string tabla = "Usuario";
    protected string nombre, apellidos, contraseña, usuario, telefono, correo, descripcion, tipoUsuario, estadoConfEmail, codigoActivacion;

    // constructor de la clase usuario
    public usuarioo(string nombre, string apellidos, string contraseña, string usuario, string telefono, string correo, string descripcion, string tipoUsuario, string estadoConfEmail, string codigoActivacion)
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.contraseña = contraseña;
        this.usuario = usuario;
        this.telefono = telefono;
        this.correo = correo;
        this.descripcion = descripcion;
        this.tipoUsuario = tipoUsuario;
        this.estadoConfEmail = estadoConfEmail;
        this.codigoActivacion = codigoActivacion;

    }

    // métodos de la clase
    public string Nombre
    {
        set { nombre = value; }
        get { return nombre; }
    }
    public string Apellidos
    {
        set { apellidos = value; }
        get { return apellidos; }
    }

    public string Contraseña
    {
        set { contraseña = value; }
        get { return contraseña; }
    }
    public string Usuario
    {
        set { usuario = value; }
        get { return usuario; }
    }
    public string Telefono
    {
        set { telefono = value; }
        get { return telefono; }
    }
    public string Correo
    {
        set { correo = value; }
        get { return correo; }
    }
    public string Descripcion
    {
        set { descripcion = value; }
        get { return descripcion; }
    }
    public string TipoUsuario
    {
        set { tipoUsuario = value; }
        get { return tipoUsuario; }
    }
    public string EstadoConfEmail
    {
        set { estadoConfEmail = value; }
        get { return estadoConfEmail; }
    }
    public string CodigoActivacion
    {
        set { codigoActivacion = value; }
        get { return codigoActivacion; }
    }
    // metodos de manipulación de datos
    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["nombre"] = Nombre;
        fila["apellidos"] = Apellidos;
        fila["contraseña"] = Contraseña;
        fila["usuario"] = Usuario;
        fila["telefono"] = Telefono;
        fila["correo"] = Correo;
        fila["descripcion"] = Descripcion;
        fila["tipoUsuario"] = TipoUsuario;
        fila["estadoConfEmail"] = EstadoConfEmail;
        fila["codigoActivacion"] = CodigoActivacion;

        Data.Tables[tabla].Rows.Add(fila);
        adaptadorDatos.Update(Data, tabla);

    }
    public bool login(string usu, string pass){

        conectar(tabla);
        DataRow fila;

        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i= 0; i<=x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];

            if (fila["usuario"].ToString().Trim().ToLower() == usu.Trim().ToLower() &&
                fila["contraseña"].ToString().Trim() == pass.Trim() )
            {
                Nombre = fila["nombre"].ToString();
                Apellidos = fila["apellidos"].ToString();
                Contraseña = fila["contraseña"].ToString();
                Usuario = fila["usuario"].ToString();
                Telefono = fila["telefono"].ToString();
                Correo= fila["correo"].ToString();
                Descripcion= fila["descripcion"].ToString();
                TipoUsuario = fila["tipoUsuario"].ToString();
                EstadoConfEmail = fila["estadoConfEmail"].ToString();
                CodigoActivacion = fila["codigoActivacion"].ToString();
                return true;

            }
        }
        return false;
        
        }

}