//PilaIntDinamica.h 
#ifndef PILAINTDINAMICA_H
#define PILAINTDINAMICA_H

#include<stdio.h>
#include<stdlib.h>

typedef int TipoInfo;

struct nodo{
    TipoInfo info;
    struct nodo* sig;
};  //estructuras autoreferenciadas

typedef struct nodo TNodo;
typedef struct nodo* TLiga;
//typedef TNodo* TLiga;

void iniciaPila (TLiga *p)
{ *p = NULL; }

TLiga creaNodo()
{ //return (TLiga)malloc(sizeof(TNodo)); 
  return (struct nodo*) malloc(sizeof(struct nodo));
}

int pilaVacia(TLiga p)
{  
	if(p == NULL)
		return 1;
	else
		return 0; 
   //return p == NULL; 
}

int push(TLiga *p, TipoInfo x)
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
		printf("Memoria Insuficiente...\n");
        return 0;	
	}
	/*
    if(newp = creaNodo()){
        newp->info = x;
        newp->sig = *p;
        *p = newp;
        return 1; 
    } else{
        printf("Memoria Insuficiente...\n");
        return 0;
    } 
	*/      
}  

int pop(TLiga *p, TipoInfo *x)
{
    TLiga t;
    
    if(pilaVacia(*p) != 1){
    	t = *p;
    	*p = t->sig;
    	*x = t->info;
    	free(t);
    	return 1;
	}else{
		return 0;
	}
    
/*  if(!pilaVacia(*p)){
      t = *p;	
      *p = (*p)->sig;
	  *x = t->info;
      free(t);
      return 1;    
    }
	return 0;
	*/    
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
