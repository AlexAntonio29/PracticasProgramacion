//ejercicio 14.c

#include<stdio.h>

main(){
	
	int mult,num,i,mul;
	num=3;
	
	printf("Cuantos multiplos desea tener?");
	
	scanf("%d",&mult);
	
	for(i=1;i<=mult;i++){
		mul=num*i;
		
		printf("%d    ",mul);
		
	}
	
	return 0;
}
