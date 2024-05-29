//Pila dinamica char  Alexis Zosimo Antonio Angel   202-B  Tarea1.2

#include <stdio.h>
#include "./pilachardinamica.h"

void PPila(TLiga q)
{

    printf("Tope\n");
	while(!pilaVacia(q)){
		printf("=>%c ", q->info);
		q = q->sig;
	}
   printf("\n\n");
}

main()
{
    TLiga p;
    char e;
    int n,i,val=65;
    printf("Introduce la cantidad de numeros de almacenamiento\n");
    scanf("%d",&n);

    iniciaPila(&p);

    
    
    for(i=0;i<n;i++){
    	
    	printf("Se inserta %c\n",val);
    	AddDate(&p,val);  PPila(p);
    	val++;
    	
	}
 topePila(p, &e);
 printf("\nElemento del tope %c\n",e);
    PPila(p);
    val--;
for(i=0;i<n;i++){
	printf("\nEliminacion de pila %c\n",val);
	 ChangeDate(&p, &e);         PPila(p);
	 val--;
}
    getchar();
    return 0;
   

}
