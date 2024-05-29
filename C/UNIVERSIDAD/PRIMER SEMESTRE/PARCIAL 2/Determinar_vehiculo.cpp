
/*
Alexis Zosimo Antonio Angel 
DETERMINAR VEHICULO:
Determine el color de la calcomania y el dia que no circula un vehiculo con base a su terminacion
de placa (1,2: lunes,amarillo;3,4:martes,rosa; 5,6 :miercoles,rojo; 7,8:jueves, verde 9,0: viernes, azul).

17/10/2023

*/

#include <stdio.h>

int main(){
	int seleccion;
	
	printf("Selecciona la terminacion del vehiculo para encontrar el color de calcomania y el dia que no circula\n 1,2,3,4,5,6,7,8,9,0\n");
	scanf("%d",&seleccion);
	if(seleccion>=0&&seleccion<=9){
	
		if(seleccion==1||seleccion==2) printf("El color de calcomania es amarillo y el dia que no cicrula es lunes");
		if(seleccion==3||seleccion==4)printf("El color de calcomania es rosa y el dia que no circula es martes");
		if(seleccion==5||seleccion==6)printf("El color de calcomania es rojo y el dia que no circula es miercoles");
		if(seleccion==7||seleccion==8)printf("El color de calcomania es verde y el dia que no circula es jueves");
		if(seleccion==9||seleccion==0)printf("El color de calcomania es azul y el dia que no circula es viernes");
		
	}
	else	{
			printf("\nSeleccion invalida");
	}
	
		
	return 0;	
}