/*
Programa: Area de un Triangulo

Antonio Angel Alexis Zósimo

Fundamentos de programación

matricula: 230110376  1A

04-10-2023


*/

#include <stdio.h>
#include <math.h>

int main(){
	//Entrada de datos
	float s,lado1,lado2,lado3,area_t;
	printf("*************************************************\n");
	printf("Introduce el lado1\n ");
	scanf("%f", &lado1);
	printf("Introduce el lado2\n ");
	scanf("%f", &lado2);
	printf("Introduce el lado3\n ");
	scanf("%f", &lado3);
	//proceso de la ecuacion
	s=(lado1+lado2+lado3)/2;
	
	
	if(s>lado1&&s>lado2&&s>lado3){
		
		area_t= sqrt(s*(s-lado1)*(s-lado2)*(s-lado3));
	//Salida de datos
	printf("\nEl area del triangulo es %.1f unidades cuadradas\n",area_t);
	}
	else{
		//condicional else por si la raiz es negativa
		printf("\nERROR...ESTA OPERACION NO SE PUEDE REALIZAR..\nEl TRIANGULO NO EXISTE\n");
	}
	
	printf("\n**************************************************");
	
	
	return 0;
}
