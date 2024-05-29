//Ejercicio 9    Alexis Zosimo Antonio Angel   102-B


/*
9.Si se declara 

int a[5] = {2, 4, 6, 8, 10, 12};

y se hace la llamada  a la funcion

misterio5(a, 5);

 Realice la corrida de escritorio de la llamada anterior e 
 indique el proposito de la siguiente funcion:
 
 int misterio5(int *a, int n)
 {
 if(n == 0) 
 return 0;
 
 return misterio5(a, n-1) + *(a+n-1);}
*/

#include<stdio.h>
int misterio5(int *a, int n)
 {
 if(n == 0) //Cuando el limite del arreglo es cero
 return 0;//concluye la funcion
 
 return misterio5(a, n-1) + *(a+n-1);}//Hace la suma de cada elemento del arreglo, esto por supuesto a traves de puntero aritmetico ademas que utiliza funcion recursiva para pasar al siguiente arreglo
 
main(){
	int a[6] = {2, 4, 6, 8, 10, 12};//arreglo de 6 elementos
	misterio5(a, 6);//llamada de la funcion
	

	
}
