#include <stdio.h>

int main(){
	//Este es un comentario
	
	//printf("Hola mundo");
	
	int num1=20;
	int num2=10;
	
		printf("El resultado es %d\n", (num1+num2));
	

	float num3=15;
	float num4=17;
	printf("El segundo resultado es %.1f\n",(num3+num4));
	
	
	char nombre[]="Alexis";
	
	printf("Mi nombre es %s\n",nombre);
	
	char name[3];
	printf("Introduce tu nombre \n");
	scanf("%s", name);
	
	printf("Tu nombre es %s", name);

	return 0;
}
