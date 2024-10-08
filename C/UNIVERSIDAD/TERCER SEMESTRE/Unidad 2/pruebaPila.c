//pruebaPila.c prueba las operaciones de pila.h
#include <stdio.h>
#include "pilachar.h"

#define MAX 20
#define LONGF 6



void printPila(TPila p)
{
   char elem;
   
    printf("Tope");
	while(pilaVacia(p) != 0){
        pop(&p, &elem);
		printf("==>%c ",elem);
	}
   printf("\n");
}

int main()
{
    TPila p;
    float e;
    
    char frase[LONGF];
    
    printf("Inserta el valor a la frase\n");
    scanf("%s",&frase);
    
    

    if (initPila(&p, MAX) == 1){
        printf("Se creo la pila correctamente\n\n");
        
    
    for(int i=0; i<LONGF;i++ ){
    	
    	push(&p, frase[i]); printPila(p);
    	
	}
    
    
        liberaPila(&p);
    }
    else{
        printf("memoria Insuficiente\n");
    }

    getchar();
    return 0;
}
