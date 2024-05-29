//PruebalistaS.c  Alexis Zosimo Antonio Angel  202-B    tarea 4.1. Funciones de Listas simple
#include<stdio.h>
#include"listaSimple.h"

main(){
	TLigaS lista, l1, l2, l3, lordenada, ldes;
	int x;
	
	inicializaListaS(&lista);
	
	printf("\ninserta Inicio 5");
	insertaInicio(&lista, 5);
	imprimeLista(lista);
	
	printf("\ninserta Inicio 15");
	insertaInicio(&lista, 15);
	imprimeLista(lista);
	
	printf("\ninserta Inicio 25");
	insertaInicio(&lista, 25);
	imprimeLista(lista);
	
	printf("\nElimina el inicio");
	eliminaInicio(&lista, &x);	
	imprimeLista(lista);
	
	printf("\nElimina el inicio");
	eliminaInicio(&lista, &x);	
	imprimeLista(lista);
	
	printf("\nElimina el inicio");
	eliminaInicio(&lista, &x);	
	imprimeLista(lista);


//Probar concatena 1
inicializaListaS(&l1);
inicializaListaS(&l2);
insertaInicio(&l1, 3);	insertaInicio(&l1, 7); insertaInicio(&l1, 11);
insertaInicio(&l2, 13);	insertaInicio(&l2, 17); 
imprimeLista(l1);
imprimeLista(l2);

l3 = concatenaListas(l1,l2);
imprimeLista(l3);


//Probar inserta en orden
printf("\n\n");
inicializaListaS(&lordenada);
insertaOrdenAsc(&lordenada, 9);
imprimeLista(lordenada);
insertaOrdenAsc(&lordenada, 5);
imprimeLista(lordenada);
insertaOrdenAsc(&lordenada, 11);
imprimeLista(lordenada);
insertaOrdenAsc(&lordenada, 7);
imprimeLista(lordenada);
insertaOrdenAsc(&lordenada, 4);
imprimeLista(lordenada);
insertaOrdenAsc(&lordenada, -40);
imprimeLista(lordenada);
insertaOrdenAsc(&lordenada, 1000);
imprimeLista(lordenada);

printf("\n\n");
///probar elimina x
eliminaX(&lordenada,11);
imprimeLista(lordenada);
eliminaX(&lordenada,-40);
imprimeLista(lordenada);
eliminaX(&lordenada,1000);
imprimeLista(lordenada);


//Probar ordena lista
printf("\n\n");
	inicializaListaS(&ldes);
	insertaInicio(&ldes, 15);
	imprimeLista(ldes);
	insertaInicio(&ldes, 25);
	imprimeLista(ldes);
	insertaInicio(&ldes, 104);
	imprimeLista(ldes);
	insertaInicio(&ldes, 70);
	imprimeLista(ldes);
	insertaInicio(&ldes, -20);
	imprimeLista(ldes);
	insertaInicio(&ldes, 1000);
	imprimeLista(ldes);

	ordenaListaAsc(&ldes);
	imprimeLista(ldes);



//libera lista completa 
	printf("\n\nLiberar lista\n");
	liberaListaS(&ldes);
		//printf("\n\nLiberar lista\n");
	imprimeLista(ldes);

	printf("\n\n\nInsertar fin y Eliminar fin\n");
	
	//Insertafin y Elimina fin
	
	insertaFin(&ldes,20);
	imprimeLista(ldes);
	insertaFin(&ldes,30);
	imprimeLista(ldes);
	insertaFin(&ldes,40);
	imprimeLista(ldes);
	insertaFin(&ldes,50);
	imprimeLista(ldes);
	insertaFin(&ldes,60);
	imprimeLista(ldes);
	
	printf("\nEliminar fin\n");
	
	eliminafin(&ldes, &x);
	imprimeLista(ldes);
	eliminafin(&ldes, &x);
	imprimeLista(ldes);
	eliminafin(&ldes, &x);
	imprimeLista(ldes);
	eliminafin(&ldes, &x);
	imprimeLista(ldes);
	eliminafin(&ldes, &x);
	imprimeLista(ldes);

	
	
	
	
	
	printf("\n\n\nConcatenar lista 2\n");
	
	
	//Concatenar Lista 2 a 1
	imprimeLista(l1);
	imprimeLista(l2);
	concatenaListas2(&l1,l2);
	imprimeLista(l1);
	
	printf("\n\n\nIntercalar listas\n");
	//TLigaS intercalaListas(TLigaS ls1, TLigaS Ls2);
	
	liberaListaS(&l1);
	liberaListaS(&l2);
	printf("\nlista de l1 impar:\n");
	insertaFin(&l1, 1);
	insertaFin(&l1, 3);
	insertaFin(&l1, 5);
	insertaFin(&l1, 7);
	
	imprimeLista(l1);
	printf("\nlista de l2 par:\n");
	insertaFin(&l2, 2);
	insertaFin(&l2, 4);
	insertaFin(&l2, 6);
	insertaFin(&l2, 8);
	insertaFin(&l2, 10);
	insertaFin(&l2, 12);
	insertaFin(&l2, 14);
	insertaFin(&l2, 16);
	imprimeLista(l2);
	
	printf("\nOperacion intercalar:\n");
	
	imprimeLista(intercalaListas(l1,l2));
	
	
	//Modificar informacion
	
	printf("\nModificando datos\n");
	imprimeLista(l1);
	modificaInfomacion(&l1, 10, 7);
	imprimeLista(l1);
	
	//inserta datos descendentemente

	insertaFin(&ldes,50);
	insertaFin(&ldes,40);
	insertaFin(&ldes,30);
	insertaFin(&ldes,20);
	insertaFin(&ldes,10);
	imprimeLista(ldes);
 	
 	insertaOrdenDes(&ldes,35);
 	imprimeLista(ldes);
 	
 	
 	liberaListaS(&ldes);
 	//ordena lista descendentemente
 	insertaFin(&ldes,20);
	insertaFin(&ldes,40);
	insertaFin(&ldes,30);
	insertaFin(&ldes,15);
	insertaFin(&ldes,18);
	insertaFin(&ldes,50);
 	imprimeLista(ldes);
 	
 	ordenaListaDes(&ldes);
 	imprimeLista(ldes);
 	
 	printf("\n\n\nHERE!!!\n\n\n\n");
 	//Antes de Y
 	printf("\n\nAntes de Y\n");
 	imprimeLista(ldes);
 	insertaAntesY(&ldes,30,12);
	imprimeLista(ldes);
		
		
		//Despues de Y
 	printf("\n\nDeespues de Y\n");
 	imprimeLista(ldes);
 	insertaDespuesY (&ldes,30,65);
	imprimeLista(ldes);
		return 0;
}

