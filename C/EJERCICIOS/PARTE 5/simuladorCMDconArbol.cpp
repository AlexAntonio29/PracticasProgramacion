#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#define ARGS 60
#define LIM 40

/*
Alexis Zosimo Antonio Angel
Jeaustin Avik Perez Camacho
 3B

Sistemas Operativos

Simulador CMD
*/

// Estructura de archivos del directorio
struct archivo {
    int id;
    char nombre[20];
    char cont[300];
};

// Nodo de los directorios
struct nodo {
    int id;
    char nombre[20];
    struct archivo archivos[LIM];
    int numArchivos; // Contador de archivos en el directorio
    struct nodo* primerHijo;
    struct nodo* siguienteHermano;
    struct nodo* padre;
};

// Funciones del árbol
struct nodo* crearNodo(int id, const char* nombre, struct nodo* padre);
void agregarHijo(struct nodo* padre, int id, const char* nombre);
void agregarArchivo(struct nodo* dirActual, int id, const char* nombre);
struct nodo* buscarNodo(struct nodo* raiz, const char* nombre);
void imprimirDirectorio(struct nodo* nodoActual);
void eliminarDirectorio(struct nodo** raiz, const char* nombre);
void cambiarDirectorio(struct nodo** actual, const char* nombre);

// Variables globales
char read[ARGS];
char dirAnterior[ARGS]="";
char dir[ARGS] = "C:";
char instruccion[10];
struct nodo* directorioActual = NULL;  // Apunta al nodo del directorio actual
struct nodo* raiz = NULL;             // Nodo raíz del árbol

// Declaración de funciones
void mostrarContenidoArchivo(struct nodo* dirActual, const char* nombreArchivo);
void detectarInstruccion(char args[]);
int cantidadCaracteres(const char args[]);
int asignarOpcion(char args[]);

// Función principal

void imprimirArbol(struct nodo* raiz, int nivel) {
    if (raiz == NULL) return;

    // Imprimir el nombre del nodo con sangría según el nivel
    for (int i = 0; i < nivel; i++) {
        printf("  ");
    }
    printf("%s\n", raiz->nombre);

    // Recorrer el primer hijo
    imprimirArbol(raiz->primerHijo, nivel + 1);

    // Recorrer el siguiente hermano
    imprimirArbol(raiz->siguienteHermano, nivel);
}
int main() {
    int salida = 0;
    int idActual = 1;

    // Inicializar el árbol de directorios
    raiz = crearNodo(0, "C:", NULL);
    directorioActual = raiz;

    printf("Microsoft Windows [Version 10.0.19045.5131]\n(c) Alexis Corporation. Todos los derechos reservados.\n");

    do {
        printf("\n%s>", dir);
        scanf("%s", read);

        detectarInstruccion(read);

        switch (asignarOpcion(instruccion)) {
            case 1:  // dir
                imprimirDirectorio(directorioActual);
                break;

            case 2:  // cd
            
                char cambiarDir[20];
                scanf("%s", cambiarDir);
                cambiarDirectorio(&directorioActual, cambiarDir);
                break;

            case 3:  // touch
                
                char nuevoArchivo[20];
                scanf("%s", nuevoArchivo);
                agregarArchivo(directorioActual, idActual++, nuevoArchivo);
                break;
			case 4:  // type
   			 char archivoAmostrar[20];
    		scanf("%s", archivoAmostrar);
    		mostrarContenidoArchivo(directorioActual, archivoAmostrar);
    		break;

            case 5:  // mkdir
              
                char nuevoNombre[20];
                scanf("%s", nuevoNombre);
                agregarHijo(directorioActual, idActual++, nuevoNombre);
                break;

            case 6:  // rmdir
               
                char eliminarNombre[20];
                scanf("%s", eliminarNombre);
                eliminarDirectorio(&directorioActual, eliminarNombre);
                break;

            case -1:  // exit
                salida = 1;
                break;
            case 10:
            	 imprimirArbol(raiz, 0);
            	//mostrar
            	
            	break;

            default:
                printf("'%s' no se reconoce como un comando interno o externo.\n", instruccion);
                break;
        }

    } while (salida != 1);

    printf("Saliendo...\n");
    return 0;
}

// Funciones del árbol
struct nodo* crearNodo(int id, const char* nombre, struct nodo* padre) {
    struct nodo* nuevoNodo = (struct nodo*)malloc(sizeof(struct nodo));
    nuevoNodo->id = id;
    strcpy(nuevoNodo->nombre, nombre);
    nuevoNodo->numArchivos = 0;
    nuevoNodo->primerHijo = NULL;
    nuevoNodo->siguienteHermano = NULL;
    nuevoNodo->padre = padre;
    return nuevoNodo;
}

void agregarHijo(struct nodo* padre, int id, const char* nombre) {
    struct nodo* nuevoHijo = crearNodo(id, nombre, padre);
    if (padre->primerHijo == NULL) {
        padre->primerHijo = nuevoHijo;
    } else {
        struct nodo* temp = padre->primerHijo;
        while (temp->siguienteHermano != NULL) {
            temp = temp->siguienteHermano;
        }
        temp->siguienteHermano = nuevoHijo;
    }
    printf("Directorio '%s' creado.\n", nombre);
}

