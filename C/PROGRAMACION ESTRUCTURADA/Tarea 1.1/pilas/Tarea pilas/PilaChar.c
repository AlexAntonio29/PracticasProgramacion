//Tarea 1.1  Pila Caractér  Alexis Zosimo Antonio Angel  202-B
#include <stdio.h>
#include "pilaChar.h"

void printPila(TPila p)
{
   char elem;
   
    printf("Tope");
	while(pilaVacia(p) != 1){
        pop(&p, &elem);
		printf("==>%c ",elem);
	}
   printf("\n");
}

main()
{
    TPila p;
    char e;

    if (initPila(&p, 3) == 1){
        printf("Se creo la pila correctamente\n\n");
        printf("Inserta %c\n",'A');
		push(&p, 'A');         printPila(p);
		printf("Inserta %c\n",'B');
        push(&p, 'B');         printPila(p);
        printf("Inserta %c\n",'C');
        push(&p, 'C');         printPila(p);
        printf("Inserta %c\n",'D');
        push(&p, 'D');	   

        topePila(p, &e);
        printf("\nelemento del tope %c\n",e);
        printPila(p);
        
        printf("\nElimina de la Pila\n");
        pop(&p, &e);         printPila(p);
        printf("Elimina de la Pila\n");
        pop(&p, &e);         printPila(p);
        printf("Elimina de la Pila\n");
        pop(&p, &e);         printPila(p);
        printf("Elimina de la Pila\n");
        pop(&p, &e);		 

        liberaPila(&p);
    }
    else{
        printf("memoria Insuficiente\n");
    }

    getchar();
    return 0;
}
