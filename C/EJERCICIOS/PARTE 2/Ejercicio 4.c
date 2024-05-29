//Ejercicio 4  Alexis Zosimo Antonio Angel   102-B    

#include<stdio.h>

/*4. Utilizando notacion de apuntadores realiza una funcion que reciba
un apuntador a un arreglo y su tamano. La funcion debe regresar
el maximo de los elementos del arreglo.*/
int arreglo(int *v,int n);

main(){
int a[6]={10,56,31,20,93,6},b;

b=arreglo(a,6);	
printf("%d",b);
}

int arreglo(int *v,int n){
	int i,max=0;
	for(i=0;i<n;i++)
	if(*(v+i)>max) max=*(v+i);	

	return max;
}
