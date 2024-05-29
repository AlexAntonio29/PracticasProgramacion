#include<stdio.h>

//ejercicio 7
main(){  
int num;

printf("Introduce un numero entero\n");
scanf("%d",&num);
if(num%2==0){
	printf("\nEs multiplo de 2");
}
if(num%3==0){
	printf("\nEs multiplo de 3");
}
if(num%5==0){
	printf("\nEs multiplo de 5");
}
if(num%7==0){
	printf("\nEs multiplo de 7");
}
	return 0;
}
