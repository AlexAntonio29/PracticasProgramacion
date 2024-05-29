//Ejercicio 5 Alexis Zosimo Antonio Angel   102-B 

#include<stdio.h>//Hola que tal intento hacer un programa del ejercicio cinco durante las vacaciones    HOLA QUE TAL INTENTO HACER UN PROGRAMA DEL EJERCICIO CINCO DURANTE LAS VACACION
#include<string.h>
main(){
	char cadena[]="HOLA QUE TAL INTENTO HACER UN PROGRAMA DEL EJERCICIO CINCO DURANTE LAS VACACION";
	int i;
	
printf("%s\n\n",cadena);

for(i=0;i<80;i++){
	if(*(cadena+i)=='A') *(cadena+i)='4';
	if(*(cadena+i)=='E') *(cadena+i)='3';
	if(*(cadena+i)=='I') *(cadena+i)='1';
	if(*(cadena+i)=='O') *(cadena+i)='0';
	
	

	
}

printf("%s\n\n",cadena);

	
	
}


