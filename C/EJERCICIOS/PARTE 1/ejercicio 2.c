#include<stdio.h>
//ejercicio 2
main(){
	int num;
	printf("Introduce un valor\n");
	
	scanf("%d",&num);
	
	if(num==0){
		printf("El valor es cero");
	}
	if(num<0){
		printf("El valor es negativo");
	}
	if(num>0){
		printf("El valor es positivo");
	}
		return 0;
}
