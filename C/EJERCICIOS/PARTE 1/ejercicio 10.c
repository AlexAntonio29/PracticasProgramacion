//ejercicio 10

#include<stdio.h>
#include<math.h>
main(){ 

int num,sum,elevacion,val,suma;
suma=1;
elevacion=0;
sum=0;

printf("Introduce un numero\n");
scanf("%d",&num);

printf("\nLa suma de %d es ",num);
while(num>0){
	val=num%10;
	sum+=val;
	elevacion=val*(pow(10,suma));
	num=num-val;
	num=num/10;	
	suma++;
}

printf("%d",sum);

	return 0;
}
