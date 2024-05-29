//Ejercicio 6     Alexis Zosimo Antonio Angel   102-B 

#include <stdio.h>


int buscar (int *v, int n, int key);


main()
{
int n=10, numero[10]={10,20,30,40,50,60,70,80,90,100}, key=50, p;

p=buscar(numero,n,key);


printf("numero [%d]= %d",p,key);
	}
	
	int buscar (int *v, int n, int key){
		
		int i;
		
		
		
		for(i=0;i<n;i++){
			
			if(*(v)==key){//Se utiliza el apuntador del arreglo v para indicar los datos que tiene almacenado dicha 
			//memoria para verificar si el valor buscado se encuentra en esa zona
					return i;//regresa el valor de donde esta almacenada el dato buscado debemos de tomar en cuenta que es la zona del espacio del arreglo por lo que si el valor 
					//buscado se encuentra en el septimo elemento se regresara 6 ya que sabemos que los arreglos comienzan con 0 hasta n-1
			}
	v++;//se suma aritmeticamente el apuntador para pasar al siguiente elemento, debemos tener en cuenta que se suman 4 bytes ya que este es el valor que ocupa un entero
		}
		
		
		return -1;
	}
