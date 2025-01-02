#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Definir la estructura del nodo
struct nodo {
    int id;
    char nombre[20];
    struct nodo* padre;            // Nodo padre
    struct nodo* primerHijo;       // Primer subdirectorio (hijo)
    struct nodo* siguienteHermano; // Siguiente nodo hermano
};

// Función para crear un nuevo nodo
struct nodo* crearNodo(int id, const char* nombre, struct nodo* padre) {
    struct nodo* nuevoNodo = (struct nodo*)malloc(sizeof(struct nodo));
    nuevoNodo->id = id;
    strcpy(nuevoNodo->nombre, nombre);
    nuevoNodo->padre = padre;
    nuevoNodo->primerHijo = NULL;
    nuevoNodo->siguienteHermano = NULL;
    return nuevoNodo;
}
void agregarHijo(struct nodo* padre, int id, const char* nombre) {
    struct nodo* nuevoHijo = crearNodo(id, nombre, padre);

    if (padre->primerHijo == NULL) {
        // Si el nodo no tiene hijos, el nuevo nodo se convierte en el primer hijo
        padre->primerHijo = nuevoHijo;
    } else {
        // Si ya hay hijos, buscar el último hermano y enlazar el nuevo nodo
        struct nodo* temp = padre->primerHijo;
        while (temp->siguienteHermano != NULL) {
            temp = temp->siguienteHermano;
        }
        temp->siguienteHermano = nuevoHijo;
    }
}


struct nodo* buscarNodo(struct nodo* raiz, const char* nombre) {
    if (raiz == NULL) return NULL;

    // Si el nodo actual tiene el nombre buscado, retornarlo
    if (strcmp(raiz->nombre, nombre) == 0) {
        return raiz;
    }

    // Buscar en el primer hijo
    struct nodo* encontrado = buscarNodo(raiz->primerHijo, nombre);
    if (encontrado != NULL) {
        return encontrado;
    }

    // Buscar en los hermanos
    return buscarNodo(raiz->siguienteHermano, nombre);
}


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
    // Crear el nodo raíz
    struct nodo* raiz = crearNodo(0, "root", NULL);

    // Variables para interactuar con el usuario
    char nombrePadre[20], nombreHijo[20];
    int opcion = 0, id = 1;

    // Ciclo para agregar directorios dinámicamente
    while (1) {
        printf("\n--- Menu ---\n");
        printf("1. Agregar directorio\n");
        printf("2. Mostrar estructura\n");
        printf("3. Salir\n");
        printf("Elige una opcion: ");
        scanf("%d", &opcion);

        if (opcion == 1) {
            // Leer nombre del directorio padre
            printf("Ingresa el nombre del directorio padre: ");
            scanf("%s", nombrePadre);

            // Buscar el directorio padre
            struct nodo* padre = buscarNodo(raiz, nombrePadre);
            if (padre == NULL) {
                printf("Error: Directorio padre '%s' no encontrado.\n", nombrePadre);
                continue;
            }

            // Leer el nombre del nuevo directorio
            printf("Ingresa el nombre del nuevo directorio: ");
            scanf("%s", nombreHijo);

            // Agregar el nuevo directorio
            agregarHijo(padre, id++, nombreHijo);
            printf("Directorio '%s' agregado dentro de '%s'.\n", nombreHijo, nombrePadre);

        } else if (opcion == 2) {
            // Mostrar la estructura del árbol
            printf("\nEstructura del arbol:\n");
            imprimirArbol(raiz, 0);

        } else if (opcion == 3) {
            // Salir del programa
            printf("Saliendo...\n");
            break;

        } else {
            printf("Opción no válida.\n");
        }
    }

    return 0;
}
