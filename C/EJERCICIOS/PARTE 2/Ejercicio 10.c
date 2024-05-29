//Ejercicio 10   Alexis Zosimo Antonio Angel   102-B    

/*
10.Responda las preguntas que acompanan al siguientes programa

*/


#include <stdio.h>

int transforma(int *, int *);

int main(){
int *ptr1, *ptr2;

int  w1, w2, r;
w1 = 4;
w2 = 10;
ptr1 = &w1;
ptr2 = &w2;
r = *ptr1 * *ptr2;
printf("r = %d\n", r);

r = transforma(ptr1, ptr2); 
 // ¿Estamos usando paso de parametros  por valor
 // o paso de parametros por referencia ?   Estamos usando parametros por referencia ya que en ptr1 y ptr2 se le hace la declaracion que serian igual a w1 y w2 por lo tanto cualquier valor que sea modificado por esos tambien afectara a w1 y w2
 
 printf("r = %d\n", r);
// explique como se genera el valor de r    
/*Sabemos que el valor de r anteriormente la multiplicacion de *ptr1=4 y *ptr2=10  -> =40  esta cambia cuando adquiere los datos de la funcion 
lo cual adquiere parametros de ptr1 y ptr2 en las siguientes operaciones que profundizaremos mas adelante el p=3 y q=10 por lo que la 
multiplicacion da 30 y antes de que regrese el valor la variable aumente otra unidad a r por lo que r =31
*/



printf("w1 = %d\n", w1);
// Explique como se genera el valor de w1
/* Como ptr1 era un parametro por referencia podemos notar que al 
ser modificado en la funcion tambien w1 es modificado adquiriendo 
de un 4 a un 3 ya que se resta el valor de ptr1 y como es un apuntador de w1 pues esta tambien es modificada

*/

printf("w2 = %d\n", w2);
// Explique como se genera el valor de w2

/*
En w2 sucede algo similar que w1 ya que ptr2 es apuntador de w2 por lo que al ser enviado 
a la funcion esta logra adquirir dos unidades por lo que pasa de 10 a 12 en ptr2 por lo tanto tambien lo adquiere en w2
*/
return 0;
}
int transforma(int *p, int *q)
{
int h;
h = --*p * (*q)++; // explique esta linea de codigo
/*
h es un variable que adquiere la multiplicacion de p y q sin embargo estas son modificadas por operacion aritmetica de unidad, en p se le resta un valor antes de que haga la 
operacion y q despues de hacer la operacion por lo tando p que era 4 pasa a ser 3 y q= 10 sigue siendo 10 antes de la operacion y es modificado despues
*/

++*q; // explique esta linea de codigo

/*
q=11 en el apuntador pasa a ser 12 ya que se le hace la suma de otra unidad y como no hay otro factor que se realiza pues
hace la suma sin ningun inconveniente

*/
return ++h; // explique esta linea de codigo

/*como h =30 por la multiplicacion de q=3 y p=10 ->30 obtiene otra unidad antes de que regrese el valor de la funcion por lo que h=31 y ese valor es adquirido a r*/
}
