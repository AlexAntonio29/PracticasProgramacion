#include <stdio.h>
/*
Alexis Zosimo Antonio Angel
Determinar si una persona es alta o baja
17/10/2023

*/
int main(){
	float m;
	
	printf("Introduce la medida en metro de una persona\n");
	scanf("%f",&m);
	
	if(m>1.71) printf("\nLa persona es alta");
	else
		if(m<1.50) printf("\nLa persona es baja");
			else 
				printf("\nLa persona tiene estatura mediana");
	
	return 0;
}
