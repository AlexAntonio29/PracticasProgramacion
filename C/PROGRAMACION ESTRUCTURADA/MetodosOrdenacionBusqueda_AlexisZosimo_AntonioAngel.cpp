#include <stdlib.h>
#include <stdio.h>
#include <iostream>
#include <time.h>

/*
Alexis Zosimo Antonio Angel
Jeaustin Avick Perez Camacho
Ian Michelle Palacios

*/

using namespace std;

// Constantes
#define MAX 10

// Variables
int A[ MAX ]; // Arreglo de enteros
int N= MAX; // Total de elementos
int hashTable[MAX+1] = {0};
int Dato;

// *** Sección de Prototipos
// Funciones generales
void MenuPrincipal();
void IngresarUsuario();
void IngresarAleatorio();
void MostrarArreglo();
void MostrarTiempo( time_t Inicio, time_t Final );

// Métodos de Ordenación
void BubbleSort( int A[], int N );
void ShakerSort( int A[], int N );
void InsercionDirecta( int A[], int N );
void InsercionBinaria( int A[], int N );
void SeleccionDirecta( int A[], int N );
void Shell( int A[], int N );
void QuickSort( int A[], int Izq, int Der );
void HeapSort( int A[], int N );
void Merge( int A[], int Izq, int Der);

//Metodos secundarios
void Heapify(int A[], int N, int i);
unsigned int hash(int key);

// Métodos de Ordenación
int BusqSec( int A[], int N, int X );
int BusqBin( int A[], int N, int X );
int Hash();


// Implementación de procedimientos y funciones de usuario generales
void IngresarUsuario()
{
  for ( int i=0; i < MAX; i++)
    {
      cout << "Introduce elemento " << i + 1 << ": ";
      cin >> A[i];
    };
};

void IngresarAleatorio()
{
  srand(100);
  for ( int i=0; i < MAX; i++)
      A[i]= rand() % 999;
 };

void MostrarArreglo()
{
  for (int i=0; i<MAX; i++)
      cout << A[i] << " ";
  cout << endl;
  system("Pause");
};

void MostrarTiempo( time_t Inicio, time_t Final )
{
  printf( "Comienzo: %u s\n", Inicio );
  printf( "Final: %u s\n", Final );
  printf( "Número de segundos transcurridos desde el comienzo del programa: %f s\n", difftime( Final, Inicio) ); 
  system("pause");
}

// Implementación de Métodos de Ordenación

// Métodos de Ordenación
void BubbleSort( int A[], int N )
{
    int i, j, temp;
    for (i = 0; i < N - 1; i++) {
        for (j = 0; j < N - i - 1; j++) {
            if (A[j] > A[j + 1]) {
                // Intercambia A[j] y A[j + 1]
                temp = A[j];
                A[j] = A[j + 1];
                A[j + 1] = temp;
            }
        }
    }
    cout << "Arreglo ordenado por el método Burbuja: ";
    MostrarArreglo();
}


void ShakerSort( int A[], int N )
{
    int left = 0, right = N - 1;
    int lastSwap, i, temp;

    while (left < right) {
        // Mover de izquierda a derecha
        lastSwap = 0;
        for (i = left; i < right; i++) {
            if (A[i] > A[i + 1]) {
                temp = A[i];
                A[i] = A[i + 1];
                A[i + 1] = temp;
                lastSwap = i;
            }
        }
        right = lastSwap;

        // Mover de derecha a izquierda
        lastSwap = 0;
        for (i = right; i > left; i--) {
            if (A[i] < A[i - 1]) {
                temp = A[i];
                A[i] = A[i - 1];
                A[i - 1] = temp;
                lastSwap = i;
            }
        }
        left = lastSwap;
    }
    cout << "Arreglo ordenado por el método ShakerSort: ";
    MostrarArreglo();
}


void InsercionDirecta( int A[], int N )
{
    int i, j, temp;
    for (i = 1; i < N; i++) {
        temp = A[i];
        j = i - 1;

        // Desplazar los elementos mayores a la derecha
        while (j >= 0 && A[j] > temp) {
            A[j + 1] = A[j];
            j--;
        }
        A[j + 1] = temp;
    }
    cout << "Arreglo ordenado por el método de Inserción Directa: ";
    MostrarArreglo();
}

    
void InsercionBinaria( int A[], int N )
{
    int i, j, temp, left, right, mid;

    for (i = 1; i < N; i++) {
        temp = A[i];
        left = 0;
        right = i - 1;

        // Búsqueda binaria para encontrar la posición de inserción
        while (left <= right) {
            mid = (left + right) / 2;
            if (A[mid] > temp)
                right = mid - 1;
            else
                left = mid + 1;
        }

        // Desplazar los elementos hacia la derecha
        for (j = i - 1; j >= left; j--) {
            A[j + 1] = A[j];
        }

        // Insertar el elemento en su posición correcta
        A[left] = temp;
    }

    cout << "Arreglo ordenado por el método de Inserción Binaria: ";
    MostrarArreglo();
}


