/*
Alexis Zósimo Antonio Angel

Programa:Distancia Entre dos puntos

17-10-2023

*/

#include <stdio.h>
#include <math.h>

int main(){
	//Entrada de Datos
	float x1,y1,x2,y2,p;
	
	printf("Introduce el valor de x1\n");
	scanf("%f",&x1);
	printf("Introduce el valor de y1\n");
	scanf("%f",&y1);
	printf("Introduce el valor de x2\n");
	scanf("%f",&x2);
	printf("Introduce el valor de y2\n");
	scanf("%f",&y2);
	//Proceso de datos
	p= sqrt(pow((x2-x1),2)+pow((y2-y1),2));
	//Salida de Datos
	printf("La distancia entre dos puntos es %.1f", p);
	
	return 0;
}
