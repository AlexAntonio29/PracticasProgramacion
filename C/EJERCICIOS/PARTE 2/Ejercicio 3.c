
//Ejercicio 3     Alexis Zosimo Antonio Angel   102-B 
/*3. Si se declara
int a[5] = {2, 4, 6, 8, 10, 12};
y se hace la llamada a la funcion
misterio2(a, 5);
Realice la corrida de escritorio de la llamada anterior e indique
el proposito de la siguiente funcion:
void misterio2(int *v, int n){
int i;
for(i=0; i<n; i++)
printf("%d ", *(v+i));
printf("\n");
}

*/

#include<stdio.h>


void misterio2(int *v,int n){
	int i ;    
	for(i=0;i<n;i++) 
	printf("%d  ", *(v+i));//Hace una suma de la direccion de cada apartado de memoria en donde cada suma de una variable entera suma 4 bytes por lo cual por cada suma de una unidad pasa directamente al siguiente elemento 
	printf("\n");
}

main(){
	
	int a[6]={2,4,6,8,10,12};
	misterio2(a, 6);
	
	return 0;
}



