//Alexis Zosimo Antonio Angel   202-B   colaintdinamica.c

#include<stdio.h>
#include<stdlib.h>
#include "./bibfuncionesint.h"

//Aqui la cambiare para agregar el tipo de dato
main(){
	TCola node;
	int i, n;
	TDate val,sust;
	
	val=1;
	
	printf("Cantidad de datos que se generaran\n");
	scanf("%d",&n);
	printf("----------PASO 1 AGREGAR DATOS ------------\n");
	for(i=0;i<n;i++){
		
		printf("\nAccion %d\n", i+1);
		//Aqui entrara los datos para que cree el nodo, aqui tendra los datos para que cree la funcion AddDate;
		AddDate(&node,val);  
		printf("Imprimir datos\n");
		PrintDate(node);
		//impresion de los datos;
		val++;
	}
	printf("\n\n-----------PASO 2  ELIMINACION DE DATOS-------\n\n");
	//Eliminacion de los datos
	for(i=0;i<n;i++){
		printf("\nAccion %d\n", i+1);
		//Funcion DeleteDate;
		DeleteDate(&node, &sust); PrintDate(node);
		//Funcion imprimir datos;
	}
	printf("Vacio\n");
	
	return 0;
}
