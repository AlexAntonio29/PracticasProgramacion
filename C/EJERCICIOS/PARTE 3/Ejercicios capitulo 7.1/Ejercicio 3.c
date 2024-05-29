//ejercicio 3

#include<stdio.h>

main(){
	
	FILE *bin;
	int i;
	
	bin= fopen("pares.dat","wb");
	
	for(i=1002;i<=5000;i=i+2){
fwrite(&i,sizeof(int),1,bin);
	}
	
	
	
	
//fwrite(&num,sizeof(int),1,bin);

fclose(bin);
return 0;
}
