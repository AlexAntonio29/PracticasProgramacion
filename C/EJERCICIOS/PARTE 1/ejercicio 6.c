#include<stdio.h>
#include<math.h>
//ejercicio 6
main(){
	float a,b,c,raiz,x1,x2;
	printf("Se va a resolver una ecuacion de segundo grado    ax^2+bx+c\n");
		printf("Introduce el valor de ax^2\n");
		scanf("%f",&a);
		printf("Introduce el valor de bx\n");
		scanf("%f",&b);
		printf("Introduce el valor de c\n");
		scanf("%f",&c);
		raiz=((b*b)-(4*a*c));
		
		if(raiz<0){
			printf("El polinomio es imaginario");
			
		}else{
			x1=(-b+(sqrt(raiz)))/(2*a);
			x2=(-b-(sqrt(raiz)))/(2*a);
			
			printf("X1 es %f",x1);
			
			printf("X2 es %f",x2);
		}
		
	return 0;		
		
}
