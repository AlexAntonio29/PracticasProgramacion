
//ejercicio 12

#include<stdio.h>

main(){ 

int num,Num;
Num=10;
printf("Cuantos minutos tardo la llamada?\n");

scanf("%d",&num);


if(num>3){
	Num+=(num-3)*2;
	
	printf("son %d pesos a pagar",Num);
	
}else{
	if(num<1){
		printf("La llamada no duro mas de 0 minutos");
	}
	else{
		printf("Son 10 pesos a pagar");
	}
	
}

	return 0;
}
