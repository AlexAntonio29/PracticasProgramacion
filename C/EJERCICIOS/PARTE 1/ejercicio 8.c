//pregunta 1

#include<stdio.h>
#include<math.h>
#include<stdbool.h>
main(){
	
	float x, i, j,l,opr,fact,k;
	int n;
	bool v=true;

	
	opr=-1;
	k=3;
	j=1;
	l=4;
	
		printf("Introducir el valor x ");
	
	scanf("%f",&x);
	
	printf("Introducir el valor de n terminos para la variable x ");
	
	scanf("%d",&n);
	
	for (i=1;i<=n;i++) {
		fact=1;
		
	for(j=l;j>1;j--){
		fact*=j;
	
		
	}
		if(v==true){
			opr+=(pow (x,k))/fact;
			v=false;
		} else{
				
			opr-=(pow (x,k))/fact;
			v=true;
		}
		k=k+2;
		l=l+2;
	}
	
	printf("El valor de la operacion %f con n=%d es = %f",x,n,opr);
	
	return 0;
	
}
