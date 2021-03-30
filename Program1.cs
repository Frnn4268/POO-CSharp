using System;

namespace POO_CS
{
    class Program
    {
        static void Main()
        {
            Estudiante[] listaEstudiantes = new Estudiante [5];
            Curso[] listaCurso = new Curso[5];

            int cont = 0;

            while (cont < 5){
                Console.WriteLine("Ingrese nombre");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese edad");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese carnet");
                string carnet = Console.ReadLine();

                Console.WriteLine("Indique si está solvente");
                Boolean solvente = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Ingrese nombre de curso");
                string nombre_curso = Console.ReadLine();

                Console.WriteLine("Ingrese nota del parcial 1");
                int nota_parcial1 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Ingrese nota del parcial 2");
                int nota_parcial2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese nota final");
                int nota_final = Convert.ToInt32(Console.ReadLine());

                Estudiante estudiante = new Estudiante(nombre, edad, carnet, solvente);
                listaEstudiantes[cont] = estudiante;

                Curso curso = new Curso(nombre_curso, nota_parcial1, nota_parcial2, nota_final);
                listaCurso[cont] = curso;
                cont++;
            }

            Console.WriteLine("LISTA");

            for (int i = 0; i < 5; i++){
                Estudiante estudiante = listaEstudiantes[i];

                Curso curso = listaCurso[i];

                Console.WriteLine(" Nombre estudiante |" + estudiante.nombre + "| Edad |" + estudiante.edad + "| Carnet |" + estudiante.carnet + "| Solvencia |" + estudiante.solvente + "|");
                Console.WriteLine(" Nombre del curso |" + curso.nombre_curso + "| Nota parcial 1 |" + curso.nota_parcial1 + "| Nota parcial 2 |" + curso.nota_parcial2 + "| Nota final |" + curso.nota_final + "|");
                Console.WriteLine("");
            }
        }
    }
}