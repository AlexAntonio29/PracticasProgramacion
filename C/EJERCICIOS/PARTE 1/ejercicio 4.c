
//ejercicio 4

#include<stdio.h>
main(){
	int num,i;
	printf("Introduce un numero para saber si es primo o no\n\n");
	scanf("%d",&num);
	
	if(num==1){
		
		printf("El numero 1 no se considera primo ni compuesto");
	}
	else{	
	i=2;
while(num%i!=0){
	i++;
}
if(num==i){
	printf("Es un numero primo");
}
else{
	printf("no es un numero primo");

}
	
	}
	
		return 0;
}
