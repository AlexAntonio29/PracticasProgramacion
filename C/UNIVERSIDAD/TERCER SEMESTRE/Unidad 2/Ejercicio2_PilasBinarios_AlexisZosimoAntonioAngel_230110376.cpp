
#include <stdio.h>

#include "pilaInt.h"

#define MAX 50
int cadena[MAX];

void Maximo(){


for(int i;i<MAX;i++){
	cadena[i]=-1;
	
}

}


void printPila(TPila p)
{
   int elem;
   
    printf("Tope");
    
    
	if(pilaVacia(p) != 0){
        pop(&p, &elem);
		printf("==>%d ",elem);
		
		
		
	}
   printf("\n");
}


int main(){
	int dividendo;
	
	int divisor=2;
	TPila pila;
	int cociente=0;
	int residuo=0;
	int resultadoDividendoDivisor;
	printf("Inserta el valor de ");
	scanf("%d",&dividendo);
	
	Maximo();
	
	
	if (initPila(&pila, MAX) == 1){
        printf("Se creo la pila correctamente\n\n");
        
    int i=0;
    while(dividendo!=0||cociente>0 ){
    	
	//Paso para realizar pasos para crear pila binario
	resultadoDividendoDivisor=dividendo/divisor;
	cociente=resultadoDividendoDivisor ;
	residuo= dividendo%divisor;
	dividendo = resultadoDividendoDivisor;
	
	cadena[i]= residuo;
	
//	printf("%d", residuo);
	
	i++;
	
	}
	printf("\n");
	
	int elemento;
	for(int j=0;j< MAX;j++){
		
		if(cadena[j]!=-1){
	//	printf("%d", cadena[j]);
			
		push(&pila, cadena[j]); 
		printPila(pila);

		}
	}
	
	
	
	
	
    
    
        liberaPila(&pila);
    }
    else{
        printf("memoria Insuficiente\n");
    }
	
	return 0;
}
