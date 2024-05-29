//Pila Floar Dinamica     Alexis Zosimo Antonio Angel    202-B    Tarea 1.2
#ifndef PILAFLOATDINAMICA_H
#define PILAFLOATDINAMICA_H

#include<stdio.h>
#include<stdlib.h>

typedef float TipoInfo;

struct nodo{
    TipoInfo info;
    struct nodo* sig;
};  

typedef struct nodo TNodo;
typedef struct nodo* TLiga;


void iniciaPila (TLiga *p)
{ *p = NULL; }

TLiga creaNodo()
{  
  return (struct nodo*) malloc(sizeof(struct nodo));
}

int pilaVacia(TLiga p)
{  
	if(p == NULL)
		return 1;
	else
		return 0; 
 
}

int AddDate(TLiga *p, TipoInfo x)
{
    TLiga newp;
    
    newp = creaNodo();
    if(newp != NULL){
    	newp->info = x;
    	newp->sig = *p;
    	*p = newp;
    	return 1;
	}
	else{
		printf("Memoria Llena!!!...\n");
        return 0;	
	}
      
}  

int ChangeDate(TLiga *p, TipoInfo *x)
{
    TLiga t;
    
 if(!pilaVacia(*p)){
 	
      t = *p;	
      *p = (*p)->sig;	 *x = t->info;
      free(t);
      return 1;    
    }
	return 0;
	    
} 

int topePila(TLiga p, TipoInfo *x)
{
    TLiga t;
    
    if(pilaVacia(p) != 1){
      *x = p->info;
      return 1;    
    }
	return 0;    
} 

#endif
