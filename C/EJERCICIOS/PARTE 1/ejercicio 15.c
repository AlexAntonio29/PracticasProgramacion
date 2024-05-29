//ejercicio 15

#include<stdio.h>

main(){
	
	float hrs,pago,pagot,hrsN,num,impuestos;
	hrsN=0;
	pagot=1;
	
	printf("Cual es la cantidad de pago por hora?\n");
	scanf("%f",&pago);
	
		printf("Cual es la cantidad de horas trabajadas?\n");
	scanf("%f",&hrs);
	
	if(hrs>35){
		
		hrsN=hrs-35;
		hrs=hrs-hrsN;
		hrsN=hrsN*1.5;
		hrsN=hrsN*pago;
		
	}
	pagot= (pago*hrs)+hrsN;	
	if(pagot<=1000){
			printf("El salario del trabajador es %f pesos",pagot);
	}
	if(pagot>1000&&pagot<=2000){
		num=pagot-1000;
		impuestos=num*(.10);
		impuestos=pagot-impuestos;
			
		
		pagot-=impuestos;
			printf("El salario del trabajador es %f pesos",pagot);	
	}
	if(pagot>2000){
		num=(1000*.1)+(pagot-2000)*.2;
		pagot=pagot-num;
		
		printf("El salario del trabajador es %f pesos",pagot);
	}
	
	
	
}