void agregarArchivo(struct nodo* dirActual, int id, const char* nombre) {
    if (dirActual->numArchivos < LIM) {
        struct archivo nuevoArchivo;
        nuevoArchivo.id = id;
        strcpy(nuevoArchivo.nombre, nombre);
        dirActual->archivos[dirActual->numArchivos++] = nuevoArchivo;
        printf("Archivo '%s' creado.\n", nombre);
    } else {
        printf("Límite de archivos alcanzado en el directorio actual.\n");
    }
}

void imprimirDirectorio(struct nodo* nodoActual) {
    if (nodoActual->primerHijo == NULL && nodoActual->numArchivos == 0) {
        printf("El directorio está vacío.\n");
        return;
    }

    struct nodo* temp = nodoActual->primerHijo;
    while (temp != NULL) {
        printf("[DIR] %s\n", temp->nombre);
        temp = temp->siguienteHermano;
    }

    for (int i = 0; i < nodoActual->numArchivos; i++) {
        printf("[FILE] %s\n", nodoActual->archivos[i].nombre);
    }
}

void cambiarDirectorio(struct nodo** actual, const char* nombre) {
    if (strcmp(nombre, "..") == 0) {
        if ((*actual)->padre != NULL) {
            *actual = (*actual)->padre;
            printf("Directorio cambiado a '%s'.\n", (*actual)->nombre);
            if(strcmp(dir,"C:")!=0) {
            	strcpy(dir,dirAnterior);
			}
        } else {
            printf("Ya estás en el directorio raíz.\n");
        }
    } else {
        struct nodo* encontrado = buscarNodo(*actual, nombre);
        if (encontrado != NULL) {
            *actual = encontrado;
            strcpy(dirAnterior,dir);
            strcat(dir,"/");
            strcat(dir,nombre);
            printf("Directorio cambiado a '%s'.\n", nombre);
        } else {
            printf("No se encontró el directorio '%s'.\n", nombre);
        }
    }
}

struct nodo* buscarNodo(struct nodo* raiz, const char* nombre) {
    struct nodo* temp = raiz->primerHijo;
    while (temp != NULL) {
        if (strcmp(temp->nombre, nombre) == 0) {
            return temp;
        }
        temp = temp->siguienteHermano;
    }
    return NULL;
}

void eliminarDirectorio(struct nodo** raiz, const char* nombre) {
    if ((*raiz)->primerHijo == NULL) {
        printf("No hay subdirectorios para eliminar.\n");
        return;
    }

    struct nodo* temp = (*raiz)->primerHijo;
    struct nodo* anterior = NULL;

    while (temp != NULL && strcmp(temp->nombre, nombre) != 0) {
        anterior = temp;
        temp = temp->siguienteHermano;
    }

    if (temp == NULL) {
        printf("No se encontró el directorio '%s'.\n", nombre);
        return;
    }

    if (anterior == NULL) {
        (*raiz)->primerHijo = temp->siguienteHermano;
    } else {
        anterior->siguienteHermano = temp->siguienteHermano;
    }

    free(temp);
    printf("Directorio '%s' eliminado.\n", nombre);
}

// Funciones de detección de comandos
int cantidadCaracteres(const char args[]) {
    int contador = 0;
    while (args[contador] != '\0') {
        contador++;
    }
    return contador;
}

void detectarInstruccion(char args[]) {
    static char palabra[10];
    memset(palabra, 0, sizeof(palabra));

    int i;
    for (i = 0; i < ARGS; i++) {
        if (args[i] == '\0') {
            palabra[i] = '\0';
            strcpy(instruccion, palabra);
            break;
        }
        palabra[i] = args[i];
    }
}


void mostrarContenidoArchivo(struct nodo* dirActual, const char* nombreArchivo) {
    if (dirActual == NULL) {
        printf("Error: No hay un directorio actual válido.\n");
        return;
    }

    for (int i = 0; i < dirActual->numArchivos; i++) {
        if (strcmp(dirActual->archivos[i].nombre, nombreArchivo) == 0) {
            printf("Contenido del archivo '%s':\n", dirActual->archivos[i].nombre);
            printf("%s\n", dirActual->archivos[i].cont); // Mostrar el contenido
            return;
        }
    }

    printf("El archivo '%s' no existe en el directorio actual.\n", nombreArchivo);
}


int asignarOpcion(char args[]) {
    if (strcmp(args, "dir") == 0) return 1;
    if (strcmp(args, "cd") == 0) return 2;
    if (strcmp(args, "type") == 0) return 4;
    if (strcmp(args, "touch") == 0) return 3;
    if (strcmp(args, "mkdir") == 0) return 5;
    if (strcmp(args, "rmdir") == 0) return 6;
    if (strcmp(args, "exit") == 0) return -1;
    if (strcmp(args, "mostrar") == 0) return 10;
    
    return 0;
}
