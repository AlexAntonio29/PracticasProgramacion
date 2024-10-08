#include <stdio.h>
#include <stdlib.h>

#define LONG 30
int lista[LONG];

 int N=-1;

// Función para mostrar el menú

void agregar(int i){
	int data;
	printf("insertar Dato:\n");
                scanf(" %d", &data);
	lista[i]=data;
	
	
	
	
	
}

void eliminar(int i){
	int n;
	
	lista[i]=0;
	printf("Dato Eliminado\n");

	
}
void modificar(int i){
	int n;
	printf("Dato a modificar:");
	scanf("%d",&n);
	lista[i]=n;	
}

void buscar(int n, int select){
	bool message=true;
	for (int i=0;i<LONG-1;i++){
		if (n==lista[i]){
			if(select==0) agregar(i);
			if(select==1) modificar(i);
			if(select==2) eliminar(i);
		message=false;
		}
	
	}
	if(message) if(select==0) printf("No hay espacio"); else printf("No se encontro el Dato");
	else printf("Arreglo actualizado");
	
}
void mostrar(){
	
	  // Imprimir los valores de la lista
	  int p=5;
    for (int i = 0; i < LONG-1; i++) {
    	
        printf("%d  ", lista[i]);
        if(i==p){
        	p=p+5;
        	printf("\n");
		} 
    }
}






void menu() {
	printf("\nMENU");
    printf("\n1) Agregar Datos");
    printf("\n2) Modificar Datos");
    printf("\n3) Eliminar Datos");
    printf("\n4) Mostrar");
    printf("\n0) Salir\n");
}

int main() {
    int valor = 0;


    // Llenar la lista con números pares
    for (int i = 2; i < 60; i = i + 2) {
        lista[valor] = i;
        valor++;
    }
   

   

  

    char select;

    do {
        printf("\n");
        select = '0'; // 
        menu();
        scanf(" %c", &select); // Nota el espacio antes de %c para limpiar el búfer
			int data=0;
        switch (select) {
        	
        	
            case '1':
            	
                
                
                buscar(data,0);
                break;

            case '2':
                printf("Buscar Dato a modificar:\n");
                scanf(" %d", &data);
                buscar(data,1);
                break;

            case '3':
                printf("Buscar Dato a eliminar:\n");
                scanf(" %d", &data);
                buscar(data,2);
                break;
                
            case '4':
            	mostrar();
            	break;

            case '0':
                printf("SALIENDO...\n");
                break;

            default:
                printf("ERROR AL INGRESAR DATOS\n");
                break;
        }

    } while (select != '0'); // Comparar correctamente con carácter '0'
    

    return 0;
}
