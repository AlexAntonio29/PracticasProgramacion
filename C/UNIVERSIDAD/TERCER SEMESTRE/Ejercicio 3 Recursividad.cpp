#include <stdio.h>

int factorial_rec(int n){
		
	printf("%d\n",n);
	if(n<=1) return n; 

	else return n*factorial_rec(n-1);
	
}


int main(){
int n;
printf("Introduce el numero del factorial\n");
scanf("%d",&n);


printf("El factorial es %d", factorial_rec(n));
	return 0;
}


