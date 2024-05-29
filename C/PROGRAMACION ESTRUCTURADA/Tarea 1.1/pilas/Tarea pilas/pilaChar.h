//Tarea 1.1  Pila Caractér  Alexis Zosimo Antonio Angel  202-B

#ifndef PILA_H   
#define	PILA_H   

#include<stdio.h>
#include<stdlib.h>

typedef char Tipo;

struct Pila{
    Tipo *vector;
    int tope;
    int size;
};

typedef struct Pila TPila;

int initPila(TPila *p, int tam)
{
    p->size = tam;
    p->vector = (Tipo *)malloc (sizeof(Tipo)*p->size);
    if (p->vector != NULL){
        p->tope = -1;        
        return 1;           
    }
    else
    	return 0;
}

void liberaPila(TPila *p)
{
	free(p->vector);
	p->vector = NULL;
}

int pilaVacia(TPila p)
{
	if (p.tope == -1) return 1;
	else return 0;

}

int pilaLlena(TPila p)
{
		if (p.tope == (p.size-1)) 
			return 1;
		else 
			return 0;

}

int push(TPila *p, Tipo n)
{
	if (pilaLlena(*p) != 1){
		p->tope++;
		p->vector[p->tope] = n;
		return 1;
	} else{
		printf("Overflow de la pila\n");
   		return 0;	
	}

}

int pop(TPila *p, Tipo *elem)
{
	if(pilaVacia(*p) != 1){
		*elem = p->vector[p->tope];
		p->tope--;	
		return 1;
	}else{
		printf("Underflow de la pila\n");
      	return 0;	
	}


}


int topePila(TPila p, Tipo *elem)
{
	if(pilaVacia(p) != 1){
		*elem = p.vector[p.tope];
		return 1;
	}else{
   		printf("Pila Vacia\n");
      return 0;
	}

}

#endif 
