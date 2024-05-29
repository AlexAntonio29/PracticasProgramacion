//Alexis Zosimo Antonio Angel    202-B    Estructura de datos Tarea 2.1

#include<stdio.h>

#include"colaint.h"

void printCola(TCola q)
{
   int elem;
   
  
	while(ColaVacia(q) != 1){  
		DeleteCola(&q, &elem);
		printf("=> %d ", elem);
		
	}
   printf("\n");
}


main(){
    TCola q;
    int e,i,n;
		n=3;
		
		printf("Cantidad de datos\n");
		scanf("%d",&n);
    if (CreateCola(&q,n) == 1){

		 
		 for(i=1;i<=n;i++){
		 	printf("\nInserta %d\n", i);
    	AddDate(&q, i);         printCola(q);
		 }
  for(i=1;i<=n;i++){
		 	printf("\nElimina\n");
    	DeleteCola(&q, &e);         printCola(q);
		 }
    
		liberarcola(&q);
	}else{
		printf("Fallo de memoria\n");
	}
    
    return 0;
}
