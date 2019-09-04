using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Lambiscadas.Clases.Usuario
{
    public class Usuario
    {

        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string token { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string CP { get; set; }


        public bool Valido
        {
            get
            {
                return idUsuario > 0;
            }
        }


        public Usuario(string token)
        {
            if (!UsuarioValidoPorToken(Utilities.tratarParam(token)))
                this.idUsuario = -1;
        }

        public Usuario()
        {
            idUsuario = -1;
            Nombre = token = Apellidos = Email = Contraseña = Telefono = DNI = string.Empty;
        }

        public Usuario(int idUsuario)
        {
            if (idUsuario > 0)
                if (!UsuarioValidoPorID(idUsuario))
                    idUsuario = -1;
                else
                    idUsuario = -1;
        }


        private bool UsuarioValidoPorToken(string token)
        {
            bool correcto = false;
            try
            {
                if (token.Contains('I'))
                {
                    token = token.Split('I')[1];
                }

                string query = $@"SELECT TOP 1 usu.idUsuario, usu.Nombre, usu.Apellidos, usu.DNI, usu.Telefono, usu.Email, usu.Direccion, usu.CP, usu.Password, usu.token FROM Usuarios usu where usu.token = '{token}'";
                DataTable dt = DatabaseConnection.executeNonQueryDT(query, CommandType.Text, ConnectionString.Lambiscadas);
                string respuesta = dt.DataTabletoJSONObject();
                if (!string.IsNullOrEmpty(respuesta))
                {
                    //Obtenemos los datos de usuario
                    JObject resp = JObject.Parse(respuesta);
                    this.idUsuario = (int)resp.SelectToken("idUsuario");
                    this.Nombre = (string)resp.SelectToken("Nombre");
                    this.Apellidos = (string)resp.SelectToken("Apellidos");
                    this.DNI = (string)resp.SelectToken("DNI");
                    this.Telefono = (string)resp.SelectToken("Telefono");
                    this.Email = (string)resp.SelectToken("Email");
                    this.Direccion = (string)resp.SelectToken("Direccion");
                    this.CP = (string)resp.SelectToken("CP");
                    this.Contraseña = (string)resp.SelectToken("Password");
                    this.token = token;
                    //OK
                    correcto = true;
                }
            }
            catch (Exception e)
            {
                correcto = false;
            }
            return correcto;
        }


        private bool UsuarioValidoPorID(int idUsuario)
        {
            bool correcto = false;
            string query = $@"SELECT TOP 1 usu.idUsuario, usu.Nombre, usu.Apellidos, usu.DNI, usu.Telefono, usu.Email, usu.Direccion, usu.CP, usu.Password, usu.token FROM Usuarios usu where usu.idUsuario = {idUsuario}";
            DataTable dt = DatabaseConnection.executeNonQueryDT(query, CommandType.Text, ConnectionString.Lambiscadas);
            string respuesta = dt.DataTabletoJSONObject();
            if (!string.IsNullOrEmpty(respuesta))
            {
                //Obtenemos los datos de usuario
                JObject resp = JObject.Parse(respuesta);
                this.idUsuario = (int)resp.SelectToken("idUsuario");
                this.Nombre = (string)resp.SelectToken("Nombre");
                this.Apellidos = (string)resp.SelectToken("Apellidos");
                this.DNI = (string)resp.SelectToken("DNI");
                this.Telefono = (string)resp.SelectToken("Telefono");
                this.Email = (string)resp.SelectToken("Email");
                this.Direccion = (string)resp.SelectToken("Direccion");
                this.CP = (string)resp.SelectToken("CP");
                this.Contraseña = (string)resp.SelectToken("Password");
                this.token = token;
                //OK
                correcto = true;
            }
            return correcto;
        }

        public static bool updateGuid(int idUsuario, string guid)
        {
            try
            {
                string query = $@"UPDATE Usuarios SET token='{guid}' WHERE idAdmin={idUsuario}";
                return (DatabaseConnection.executeNonQueryInt(query, CommandType.Text, ConnectionString.Lambiscadas) == 1);
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}