void SeleccionDirecta( int A[], int N )
{
    int i, j, minIndex, temp;

    for (i = 0; i < N - 1; i++) {
        // Encontrar el índice del valor mínimo en el subarreglo
        minIndex = i;
        for (j = i + 1; j < N; j++) {
            if (A[j] < A[minIndex]) {
                minIndex = j;
            }
        }

        // Intercambiar el elemento mínimo con el primer elemento del subarreglo
        if (minIndex != i) {
            temp = A[i];
            A[i] = A[minIndex];
            A[minIndex] = temp;
        }
    }

    cout << "Arreglo ordenado por el método de Selección Directa: ";
    MostrarArreglo();
}


void Shell( int A[], int N )
{
    int gap, i, j, temp;

    // Comienza con un "gap" grande, y luego reduce el tamaño del gap
    for (gap = N / 2; gap > 0; gap /= 2) {
        // Realiza una inserción directa pero en elementos separados por el gap
        for (i = gap; i < N; i++) {
            temp = A[i];
            for (j = i; j >= gap && A[j - gap] > temp; j -= gap) {
                A[j] = A[j - gap];
            }
            A[j] = temp;
        }
    }

    cout << "Arreglo ordenado por el método Shell: ";
    MostrarArreglo();
}


void QuickSort( int A[], int Izq, int Der )
{
    int i = Izq, j = Der;
    int pivot = A[(Izq + Der) / 2]; // Elegir el pivote

    // Partición
    while (i <= j) {
        // Encontrar un elemento mayor que el pivote en la izquierda
        while (A[i] < pivot) i++;
        // Encontrar un elemento menor que el pivote en la derecha
        while (A[j] > pivot) j--;

        if (i <= j) {
            // Intercambiar A[i] y A[j]
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
            i++;
            j--;
        }
    }

    // Llamada recursiva para los subarreglos
    if (Izq < j) QuickSort(A, Izq, j);
    if (i < Der) QuickSort(A, i, Der);
    
    
}



void Heapify(int A[], int N, int i)
{
    int largest = i; // Inicializar el nodo raíz como el más grande
    int left = 2 * i + 1; // Hijo izquierdo
    int right = 2 * i + 2; // Hijo derecho

    // Si el hijo izquierdo es más grande que la raíz
    if (left < N && A[left] > A[largest])
        largest = left;

    // Si el hijo derecho es más grande que el más grande hasta ahora
    if (right < N && A[right] > A[largest])
        largest = right;

    // Si el más grande no es la raíz
    if (largest != i) {
        // Intercambiar
        int temp = A[i];
        A[i] = A[largest];
        A[largest] = temp;

        // Recursivamente hacer heapify en el subárbol afectado
        Heapify(A, N, largest);
    }
}

void HeapSort(int A[], int N)
{
    // Construir el heap (reorganizar el arreglo)
    for (int i = N / 2 - 1; i >= 0; i--)
        Heapify(A, N, i);

    // Extraer elementos del heap uno por uno
    for (int i = N - 1; i >= 0; i--) {
        // Mover la raíz actual al final
        int temp = A[0];
        A[0] = A[i];
        A[i] = temp;

        // Llamar a heapify en el heap reducido
        Heapify(A, i, 0);
    }

    cout << "Arreglo ordenado por el método HeapSort: ";
    MostrarArreglo();
}


void Merge(int A[], int Izq, int Der)
{
    if (Izq < Der) {
        int Mid = (Izq + Der) / 2;

        // Ordenar la primera y segunda mitad
        Merge(A, Izq, Mid);
        Merge(A, Mid + 1, Der);

        // Fusionar las mitades ordenadas
        int n1 = Mid - Izq + 1;
        int n2 = Der - Mid;

        // Crear arreglos temporales
        int L[n1], R[n2];

        // Copiar datos a los arreglos temporales L[] y R[]
        for (int i = 0; i < n1; i++)
            L[i] = A[Izq + i];
        for (int j = 0; j < n2; j++)
            R[j] = A[Mid + 1 + j];

        // Fusionar los arreglos temporales de nuevo en A[Izq..Der]
        int i = 0, j = 0, k = Izq;

        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                A[k] = L[i];
                i++;
            } else {
                A[k] = R[j];
                j++;
            }
            k++;
        }

        // Copiar los elementos restantes de L[], si quedan
        while (i < n1) {
            A[k] = L[i];
            i++;
            k++;
        }

        // Copiar los elementos restantes de R[], si quedan
        while (j < n2) {
            A[k] = R[j];
            j++;
            k++;
        }
    }
}



// Implementación de Métodos de Búsqueda
int BusqSec( int A[], int N, int X )
{
  int i=0;

  while ( (i<N) && (A[i]!= X) ) 
    i++;
    
  if (i>=N)  
     return -1;
  else 
     return i;	
}

