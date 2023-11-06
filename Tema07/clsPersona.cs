using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class clsPersona
    {
        //Cambiar el internal por public siempre
        #region Atributos

        private string nombre;
        private string apellido;

        #endregion

        #region Constructor
        public clsPersona()
        {
            this.nombre = "";
            this.apellido = "";
        }
        public clsPersona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Dirección { get; set; }
        public string NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }
        #endregion

        #region Metodos y Funciones
        /// <summary>
        /// Funcion que devuelve la concatenacion del nombre y el apellido de la persona
        /// Precondicion: nombre y apellido deben ser distintos de null
        /// Postcondicion: devuelve la concatenacion del nombre y el apellido con un espacio en blanco entre ellos
        /// </summary>
        /// <returns></returns>
        public string ObtenerNombreCompleto()
        {
            return $"{nombre} {apellido}";
        }

        #endregion
    }
}
