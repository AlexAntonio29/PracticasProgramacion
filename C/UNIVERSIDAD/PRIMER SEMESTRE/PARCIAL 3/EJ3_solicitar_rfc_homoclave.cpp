
/*
FUndamentos de programacion
Solicitar el RFC de una persona e imprimir su homoclave (últimos 3
caracteres)

Created by ALEXIS ZOSIMO ANTONIO ANGEL

20/11/2023

*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
void homoclave (char *rfc){//Creamos una funcion homoclave usamos en este caso rfc como apuntador
	char *hom;
	char palabra[100];
	int longitud= strlen(rfc)-3;    //creamos una longitud que es donde esta ubicada la homoclave para utilizar despues
		
		if (strlen(rfc)==13)
				printf("La homoclave de la persona fisica es %s",&rfc[longitud]);
			else
				printf("La homoclave de la persona moral es %s", &rfc[longitud]);
	
}

int main(){
	char hola[100];
	char rfc[100];


	printf("Introducir el RFC\n");
	scanf("%s",rfc);
	
	if (strlen(rfc)==13||strlen(rfc)==12)	homoclave(rfc);	
	else
		printf("RFC invalido...");
	
	
	return 0;
}
