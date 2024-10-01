 #include <stdio.h>
#include <stdlib.h>

#define LONG 30
int lista[LONG];

 int N=-1;

// Función para mostrar el menú

void agregar(int data){
	
	int Ndata;
	

	for(int i=0;i<LONG-1;i++)
		if(data<lista[i]){
		Ndata=lista[i];
			lista[i]=data;
			
			
		
			data=Ndata;
			
		} 
	
	
	
	
	
	
	
	
}

void eliminar(int i){
	
while(i<LONG){
	lista[i]=lista[i+1];
	i++;
}
	
}
void modificar(int i){
	int n;
	printf("Dato a modificar:");
	scanf("%d",&n);
	lista[i]=n;
	i=0;

}

void buscar(int n, int select){
	bool message=true;
	for (int i=0;i<LONG-1;i++){
		if (n==lista[i]){
			
			
			if(select==0) modificar(i);
			if(select==1) eliminar(i);
		message=false;
		}
	
	}
	if(message) printf("No se encontro el Dato");
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
    printf("%d\n",lista[3]);

    // Llenar la lista con números pares
    for (int i = 2; i < 60; i = i + 2) {
        lista[valor] = i;
        valor++;
    }
     printf("%d\n",lista[3]);

   

  

    char select;

    do {
        printf("\n");
        select = '0'; // 
        menu();
        scanf(" %c", &select); // Nota el espacio antes de %c para limpiar el búfer
			int data;
        switch (select) {
        	
        	
            case '1':
            	
            	
            	int p;
               for(int i=0;i<LONG-1;i++)
               	if(lista[i]==0) p=i;
               	
               	if(lista[p]==0) {
               		 printf("insertar Dato:\n");
                scanf(" %d", &data);
                lista[p]=lista[p-1];
                agregar(data);
				   }else printf("La casilla esta llena");
               
                break;

            case '2':
                printf("Buscar Dato a modificar:\n");
                scanf(" %d", &data);
                buscar(data,0);
                break;

            case '3':
                printf("Buscar Dato a eliminar:\n");
                scanf(" %d", &data);
                buscar(data,1);
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
