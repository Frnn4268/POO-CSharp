using System;

namespace POO_CS
{
    class Estudiante
    {
        public string nombre;
        public int edad;
        public string carnet;
        public Boolean solvente;
        
        public Estudiante(string nombre, int edad, string carnet, Boolean solvente)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.carnet = carnet;
            this.solvente = solvente;
           
        }
    }
    class Curso{
        public string nombre_curso;
        public int nota_parcial1;
        public int nota_parcial2;
        public int nota_final;

        public Curso(string nombre_curso, int nota_parcial1, int nota_parcial2, int nota_final)
        {
            this.nombre_curso = nombre_curso;
            this.nota_parcial1 = nota_parcial1;
            this.nota_parcial2 = nota_parcial2;
            this.nota_final = nota_final;
        }
    }
}
