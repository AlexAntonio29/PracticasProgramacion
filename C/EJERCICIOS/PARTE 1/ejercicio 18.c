//ejercicio 18

#include<stdio.h>
#include<math.h>
main(){
	
	float x, i, j,opr,fact;
	int n;
	
	opr=1;

	j=1;
	
		printf("Introducir el valor x ");
	
	scanf("%f",&x);
	
	printf("Introducir el valor de n para la variable x ");
	
	scanf("%d",&n);
	
	for (i=1;i<=n;i++) {
		fact=1;
		
	for(j=i;j>1;j--){
		fact*=j;
	
		
	}
		
		opr+=(pow (x,i))/fact;
	}
	
	printf("El valor de la operacion %f con n=%d es = %f",x,n,opr);
	
	return 0;
	
}
