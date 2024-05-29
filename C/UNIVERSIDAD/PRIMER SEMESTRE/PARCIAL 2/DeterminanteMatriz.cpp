/*
Alexis Zósimo Antonio Angel

Programa que calcule la determinante de una matriz

17-10-2023


*/

#include <stdio.h>

int main(){
	
	int a11,a12,a21,a22,a;
	
	printf("Introduce el valor de A11\n");
	scanf("%d",&a11);
	printf("Introduce el valor de A12\n");
	scanf("%d",&a12);
	printf("Introduce el valor de A21\n");
	scanf("%d",&a21);
	printf("Introduce el valor de A22\n");
	scanf("%d",&a22);
	
	a=(a11*a22)-(a12*a21);
	
	printf("\nLa determinante de la matriz es %d", a);
	return 0;
}
