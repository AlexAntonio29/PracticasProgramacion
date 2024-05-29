//Ejercicio 2     Alexis Zosimo Antonio Angel   102-B 

#include<stdio.h>

int misterio1(int *v, int n );



main(){
	

int a[6] = {2, 4, 6, 8, 10, 12};

misterio1(a , 6); 

return 0;
}

int misterio1(int *v, int n ){//como el primero parametro es un arreglo se le puede mandar directamente un apuntador entero

int i;
for(i=0; i<n; i++)

printf("%d ", *(v++));//hace la impresion de cada dato del 
//arreglo a traves de aritmetica de apuntadores por lo que pasa cada espacio de un entero para recorrer al siguiente elemento del arreglo
printf("\n");

}

