#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#define ARGS 60
#define LIM 40

/*
ALEXIS ZOSIMO ANTONIO ANGEL 
SISTEMAS OPERATIVOS
3B

SIMULADOR DE CMD BASICO
*/

/*
Para crear este programa es indispensable hace uso de los arboles que es una clase de estructura que 
se utiliza principalmente para estos fines la de crear la conexion de directorio, por lo tanto es importante 
crear esta junto con sus principales funciones como es la de
INICIALIZAR
INSERTAR
ELIMINAR
TRASLADARSE
ETC..


*/
//CREAR ESTRUCTURAS
//estructura de archivos del directorio
struct archivo{
	int id;
	char nombre[20] ;
	
};


//nodo que de las direcciones
struct nodo{
int id;
char nombre[20];
archivo archivos[LIM];	
};


//PARTE 1 CREAR LA ESTRUCTURA DE ARBOL





//PARTE 2 INICIAR SIMULADOR CMD


//VARIABLES GLOBALES
char read[ARGS];
char dir[ARGS]="C:";
char instruccion[10];




void detectarInstruccion(char args[]);
int cantidadCaracteres(const char args[]);
int asignarOpcion(char args[]);

int main(){
	int salida=0;
	printf("Microsoft Windows [Version 10.0.19045.5131]\n (c) Alexis Corporation. Todos los derechos reservados.\n");
	do{
	
	
	printf("\n%s",dir);
	scanf("%s",&read);
	
detectarInstruccion(read);



	switch(asignarOpcion(instruccion)){
		case 1:
			printf("hola");
			break;
			
		case 2:
			break;
		case 3:
			break;
			
		case 4:
			break;
			
		case 5:
			break;
			
		case 6:
			break;
			
			
		case -1:
		
			salida=1;
		
			break;
			
			default:
				printf("'%s' no se reconoce como un comando interno o externo,\nprograma o archivo por lotes ejecutable.",instruccion);
				break;
		
		
	}
	
	}while(salida!=1);
	exit(0);
	return 0;
}



//FUNCIONES

//se utiliza para verificar si la instruccion es valida (solo la instruccion ejemplo dir )
//para que tenga la cantidad exacta de caracteres de una instruccion
int cantidadCaracteres(const char args[]){
	
int contador = 0;
    while (args[contador] != '\0') {
        contador++;
    }
    return contador;
}

void detectarInstruccion(char args[]) {
    static char palabra[10];  // Definir 'palabra' como estática para que conserve su valor fuera de la función.
    
    // Limpiar la cadena 'palabra' antes de usarla
    memset(palabra, 0, sizeof(palabra));

    int i;
    for(i = 0; i < ARGS; i++) {
        if (args[i] == '\0') {
            palabra[i] = '\0';  // Asegurarse de que 'palabra' se termine correctamente.
          strcpy(instruccion,palabra);
            break;
        }

        palabra[i] = args[i];
        
    }

}

int asignarOpcion(char args[]){
	
	if(strcmp(args,"dir")==0) return 1;
	if(strcmp(args,"copy")==0) return 2;
	if(strcmp(args,"delete")==0) return 3;
	if(strcmp(args,"type")==0) return 4;
	if(strcmp(args,"mkdir")==0) return 5;
	if(strcmp(args,"rmdir")==0) return 6;
	
	
	if(strcmp(args,"exit")==0) return -1;
	return 0;
	
}
