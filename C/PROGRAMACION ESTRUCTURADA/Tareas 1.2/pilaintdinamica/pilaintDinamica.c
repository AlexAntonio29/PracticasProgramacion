//pruebaPila.c prueba las operaciones
// de pilaintdinamica.h
#include <stdio.h>
#include "./pilaintdinamica.h"

void printPila(TLiga p)
{
   int elem;
   
    printf("Tope");
	while(!pilaVacia(p)){
		printf("==>%d ", p->info);
		p = p->sig;
	}
   printf("\n\n");
}

main()
{
    TLiga p;
    int e;

    iniciaPila(&p);
      
    printf("Inserta %d\n",3);
	push(&p, 3);         printPila(p);
	printf("Inserta %d\n",5);
    push(&p, 5);         printPila(p);
    printf("Inserta %d\n",7);
    push(&p, 7);         printPila(p);
    printf("Inserta %d\n",9);
    push(&p, 9);	     printPila(p); 

    topePila(p, &e);
    printf("\nelemento del tope %d\n",e);
    printPila(p);
        
    printf("\nElimina de la Pila\n");
    pop(&p, &e);         printPila(p);
    printf("Elimina de la Pila\n");
    pop(&p, &e);         printPila(p);
    printf("Elimina de la Pila\n");
    pop(&p, &e);         printPila(p);
    printf("Elimina de la Pila\n");
    pop(&p, &e);		 printPila(p); 

    getchar();
    return 0;
}
