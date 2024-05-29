//pregunta 2.c  Alexis Zosimo Antonio Angel

#include<stdio.h>

int main(){
	int a,b, c,num1,num2,num3;
	char s;
	printf("Introduzca un entero entre de 3 a 20: ");
	scanf("%d",&num1);
	while(!(num1>3 && num1<20)){
			printf("Introduzca un entero entre de 3 a 20: ");
	scanf("%d",&num1);
		
	}
	printf("Introduzca un caracter: ");
	fflush(stdin);
	num2=num1;
	num3=num2;
	
	
	
	scanf("%c",&s);

	for(c=1 ; c<=num3 ; c++ ){
		printf("%c",s);
	}
	printf("\n");
				for (b = 1; b<=num2-2; b++){
		printf("%c",s);
		for(a = 1; a<=num1-2; a++){
		printf(" ");
		}
		printf("%c\n",s);
	}
				for(c=1 ; c<=num3 ; c++ ){
			printf("%c",s);
					}
	
	return 0;

}