int BusqBin( int A[], int N, int X )
{
        int izquierda = 0;
    int derecha = N - 1;

    while (izquierda <= derecha) {
        int medio = izquierda + (derecha - izquierda) / 2; // Calcular el índice medio

        // Verificar si X está presente en medio
        if (A[medio] == X) {
            return medio; // Retornar la posición del elemento encontrado
        }

        // Si X es mayor, ignorar la mitad izquierda
        if (A[medio] < X) {
            izquierda = medio + 1;
        }
        // Si X es menor, ignorar la mitad derecha
        else {
            derecha = medio - 1;
        }
    }

    return -1; // Retornar -1 si el elemento no se encuentra
}

 int h(int key) {
    return key % MAX; // Modulo con el tamaño del arreglo
}

int Hash() {
	
	
 int index = h(Dato);	
// Busca el elemento en el arreglo
    for (int i = 0; i < MAX; i++) {
        // Calcula el índice real a comprobar
        int currentIndex = (index + i) % MAX; // Manejo de colisiones
        if (A[currentIndex] == Dato) {
            return currentIndex; // Retorna el índice si encuentra el valor
        }
    }
    return -1;
}

void MenuPrincipal()
{ // Variables locales
  char Opc;   // Variable auxiliar Opcion
  int X, Y;
  time_t Inicio, Final;
 
  do {
     system("cls");
     cout << "**** Metodos de Ordenacion y Busqueda. " << endl;
     cout << "1. Introducir valores Usuario. " << endl;
     cout << "2. Introducir valores aleatoriamente. " << endl;
     cout << "3. Mostrar Arreglo. " << endl << endl;

     cout << "**** Algoritmos de Ordenacion. " << endl;
     cout << "4. Por Intercambio Directo (Burbuja). " << endl;
     cout << "5. Metodo de la Sacudida (ShakerSort). " << endl;
     cout << "6. Metodo de Insercion Directa. " << endl;
     cout << "7. Metodo de Insercion Binaria. " << endl;
     cout << "8. Metodo de Seleccion Directa. " << endl;
     cout << "9. Shell. " << endl;
     cout << "A. QuickSort. " << endl;
     cout << "B. Monticulo (HeapSort). " << endl;
     cout << "C. Intercalacion de archivos (Merge). " << endl << endl;

     cout << "**** Algoritmos de Busqueda. " << endl;
     cout << "D. Busqueda Secuencia." << endl;
     cout << "E. Busqueda Binaria." << endl;
     cout << "F. Hash." << endl;
     cout << "0. Salir " << endl << endl;
     cout << "Opcion: "; cin >> Opc;

     switch (Opc) {
       case '1': IngresarUsuario(); break;
       case '2': IngresarAleatorio(); break;
       case '3': MostrarArreglo(); break;
       //----------------------------------------------
       case '4': BubbleSort( A, N ); break;
       case '5': ShakerSort( A, N ); break;
       case '6': InsercionDirecta( A, N ); break;

       case '7': // Inserción Binaria 
	             Inicio= time(NULL); // Tiempo inicial o actual
	             InsercionBinaria( A, N ); // Llamada al Método de Ordenación
				 Final= time(NULL);    // Tiempo final o actual
                
				 MostrarTiempo( Inicio, Final ); // Muestra tiempo transcurrido
	             break;
       
       case '8': SeleccionDirecta( A, N ); break;
       case '9': Shell( A, N ); break;
       case 'A': QuickSort( A, 0, MAX-1 ); MostrarArreglo(); break;
       case 'B': HeapSort( A, N ); break;
       case 'C': Merge( A, 0, MAX-1 ); MostrarArreglo(); break;
       //----------------------------------------------
       case 'D': // Método de Búsqueda Secuencial
	    	     cout << "Escriba valor a buscar: ";
                 cin >> X;

	             Inicio= time(NULL); // Tiempo inicial o actual
	             Y= BusqSec( A, N, X ); // llamada al Método de Busqueda
				 Final= time(NULL);    // Tiempo final o actual

				 printf("La posicion encontrada fue %i \n", Y); 
				 MostrarTiempo( Inicio, Final ); // Muestra tiempo transcurrido
	             break;      
	             
       case 'E':
	    cout << "Escriba valor a buscar: ";
                 cin >> Dato;

	             Inicio= time(NULL); // Tiempo inicial o actual
	             Y=  BusqBin( A, N, Dato ); // llamada al Método de Busqueda
				 Final= time(NULL);    // Tiempo final o actual

				 printf("La posicion encontrada fue %i \n", Y); 
				 MostrarTiempo( Inicio, Final );
	   
	    break;
       case 'F':
       	cout<<"Escriba valor a buscar: ";
                 cin >> Dato;
	   			int Y=Hash();
				 Final= time(NULL);    // Tiempo final o actual

				 printf("La posicion encontrada fue %i \n", Y); 
				 MostrarTiempo( Inicio, Final );
                
                
                
	   
	  break;
     };

  } while (Opc!='0');
};

// Programa o función principal del programa
int main()
{
  MenuPrincipal();
  return 0;
};


