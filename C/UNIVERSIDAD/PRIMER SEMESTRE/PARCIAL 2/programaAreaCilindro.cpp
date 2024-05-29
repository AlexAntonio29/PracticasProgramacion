/*
Programa: Calcular Volumen y area de un cilindro
Antonio Angel Alexis Zósimo

Fundamentos de programación

matricula: 230110376  1A

04-10-2023


*/

#include <stdio.h>
#define PI 3.14159
int main(){
	
	//declaracion variables
	float area_c,radio,h,volumen_c;
	//entrada de datos
	
	printf("*******************************************\n");
	printf("Introduce el radio\n");
	scanf("%f",&radio);
		printf("Introduce la altura\n");
	scanf("%f",&h);
	volumen_c=PI*(radio*radio)*h;
	area_c=(2*PI*radio*h)+2*PI*(radio*radio);
	//salida de datos
	printf("El volumen es %.2f \n", volumen_c);
		printf("El area es %.2f \n", area_c);
		printf("\n*******************************************\n");
	
	

	

	return 0;
	
}
