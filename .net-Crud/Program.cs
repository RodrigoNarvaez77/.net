using System; // Permite usar clases básicas del espacio de nombres System, como Console.
using System.Collections.Generic; // Permite usar colecciones genéricas como List<T>.

namespace FormularioConsola
{
    class Program
    {
        // Declaración de una lista estática para almacenar los nombres ingresados.
        static List<string> nombres = new List<string>();

        // Método principal, punto de entrada de la aplicación de consola.
        static void Main(string[] args)
        {
            // Bucle infinito que continuará ejecutándose hasta que el usuario elija salir.
            while (true)
            {
                Console.Clear(); // Limpia la pantalla de la consola para mostrar el menú limpio.
                
                // Muestra el menú con opciones al usuario.
                Console.WriteLine("Formulario de Consola");
                Console.WriteLine("1. Agregar Nombre");
                Console.WriteLine("2. Mostrar Nombres");
                Console.WriteLine("3. Modificar Nombres");
                Console.WriteLine("4. Eliminar Nombre");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                // Lee la opción que el usuario ingresa desde la consola.
                string opcion = Console.ReadLine();

                // Utiliza una instrucción switch para manejar la opción seleccionada.
                switch (opcion)
                {
                    // Si la opción es "1", llama al método AgregarNombre para ingresar un nuevo nombre.
                    case "1":
                        AgregarNombre();
                        break;

                    // Si la opción es "2", llama al método MostrarNombres para mostrar la lista de nombres.
                    case "2":
                        MostrarNombres();
                        break;

                    // Si la opción es "3", sale del método Main y termina el programa.
                    case "3":
                        EditarNombre();
                        break;

                    case "4":
                        EliminarNombre();
                        break;

                    case "5":// 
                        return;
                    // Si la opción no es válida, muestra un mensaje de error.
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
        }

        // Método para agregar un nombre a la lista.
        static void AgregarNombre()
        {
            Console.Clear(); // Limpia la pantalla de la consola para mostrar el formulario de ingreso de nombre.
            Console.Write("Ingresa el nombre a agregar: "); // Solicita al usuario que ingrese un nombre.
            string nombre = Console.ReadLine(); // Lee el nombre ingresado por el usuario.
            nombres.Add(nombre); // Agrega el nombre a la lista.
            Console.WriteLine("Nombre agregado correctamente."); // Informa al usuario que el nombre ha sido agregado.
            Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla para continuar.
            Console.ReadKey(); // Espera a que el usuario presione una tecla.
        }

        // Método para mostrar la lista de nombres.
        static void MostrarNombres()
        {
            Console.Clear(); // Limpia la pantalla de la consola para mostrar la lista de nombres.
            Console.WriteLine("Lista de Nombres:"); // Muestra el encabezado de la lista de nombres.
            if (nombres.Count == 0) // Verifica si la lista de nombres está vacía.
            {
                Console.WriteLine("No hay nombres para mostrar."); // Informa al usuario que no hay nombres en la lista.
            }
            else
            {
                // Itera a través de la lista de nombres y muestra cada uno.
                for (int i = 0; i < nombres.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {nombres[i]}"); // Muestra el nombre con su índice.
                }
            }
            Console.WriteLine("Presiona cualquier tecla para continuar..."); // Indica al usuario que presione una tecla para continuar.
            Console.ReadKey(); // Espera a que el usuario presione una tecla.
        }

static void EditarNombre()
{
    Console.Clear();
    Console.WriteLine("Seleccionar número de nombre a modificar:");

    // Verificar si la lista de nombres está vacía
    if (nombres.Count == 0)
    {
        Console.WriteLine("No hay nombres disponibles para modificar.");
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
        return;
    }

    // Mostrar la lista de nombres con índices
    for (int i = 0; i < nombres.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {nombres[i]}");
    }

    // Capturar la entrada del usuario para seleccionar un nombre
    Console.Write("Ingresa el número del nombre a modificar: ");
    int indice = int.Parse(Console.ReadLine());

    // Obtener el índice correcto (ajustando para 0 basado)
    int posicion = indice - 1;

    // Solicitar el nuevo nombre
    Console.Write("Ingresa el nuevo nombre: ");
    string nuevoNombre = Console.ReadLine();

    // Modificar el nombre en la lista
    nombres[posicion] = nuevoNombre;

    Console.WriteLine("Nombre modificado correctamente.");
    Console.WriteLine("Presiona cualquier tecla para continuar...");
    Console.ReadKey();
}

static void EliminarNombre(){
    Console.Clear();
    if (nombres.Count == 0)
            {
                Console.WriteLine("No hay nombres disponibles para Eliminar.");
                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                return;
            }
    else {
            for (int i = 0; i < nombres.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {nombres[i]}");
                }
    Console.WriteLine("Seleccione un nombre a eliminar");
    int indice = int.Parse(Console.ReadLine());
    //Console.WriteLine(indice);
    int posicion = indice - 1;
    nombres.RemoveAt(posicion);
    Console.WriteLine("Registro Eliminado Correctamente");
    }
    Console.ReadKey();
    }


    }
}