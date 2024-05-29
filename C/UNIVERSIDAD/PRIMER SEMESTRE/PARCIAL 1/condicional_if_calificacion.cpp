#include <stdio.h>

int main(){
	
	int cal;
	printf("Ingresa la calificacion del alumno\n");
	scanf("%d",&cal);
	
	if (cal>=0&&cal<=100){
		if(cal>=70) printf("\nEl alumno aprobo");
	else printf("\nEl alumno reprobo");
	}
	else printf("\nLa calificacion no es valida");
	return 0;
}
