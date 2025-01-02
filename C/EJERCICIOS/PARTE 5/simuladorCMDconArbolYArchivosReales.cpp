#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h> // Biblioteca para manejo de directorios y archivos en Windows
#define ARGS 60

// Variables globales
char userInput[ARGS]; // Entrada del usuario
char dir[MAX_PATH] = "."; // Directorio actual (inicia en el actual)
char instruccion[10];

// Declaración de funciones
void detectarInstruccion(char args[]);
int asignarOpcion(char args[]);
void imprimirDirectorio(const char* path);
void cambiarDirectorio(const char* path);
void crearArchivo(const char* nombreArchivo);
void crearDirectorio(const char* nombreDirectorio);
void eliminarDirectorio(const char* nombreDirectorio);
void copiarArchivo(const char* origen, const char* destino);
void borrarArchivo(const char* archivo);
void mostrarArchivo(const char* archivo);

// Función principal
int main() {
    int salida = 0;

    printf("Microsoft Windows [Version 10.0.19045.5131]\n(c) Alexis Corporation. Todos los derechos reservados.\n");

    do {
        printf("\n%s>", dir);
        scanf("%s", userInput);

        detectarInstruccion(userInput);

        switch (asignarOpcion(instruccion)) {
            case 1: // dir
                imprimirDirectorio(dir);
                break;

            case 2: // cd
               // printf("Ingresa el nombre del directorio: ");
                char cambiarDir[MAX_PATH];
                scanf("%s", cambiarDir);
                cambiarDirectorio(cambiarDir);
                break;

            case 3: // touch
              //  printf("Ingresa el nombre del archivo: ");
                char nuevoArchivo[MAX_PATH];
                scanf("%s", nuevoArchivo);
                crearArchivo(nuevoArchivo);
                break;

            case 5: // mkdir
               // printf("Ingresa el nombre del nuevo directorio: ");
                char nuevoDirectorio[MAX_PATH];
                scanf("%s", nuevoDirectorio);
                crearDirectorio(nuevoDirectorio);
                break;

            case 6: // rmdir
               // printf("Ingresa el nombre del directorio a eliminar: ");
                char eliminarDir[MAX_PATH];
                scanf("%s", eliminarDir);
                eliminarDirectorio(eliminarDir);
                break;

            case 7: // copy
               // printf("Ingresa el archivo origen: ");
                char archivoOrigen[MAX_PATH];
                scanf("%s", archivoOrigen);
                printf("Ingresa el archivo destino: ");
                char archivoDestino[MAX_PATH];
                scanf("%s", archivoDestino);
                copiarArchivo(archivoOrigen, archivoDestino);
                break;

            case 8: // delete
               // printf("Ingresa el archivo a borrar: ");
                char archivoABorrar[MAX_PATH];
                scanf("%s", archivoABorrar);
                borrarArchivo(archivoABorrar);
                break;

            case 9: // type
                //printf("Ingresa el archivo a mostrar: ");
                char archivoAMostrar[MAX_PATH];
                scanf("%s", archivoAMostrar);
                mostrarArchivo(archivoAMostrar);
                break;

            case -1: // exit
                salida = 1;
                break;

            default:
                printf("'%s' no se reconoce como un comando interno o externo,\nprograma o archivo por lotes ejecutable.", instruccion);
                break;
        }

    } while (salida != 1);
    exit(0);
    return 0;
}

// FUNCIONES

// Detectar la instrucción del usuario
void detectarInstruccion(char args[]) {
    memset(instruccion, 0, sizeof(instruccion));
    int i;
    for (i = 0; i < ARGS; i++) {
        if (args[i] == '\0') {
            instruccion[i] = '\0';
            break;
        }
        instruccion[i] = args[i];
    }
}

// Asignar opciones a los comandos
int asignarOpcion(char args[]) {
    if (strcmp(args, "dir") == 0) return 1;
    if (strcmp(args, "cd") == 0) return 2;
    if (strcmp(args, "touch") == 0) return 3;
    if (strcmp(args, "mkdir") == 0) return 5;
    if (strcmp(args, "rmdir") == 0) return 6;
    if (strcmp(args, "copy") == 0) return 7;
    if (strcmp(args, "delete") == 0) return 8;
    if (strcmp(args, "type") == 0) return 9;
    if (strcmp(args, "exit") == 0) return -1;
    return 0;
}

// Imprimir contenido del directorio actual
void imprimirDirectorio(const char* path) {
    WIN32_FIND_DATA findFileData;
    HANDLE hFind;
    char searchPath[MAX_PATH];

    snprintf(searchPath, sizeof(searchPath), "%s\\*", path);
    hFind = FindFirstFile(searchPath, &findFileData);

    if (hFind == INVALID_HANDLE_VALUE) {
        printf("No se puede abrir el directorio: %s\n", path);
        return;
    }

    do {
        printf("%s\n", findFileData.cFileName);
    } while (FindNextFile(hFind, &findFileData) != 0);

    FindClose(hFind);
}

// Cambiar el directorio actual
void cambiarDirectorio(const char* path) {
    if (SetCurrentDirectory(path)) {
        GetCurrentDirectory(sizeof(dir), dir);
    } else {
        printf("No se puede cambiar al directorio: %s\n", path);
    }
}

// Crear un archivo
void crearArchivo(const char* nombreArchivo) {
    FILE* file = fopen(nombreArchivo, "w");
    if (file) {
        printf("Archivo '%s' creado exitosamente.\n", nombreArchivo);
        fclose(file);
    } else {
        printf("Error al crear el archivo '%s'.\n", nombreArchivo);
    }
}

// Crear un directorio
void crearDirectorio(const char* nombreDirectorio) {
    if (CreateDirectory(nombreDirectorio, NULL)) {
        printf("Directorio '%s' creado exitosamente.\n", nombreDirectorio);
    } else {
        printf("Error al crear el directorio '%s'.\n", nombreDirectorio);
    }
}

// Eliminar un directorio
void eliminarDirectorio(const char* nombreDirectorio) {
    if (RemoveDirectory(nombreDirectorio)) {
        printf("Directorio '%s' eliminado exitosamente.\n", nombreDirectorio);
    } else {
        printf("Error al eliminar el directorio '%s'.\n", nombreDirectorio);
    }
}

// Copiar un archivo
void copiarArchivo(const char* origen, const char* destino) {
    if (CopyFile(origen, destino, FALSE)) {
        printf("Archivo copiado de '%s' a '%s' exitosamente.\n", origen, destino);
    } else {
        printf("Error al copiar el archivo de '%s' a '%s'.\n", origen, destino);
    }
}

// Borrar un archivo
void borrarArchivo(const char* archivo) {
    if (DeleteFile(archivo)) {
        printf("Archivo '%s' eliminado exitosamente.\n", archivo);
    } else {
        printf("Error al eliminar el archivo '%s'.\n", archivo);
    }
}

// Mostrar el contenido de un archivo
void mostrarArchivo(const char* archivo) {
    FILE* file = fopen(archivo, "r");
    if (!file) {
        printf("No se puede abrir el archivo '%s'.\n", archivo);
        return;
    }

    char buffer[256];
    while (fgets(buffer, sizeof(buffer), file)) {
        printf("%s", buffer);
    }
    fclose(file);
}
