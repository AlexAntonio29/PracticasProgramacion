/*
Alexis Zosimo Antonio Angel
Realizar operaciones aritmeticas
Fundamentos de programacion 1A
11/10/2023

*/

#include <stdio.h>

/*int menu(){
	int opc;
	
	
	
	printf("-----------------Menu----------------------\n");
	printf("Elige la opcion:\n1)suma\n2)resta\n3)multiplicacion\n4)division\n");
	scanf("%d",&opc);
	printf("-----------------------------------------------------");
	
	if (opc<1||opc>4){
	 printf("\nError de seleccion\n Intenta nuevamente...\n");
	 return menu();
	 
	 }
	 else return opc;
}*/

int main(){
	
	
	float num1,num2,oper;
	int opc;
	
	printf("Introduce el primer numero\n");
	scanf("%f",&num1);
	printf("Introduce el segundo numero\n");
	scanf("%f",&num2);
	
	while (opc<1||opc>4){
		
		printf("-----------------Menu----------------------\n");
	printf("Elige la opcion:\n1)suma\n2)resta\n3)multiplicacion\n4)division\n");
	scanf("%d",&opc);
	printf("-----------------------------------------------------");
		if (opc<1||opc>4) printf("\nError de seleccion... Intenta nuevamente..\n");
	
	}
	
	
	

		if(opc==1) oper=num1+num2;
		if(opc==2) oper=num1-num2;
		if(opc==3) oper=num1*num2;
		if(opc==4) oper=num1/num2;
	
	
	printf("\nEl resultado de %.1f y %.1f es %.1f", num1, num2, oper);
	
	
	return 0;
}
