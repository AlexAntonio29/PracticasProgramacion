
/*
FUndamentos de programacion
Programa que obtenga el numero al azar de un dado

Created by ALEXIS ZOSIMO ANTONIO ANGEL

20/11/2023

*/


#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int dado(){
	srand(time(NULL));
	int lanzado= (rand() %6)+1;
	
	printf("Al caer el dado, nos da como resultado %d", lanzado);
	
}

int main(){
	
	printf("Se lanza un dado al aire...\n");
	
	dado();
	
	
	
	return 0;
}
