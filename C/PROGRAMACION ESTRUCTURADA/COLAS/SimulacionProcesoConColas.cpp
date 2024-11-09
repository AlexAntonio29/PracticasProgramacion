#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#define tam_cola 6 
#define tam_datosL 7
#define tam_datosE 5

int inicio , fin, totalEventos;




char operacion [2][30]= {"Lectura","Escritura"}; //Tipo de operación lectura o  escritura
char datosLectura[tam_datosL][30] = {"usb","lcd","hdd","cd", "DVD", "Bue-Ray","Bios"}; 
char datosEscritura[tam_datosE] [30] = {"ssd","usb","cd-room","impresora","plotters"};


// typedef para no usar struct cada que use una variable tipo struct, y la llamo evento
typedef struct{
    int id;
    char op[30];
    char dato[30];

}evento;

int idGlobal=0;
evento eventos[tam_cola];
 
evento eventoLectura;
evento eventoEscritura;

//declaracion de funciones
void Agregar(evento p, int condicion);
bool esArregloVacio(char arreglo[][30], int n);
void EliminarCola();

void inicializarCola(){
    inicio = 0;
    fin = 0;
    totalEventos = 0;
}


bool colavacia(){
    if(inicio == fin)
    return true;
    else
    return false;
}

bool colaLlena() {
    return (fin + 1) % tam_cola == inicio;
}


void randomLectura(){


   int i;
  
 strcpy(eventoLectura.op, operacion[0]);//asigno dato de operacion Lectura
do{
    i = rand()%tam_datosL;//generacion de numero aleatorio
    
}while((strcmp(datosLectura[i], "") == 0)&& !esArregloVacio(datosLectura,tam_datosL));
	if(strcmp(datosLectura[i], "") != 0){
			idGlobal++;
eventoLectura.id=idGlobal;
strcpy(eventoLectura.dato, datosLectura[i]);
strcpy(datosLectura[i],"");
Agregar(eventoLectura,0);
printf("Proceso agregado correctamente\n");
	} else printf("Error al agregar proceso o esta Vacio\n");
	



}




void randomEscritura(){
	

	
	   int i;
 
 strcpy(eventoEscritura.op, operacion[1]);
do{
    i = rand()%tam_datosE;
}while((strcmp(datosEscritura[i], "") == 0)&& !esArregloVacio(datosEscritura,tam_datosE));


 
 
 if(strcmp(datosEscritura[i], "") != 0) {
 	 strcpy(eventoEscritura.dato, datosEscritura[i]);
 	idGlobal++; 
 	 eventoEscritura.id= idGlobal;
	strcpy(datosEscritura[i],"");
	Agregar(eventoEscritura,1);
printf("Proceso Agregado Correctamente\n");
 }else printf("Error al agregar proceso o esta Vacio\n");


	



}


void ProcesarCola(){
	
EliminarCola();
	
}





//Metodo para agregar un elemento a la cola
void Agregar(evento p, int condicion) {
    // Verifica si la cola está llena
    if (colaLlena()) {
       
        eventos[inicio] = p;
        
 
        inicio = (inicio + 1) % tam_cola;
        
        fin = (fin + 1) % tam_cola;
    } else {
       
        eventos[fin] = p;
        
        fin = (fin + 1) % tam_cola;
    }
    
    // Realiza la acción según el valor de `condicion`
    if (condicion == 0) {
        strcpy(eventoLectura.dato, "");
    }
    if (condicion == 1) {
        strcpy(eventoEscritura.dato, "");
    }
}




void mostrarContenido(){
	printf("\n\n*************************************************\n");	
	for(int i=0;i<tam_cola;i++)	
	if(strcmp(eventos[i].dato,"")!=0)
			printf( "id: %d operacion: %s dato: %s\n", eventos[i].id,eventos[i].op, eventos[i].dato);
		printf("\n\n************************************************\n");
	

}

int main(){
	 int opc=0;
	
	 strcpy(eventoEscritura.dato,"");
	  strcpy(eventoLectura.dato,"");
	
   do{
   	
   	printf("inicio:%d final:%d\n",inicio,fin);
    printf("1.-Generar evento de lectura\n");
    printf("2.-Generar evento de Escritura\n");
    printf("3.-Procesar Evento en la cola\n");
    printf("4.-Mostrar contenido de la cola\n");
    printf("0.- Salir\n");
    scanf("%d", &opc);
    printf("\n");
    switch(opc){
    	
    	case 1:
    		randomLectura();
    		
    		break;
    		
    		case 2: 
    		randomEscritura();
    		break;
    		
    		case 3:
    			
    			ProcesarCola();
    			break;
    			
    			
    			case 4:
    				
    				mostrarContenido();
    				break;
	}
   }while(opc!=0);

return 0;
}
	
bool esArregloVacio(char arreglo[][30], int n){

for(int i=0;i<n; i++){
	
	if(strcmp(arreglo[i], "")!=0) return false;
}
return true;

}




void EliminarCola() {
		printf("inicio: %d final:%d\n",inicio,fin);
    if (colavacia()) {
        printf("La cola esta vacia. No se puede eliminar.\n");
        return;
    }

    printf("Procesando evento: id: %d, operacion: %s, dato: %s\n", eventos[inicio].id, eventos[inicio].op, eventos[inicio].dato);
    strcpy(eventos[inicio].op, "");
    strcpy(eventos[inicio].dato, "");
    eventos[inicio].id = 0;

    
    inicio = (inicio + 1) % tam_cola;
    totalEventos--;
}


