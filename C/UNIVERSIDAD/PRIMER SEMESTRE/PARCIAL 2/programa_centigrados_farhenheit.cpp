/*
Programa: Conversion grados Centrigrados a grados Farenheit
Antonio Angel Alexis Zósimo

Fundamentos de programación

matricula: 230110376  1A

04-10-2023


*/
	
#include <stdio.h>

int main(){
	//declaracion variables
	float g_cent, g_far;
	//entrada de datos
	printf("*****************************************\n");
	printf("Introduce los grados centigrados\n");
	scanf("%f",&g_cent);
	
	g_far=((9.0/5.0)*g_cent)+32;
	//salida de datos
	printf("\n%.1f centigrados son %.1f farenheit\n", g_cent, g_far);
	printf("\n*****CONVERSION EXITOSA*******************");
	return 0;
	
}
