#include <stdio.h>

int main(){
	
	int edad;
	
	
	printf("Introduce tu edad\n");
	scanf("%d",&edad);
	
	if ( edad <=0||edad>=120)
		printf("Edad erroneo");
	
	else 
		if (edad>=18)
		printf("Se puede tramitar licencia");
		else 
			if (edad>=16) 
				printf("Se puede tramitar permiso");
				else printf("No se puede tramitar ni licencia ni permiso");
		
	
	return 0;
	}
	

