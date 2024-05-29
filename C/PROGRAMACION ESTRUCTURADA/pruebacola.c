//pruebacola.c

#include<stdio.h>
#include"colachar.h"

void printCola(TColaChar q)
{
   char elem;
   
    printf("\nFrente");
	while(colaVacia(q) != 1){  
		elimina(&q, &elem);
		printf("==> %c ", elem);
	}
   printf("\n");
}


main(){
    TColaChar q;
    char e;

    if (initCola(&q,3) == 1){
    	printf("Se creo la Cola correctamente\n\n");
		printf("\nInserta %c", 'a');
    	inserta(&q, 'a');         printCola(q);
    	printf("\nInserta %c", 'd');
    	inserta(&q, 'd');         printCola(q);
    	printf("\nInserta %c", 'e');
    	inserta(&q, 'e');         printCola(q);
		printf("\nInserta %c\n", 'f');
    	inserta(&q, 'f');	//error	  //printCola(q); 
  
    	printf("\nElimina\n");
    	elimina(&q, &e);         printCola(q);
    	printf("\nElimina\n");
    	elimina(&q, &e);         printCola(q);
    	printf("\nElimina\n");
    	elimina(&q, &e);         printCola(q);
		printf("\nElimina\n");
    	elimina(&q, &e);	//error  printCola(q); 
    	liberaCola(&q);		
	}else{
		printf("Memoria Insuficiente...\n");
	}
    
    return 0;
}

