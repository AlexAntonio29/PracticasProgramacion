//Alexis Zosimo Antonio Angel   202-B   bibfuncionesint.h

#ifndef BIBFUNCIONESINT_H
#define BIBFUNCIONESINT_H
#include <stdio.h>
#include <stdlib.h>

typedef int TDate;


struct nodo{
	TDate date;
	struct nodo* sig;
};

typedef struct nodo TNodo;
typedef  TNodo* Tliga;


typedef struct{
	Tliga inicio;
	Tliga final;
} TCola;

int CrearNodo(Tliga *p){
	*p=((Tliga ) malloc (sizeof(TNodo)));
	if(*p!=NULL) return 1;
	else return 0;
	
}


//Here is the dates for the add in the funtion

int AddDate(TCola *nod, TDate x){
	Tliga p;
	if(CrearNodo(&p)){//comprobar si funciona se crea el nodo
		//printf("Creacion correcta del nodo\n");
			p->date=x;
			
			p->sig=NULL;
			//printf("%d",nod->inicio->date);
		//	printf("\nBusqueda de error\n");
		if((nod->inicio)==NULL){
			//printf("ESTA VACIO EL NODO\n");
			nod->final=p;
			nod->inicio=p;
			
		}
		else{
		//	printf("\nNO ESTA VACIO\n");
			nod->final->sig=p;
			nod->final=p;
			
		}
		
		return 1;
	}
	else{
		
		printf("Error al crear nodo...");
		return 0;
	}
}

int DeleteDate(TCola *nod, TDate *p){
	Tliga NewNode;
	
	if((nod->inicio)!=NULL){
		*p=nod->inicio->date;
		 NewNode=nod->inicio;
		 
		nod->inicio=nod->inicio->sig;
		
		free(NewNode);
		if(nod->inicio==NULL) nod->final==NULL;
		
		 return 1;
	}
	else{
	 printf("\nSin datos\n");
		 return 0;	
	}
	
}


//Aqui se imprimiran los datos que se tienen que imprimir de la funcion main;
int PrintDate(TCola p){
	
	TDate x;
	Tliga q;
	q=p.inicio;
		while(q!=NULL){
			printf("=> %d",q->date);
			q=q->sig;
		}
}

#endif
