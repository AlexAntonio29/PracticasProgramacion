//Alexis Zosimo Antonio Angel    202-B    Estructura de datos Tarea 2.1

#include<stdio.h>

#include"colafloat.h"

void printCola(TCola q)
{
   float elem;
   
  
	while(ColaVacia(q) != 1){  
		DeleteCola(&q, &elem);
		printf("=> %f ", elem);
	
	}
   printf("\n");
}


main(){
    TCola q;
    float e,r=1.5;
    int i,n;
		
		
		printf("Cantidad de datos\n");
		scanf("%d",&n);
    if (CreateCola(&q,n) == 1){

		 
		 for(i=1;i<=n;i++){
		 	printf("\nInserta %f\n", r);
    	AddDate(&q, r);         printCola(q);
    	r++;
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
