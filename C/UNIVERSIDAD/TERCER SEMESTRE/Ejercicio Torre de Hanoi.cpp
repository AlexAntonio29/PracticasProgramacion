#include <stdio.h>

#define n 100

//TORRE DE HANOI

int pila1r[n];
int pila2r[n];
int pila3r[n];

int pila1i[n];
int pila2i[n];
int pila3i[n];






void addRecursive(int lista, int i){

	if (lista>0) {
	pila1r[i]=i+1;
	
	printf("%d %d %d\n",pila1r[i],pila2r[i],pila3r[i]);
	 addRecursive(lista-1,i+1);
	}
		
	
}

void hanoiRecursive(){
	
}

void addIterative(){
		
}

int main(){
		
		
		printf("Unidad de Torres:");
		int torre;
		scanf("%d",&torre);
		addRecursive(torre, 0);
		
		
		
	

	
	return 0;
}