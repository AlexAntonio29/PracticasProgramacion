

//EJERCICIO 1 ALEXIS ZOSIMO ANTONIO ANGEL  102-B


#include<stdio.h>




main(){
	int i;
FILE *ascii;

ascii= fopen("tabla_REGISTRO.txt","w");
	
for(i=33;i<=254;i++){
		fprintf(ascii,"%d = %c \n",i,i);
		
	}

	return 0;
	
}
