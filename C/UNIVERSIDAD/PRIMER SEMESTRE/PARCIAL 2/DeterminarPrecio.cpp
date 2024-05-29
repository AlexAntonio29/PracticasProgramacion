#include <stdio.h>

/*
Alexis Zosimo Antonio Angel

Determinar un precio
Fundamentos de programacion
11/10/2023
*/

int main(){
	//Entrada
	float precio,descuento;
	descuento=0;
	
	printf("Introuduce el precio del producto\n");
	
	scanf("%f",&precio);
	
	if(precio>0){
		printf("Precio original: %.2f\n",precio);
		if(precio>=1000) {
		 descuento=precio*.3;
		 printf("El precio ha aplicado un descuento del %.2f pesos\n", descuento);
		 }
		printf("El precio del producto es %.2f pesos",(precio-descuento));
	}
	else{
		printf("Precio mal implementado");
	}
	
	
	return 0;
}
