#include<stdio.h>

#include<stdio.h>
#include"BColaInt.h"

void printCola(TCola q)
{
   int elem;
   
   
	while(ColaVacia(q) != 1){  
		DeleteCola(&q, &elem);
		printf("==> %d ", elem);
		getchar();
	}
   printf("\n");
}


main(){
    TCola q;
    int e;

    if (CreateCola(&q,3) == 1){
    	printf("Se creo la Cola correctamente\n\n");
		printf("\nInserta %d", 1);
    	AddDate(&q, 1);         printCola(q);
    	printf("\nInserta %d", 2);
    	AddDate(&q, 2);         printCola(q);
    	printf("\nInserta %d", 3);
    	AddDate(&q, 3);         printCola(q);
		 
  
    	printf("\nElimina\n");
    	DeleteCola(&q, &e);         printCola(q);
    	printf("\nElimina\n");
    	DeleteCola(&q, &e);         printCola(q);
    	printf("\nElimina\n");
    	DeleteCola(&q, &e);         printCola(q);
		
	}else{
		printf("Memoria Insuficiente...\n");
	}
    
    return 0;
}
