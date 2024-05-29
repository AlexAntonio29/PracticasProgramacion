//Ejercicio 2

#include<stdio.h>

main(){
	
	FILE *leer;
	int c , g,j=0;
	char l;
	leer= fopen("tabla_REGISTRO.txt","r");
	
	while(!feof(leer)){
		if(j==10){
			j=0;
			printf("\n");
		}
		fscanf(leer,"%d %c %c",&c,&l,&g);
		printf("%d %c %c   ",c,l ,g);
		j++;
		
	} 
	
	
	fclose(leer);
	getchar();
	return 0;
}
