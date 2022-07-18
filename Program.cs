using System;

namespace T09_Ejercicio7
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string dni;
        //No sé si era esta forma como pedía el ejercicio la constante.
        private string sexo = "H";
        private double peso;
        private double altura;

        public Persona()
        {
            nombre = "";
            edad = 0;
            peso = 0;
            altura = 0;
        }

        public Persona(string nombreConstr, int edadConstr, string sexoConstr)
        {
            nombre = nombreConstr;
            edad = edadConstr;
            sexo = sexoConstr;
            peso = 0;
            altura = 0;
        }

        public Persona(string nombreConstr, int edadConstr, string dniConstr, string sexoConstr, double pesoConstr, double alturaConstr)
        {
            nombre = nombreConstr;
            edad = edadConstr;
            sexo = sexoConstr;
            peso = pesoConstr;
            altura = alturaConstr;
            dni = dniConstr;
        }
    }
}