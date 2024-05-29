/*
FUndamentos de programacion

PROGRAMA: MENU CON OPERACIONES

Created by ALEXIS ZOSIMO ANTONIO ANGEL

20/11/2023

*/



#include <stdio.h>

#define PI 3.14159
float rectangulo(){
	float base,altura;
	printf("Ingresa la base del rectangulo\n");
	scanf("%f",&base);
	printf("Ingresa la altura del rectangulo\n");
	scanf("%f",&altura);
	return base*altura;
}

float triangulo(){
	
		float base,altura;
	printf("Ingresa la base del triangulo\n");
	scanf("%f",&base);
	printf("Ingresa la altura del triangulo\n");
	scanf("%f",&altura);
	return (base*altura)/2;
	
}
float cuadrado(){
	float lado;
	printf("Ingresa el lado del cuadrado\n");
	scanf("%f",&lado);
	return lado*lado;
}
float circulo(){
	
	float radio;
	printf("Introduzca el valor del radio\n");
	scanf("%f",&radio);
	
	return PI*(radio*radio);
	
}

int menu(){
	char select;
	float r;
	
	printf("***********************************************************\n");
	
	printf("MENU\n\nSelecciona la operacion que deseas realizar\n");
	printf("1) Calcular el área de un rectángulo\n2) Calcular el área de un triangulo\n3) Calcular el área de un cuadrado\n4) Calcular el área de un circulo\n5) Salir\n");
	scanf("%c",&select);
	printf("***********************************************************\n");
	
	
	
	switch (select){//utilizamos un switch para seleccionar
		
		case '1':
			r=rectangulo();
			printf("El area del rectangulo es %.2f",r);
			break;
		case '2':
			r=triangulo();
			printf("El area del triangulo es %.2f",r);
			break;
		case '3':
			r=cuadrado();
			printf("El area del cuadrado es %.2f",r);
			break;
		case '4':
			r=circulo();
			printf("El area del ciruclo es %.2f",r);
			break;
		case '5':
			printf("SALIENDO...");
			break;
		default:
			printf("\nDATOS INVALIDO... INTENTE NUEVAMENTE\n");
				return menu();
			break;
	}
	
	
}


int main(){
	
	
	menu();
	return 0;
}
