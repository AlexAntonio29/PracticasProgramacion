//Pila dinamica float   Alexis Zosimo Antonio Angel   202-B  Tarea1.2

#include <stdio.h>
#include "./pilafloatdinamica.h"

void PPila(TLiga q)
{

    printf("Tope\n");
	while(!pilaVacia(q)){
		printf("=>%2.1f ", q->info);
		q = q->sig;
	}
   printf("\n\n");
}

main()
{
    TLiga p;
    float e,val=3.5;
    int n,i;
    printf("Introduce la cantidad de numeros de almacenamiento\n");
    scanf("%d",&n);

    iniciaPila(&p);

    
    
    for(i=0;i<n;i++){
    	
    	printf("Se inserta un valor %2.1f\n",val);
    	AddDate(&p,val);  PPila(p);
    	val++;
    	
	}
 topePila(p, &e);
 printf("\nelemento del tope %2.1f\n",e);
    PPila(p);
    val--;
for(i=0;i<n;i++){
	printf("\nEliminacion pila %2.1f\n",val);
	 ChangeDate(&p, &e);         PPila(p);
	 val--;
}
    getchar();
    return 0;
   

}
