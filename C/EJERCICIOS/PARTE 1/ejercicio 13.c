//ejercicio 13

#include<stdio.h>

main(){ 
int num,sum;
sum=1;
printf("Introduce un numero para calcular el factorial\n");
scanf("%d",&num);
while(num>0){
	 printf("%d ",num);
	sum*=num;
	num--;

}
printf("= %d",sum);

	return 0;
}
