/*
Ejercicio 7     Alexis Zosimo Antonio Angel   102-B 


7. Si se declara
char *a = Å"Bienvenidos a la UTMÅ";
y se hace la llamada a la funcion
misterio3(a);
Realice la corrida de escritorio de la llamada anterior e indique
el proposito de la siguiente funcion:
void misterio3(char *s){
if(*s != '\0'){
misterio3(s+1);
printf("%c ",*s);
}
}
*/

#include<stdio.h>


 void misterio3(char *s){
 	
 	if(*s!='\0'){//Sabemos que \0 es utilizado para indicar que la cadena termina por lo tanto se usa para indicar que ya no hay mas caracteres
 		misterio3(s+1); //se hace el llamado a la funcion recursiva haciendo el recorrido al siguiente caracter
 		printf("%c", *s);//se hace la impresion de cada caracter despues de que termine las funciones recursivas
	 }
 }
main(){
	char *a="Bienvenidos a la UTM";//se nombra la cadena de textos
	
	misterio3(a);//se envia a la funcion misterio3
}
/*
En conclusion lo que hace el programa es utilizar funciones recursivas haciendo el uso de cada 
caracter de la cadena por lo tanto al concluir la recursividad hace la impresion de el caracter 
por lo que como concluye al final imprime la los caracteres de manera inversa.

*/
