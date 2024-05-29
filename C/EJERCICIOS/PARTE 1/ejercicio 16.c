//ejercicio 16.c

#include<stdio.h>

main(){
	int hrs,min,seg;
	printf("Introduce las horas: " );
	scanf("%d",&hrs);
	
		printf("Introduce los minutos: " );
	scanf("%d",&min);
	
		printf("Introduce los segundos: " );
	scanf("%d",&seg);
	
	if(hrs>24||hrs<0||min>60||min<0||seg<0||seg>60){
		printf("La hora es incorrecta");
		
		
	}
	
	else{
	
	seg++;
	
	if(seg==60){
		seg=0;
		min++;
	}
		if(min==60){
		min=0;
		hrs++;
	}
		if(hrs==24){
		hrs=0;
	
	}
	
	printf("\nLa hora es: %d : %d : %d", hrs,min,seg);
	}
	
	return 0;
}
