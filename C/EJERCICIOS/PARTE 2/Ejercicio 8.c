// Ejericio 8  Alexis Zosimo Antonio Angel   102-B


/*

8.Si se declara 
char *a = Å"Bienvenidos a la UTMÅ";
y se hace la llamada  a la funcion
misterio4(a);
 Realice la corrida de escritorio de la llamada anterior e indique el proposito de la siguiente funcion:
 
 void misterio4(char *s){
 if(*s != '\0'){
 
 printf("%c ",*s);

misterio4(s+1);}
 
 }

*/


#include <stdio.h>
#include<string.h>
void misterio4(char *s){
	if(*s!='\0'){//verifica que la el caracter de la cadena llegue a su limite que en este caso es \0
		printf("%c", *s);//hace la impresion de cada caracter de la cadena
		misterio4(s+1);//utiliza la funcion recursiva recorriendo al siguiente caracter mediante suma aritmetica
	}
}
main(){
	
	char *a= "Bienvenidos a la UTM";//cadena a
	misterio4(a);//llamada a la funcion misterio4 con el parametro a
}
/*
En conclusion hace la imoresion de cada caracter de la cadena por separado 

NOTA: Esta funcion puede ser muy interesante para realizar cambios en la cadena sin que sufra errores, siempre y cuando se modifica bien
*/

