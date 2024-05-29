//Ejercicio 4

#include<stdio.h>

main(){
	
	FILE *imp;
	int i,j=0,k=0,estandar;
	
	imp= fopen("pares.dat","rb");

	
	while(!feof(imp)){
	

		
			if(j==10){
		j=0;
			printf("\n");
		}
		
	
		
		fread(&estandar,sizeof(int),1,imp);
	
		if(imp==NULL)printf("ERROR\n");
	if(estandar==5000&&k==0) {
		printf("%d\t",estandar); 
		k=1;
	}
	if(estandar!=5000)
		printf("%d\t",estandar); 

		j++;
		
		

	}
	
	fclose(imp);
	
	return 0;
}
