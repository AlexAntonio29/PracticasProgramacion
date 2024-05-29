//ejercicio 17.c

#include<stdio.h>

main(){
	
	int cal;
	
	printf("Introduce una calificacion del 0 al 100\n");
	scanf("%d",&cal);
	
	if(cal>=0&&cal<69){
		printf("El alumno tiene F");
	}
		if(cal>=69&&cal<70){
		printf("El alumno tiene D");
	}
		if(cal>=70&&cal<79){
		printf("El alumno tiene C");
	}
		if(cal>=80&&cal<90){
		printf("El alumno tiene B");
	}
		if(cal>=90&&cal<=100){
		printf("El alumno tiene A");
	}
		if(cal>100||cal<0){
		printf("Calificacion no valida");
	}
	
	return 0;
}
