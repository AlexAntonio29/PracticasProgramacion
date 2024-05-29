
/*
FUndamentos de programacion
Programa que calcule la calificacion final de un alumno

Created by ALEXIS ZOSIMO ANTONIO ANGEL

20/11/2023

*/


#include <stdio.h>



int promF(int parcial){
	
	int i,promParcial,tarea,proyecto,concurso,ExamenF=0,r;
	
	for(i=1; i<=parcial;i++){
		
		printf("Introduce el promedio del Examen %d\n",i);
		scanf("%d",&promParcial);
		
		ExamenF+=promParcial;
		
		
	}
	ExamenF=ExamenF/3;
	
	printf("Introduce el promedio de las tareas\n");
		scanf("%d",&tarea);
	
	printf("Introduce el promedio de las Proyecto\n");
		scanf("%d",&proyecto);
	printf("Introduce el promedio de las Concurso\n");
		scanf("%d",&concurso);
	r=(ExamenF+tarea+proyecto+concurso)/4;
	return r;
	
}



int main(){
	int promedioF=promF(3);
	
	printf("\nEl promedio Final del alumno es %d",promedioF);
	return 0;
}
