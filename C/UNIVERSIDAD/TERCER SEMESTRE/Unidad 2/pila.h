//pila.h implementa una pila con un arreglo dinamico

#ifndef PILA_H   // abreviatura de if !defined (nombre)
#define	PILA_H   // (si no esta definido) definelo

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
        p->tope = -1;         //pila vacia
        return 1;           //sin error
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
	//return p.tope == -1;
}

int pilaLlena(TPila p)
{
		if (p.tope == (p.size-1)) 
			return 1;
		else 
			return 0;
	//return  p.tope == (p.size-1);
}

int push(TPila *p, Tipo n)
{
	
	pilaLlena(*p);
	if (pilaLlena(*p) != 1){
		p->tope++;
		p->vector[p->tope] = n;
		return 1;
	} else{
		printf("Overflow de la pila\n");
   		return 0;	
	}
	
	/*if(!pilaLlena(*p)){
      p->vector[++p->tope] = n;
      return 1;  // exito
   }
   else{
      printf("Overflow de la pila\n");
   	return 0; // error
   }
   */
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


/*	if(!pilaVacia(*p)){
   	*elem = p->vector[p->tope--];
      return 1; // exito
   }
   else{
   	printf("Underflow de la pila\n");
      return 0;  // error
   }
  */ 
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
/*	if(!pilaVacia(p)){
   	*elem = p.vector[p.tope];
      return 1; // exito
   }
   else{
   	printf("Pila Vacia\n");
      return 0; //error
   }
   */
}

#endif // fin de ifndef PILA_H
