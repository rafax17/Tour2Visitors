using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// clase de conexión de los usuarios con la base de datos
/// </summary>
public class conexion
{

    protected SqlDataAdapter adaptadorDatos;
    protected SqlDataReader reader;
    protected DataSet Data;
    protected SqlConnection oconexion = new SqlConnection();

	public conexion()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
    public void conectar(string tabla)
    {
        string strConexion = ConfigurationManager.ConnectionStrings["tour2visitorsConnectionString"].ConnectionString;
        oconexion.ConnectionString = strConexion;
        oconexion.Open();
        adaptadorDatos = new SqlDataAdapter("select * from" + tabla, oconexion);
        SqlCommandBuilder ejecutaComandos = new SqlCommandBuilder(adaptadorDatos);
        Data = new DataSet();
        adaptadorDatos.Fill(Data, tabla);
        oconexion.Close();

    }
    public DataSet data
    {
        set { data = value; }
        get { return data; }
    }
    public SqlDataReader DataReader
    {
        set { reader = value; }
        get { return reader; }
    }
}