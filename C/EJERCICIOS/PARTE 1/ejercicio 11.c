//ejercicio 11

#include<stdio.h>
#include<math.h>
main(){ 

int num,elevacion,val,suma;
suma=1;
elevacion=0;

printf("Introduce un numero\n");
scanf("%d",&num);


while(num>0){
	val=num%10;
switch(val){
	
	case 1: printf("uno\n");break;
	case 2: printf("dos\n");break;
	case 3: printf("tres\n");break;
	case 4: printf("cuatro\n");break;
	case 5: printf("cinco\n");break;
	case 6: printf("seis\n");break;
	case 7: printf("siete\n");break;
	case 8: printf("ocho\n");break;
	case 9: printf("nueve\n");break;
	case 10: printf("cero\n");break;
	default: printf("cero\n");break;
}
	elevacion=val*(pow(10,suma));
	num=num-val;
	num=num/10;	
	suma++;
}


	return 0;
}
