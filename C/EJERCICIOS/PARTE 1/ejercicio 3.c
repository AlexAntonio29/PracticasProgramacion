//ejercicio 3

#include<stdio.h>

main(){
	
	int hrs, tar, impuestos,neto;
	float imp;
	
	printf("Cuales son las horas que se trabajo?\n");
	scanf("%d",&hrs);
		printf("Cual es la paga por hora?\n");
	scanf("%d",&tar);
	
	printf("cuanto de porcentaje es el descuento en impuestos?");
	scanf("%f",&imp);
	
	imp=imp/100;
	
	
	impuestos= (hrs*tar)*imp;
	
	neto=(hrs*tar)-impuestos;
	
	printf("El salario neto es %d",neto);
	
	
		return 0;
}
