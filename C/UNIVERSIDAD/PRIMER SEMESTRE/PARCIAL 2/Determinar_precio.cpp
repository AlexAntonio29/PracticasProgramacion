/*
Alexis Zosimo Antonio Angel 
PRECIOS DE PRENDAS:
En una tienda departamental se ofrece la promocion de llevarse tres prendas por el precio de las dos de mayor precio.
haga un programa que, dado los tres precios de las prendas determine la cantidad a pagar.




17/10/2023

*/

#include <stdio.h>

int main(){
float precio1,precio2,precio3;
float precioF;

printf("Inserte el valor del primer precio de la prenda1\n");
scanf("%f",&precio1);
printf("Inserte el valor del segundo precio de la prenda2\n");
scanf("%f",&precio2);
printf("Inserte el valor del tercer precio de la prenda3\n");
scanf("%f",&precio3);
//Aqui se verfica la condicion del precio
if(precio1>precio2) 
	if(precio2>precio3)precioF=precio2+precio1;
if(precio2>precio3) 
	 if(precio3>precio1)precioF=precio2+precio3;
if(precio3>precio1) 
	 if(precio1>precio2)precioF=precio3+precio1;
	 
	 
if(precio1>precio3) 
	if(precio3>precio2)precioF=precio3+precio1;
		
if(precio2>precio1) 
	 if(precio1>precio3)precioF=precio2+precio1;
	 
if(precio3>precio2) 
	 if(precio2>precio1)precioF=precio3+precio2;
	 	
	 
if (precio1==precio2) 
	if(precio2>precio3) precioF=precio2+precio1;
		else
			precioF=precio3+precio1;
	
if (precio2==precio3) 
	if(precio3>precio1) precioF=precio2+precio3;
		else 
			precioF=precio1+precio3; 
if (precio1==precio3) 
	if(precio3>precio2) precioF=precio3+precio1;
		else 
			precioF=precio1+precio2;

if (precio1==precio3&&precio3==precio2) precioF=precio1*2;




	printf("El precio1: %.2f\nEl precio2: %.2f\nEl precio3: %.2f\nPrecio Final: %.2f",precio1,precio2,precio3,precioF);


return 0;
}
