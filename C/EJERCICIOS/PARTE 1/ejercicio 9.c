#include<stdio.h>

//ejercicio 9
main(){ 

char num;

printf("Introduce una letra    S/N para salir\n");
scanf("%c",&num);

while(num!='S'&&num!='s'&&num!='n'&&num!='N'){
	fflush(stdin);
	printf("Introduce una letra    S/N para salir\n");
scanf("%c",&num);
}
printf("\nHa salido del programa");
	return 0;
}
