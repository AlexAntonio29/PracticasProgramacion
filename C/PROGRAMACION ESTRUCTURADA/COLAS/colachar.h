//colachar.h crea una cola de caracteres

#ifndef COLACHAR_H
#define COLACHAR_H

#include<stdio.h>
#include<stdlib.h>

typedef char Tipo;

struct ColaChar{
    Tipo *vector;
    int frente, atras;
    int size;
};

typedef struct ColaChar TColaChar;

int initCola(TColaChar *q, int tamano)
{
    
    q->vector = (Tipo *)malloc(sizeof(Tipo)*tamano);
    if(q->vector!= NULL){
        q->frente = -1;
		q->atras = -1;
        q->size = tamano;
        return 1; //exito
    } else {
        printf("memoria insuficiente...\n");
        return 0; //error
    }    
}

int colaVacia(TColaChar q)
{
    if(q.frente == -1)
    	return 1;
    else 
    	return 0;
	//return q.frente == -1;
}    

int ColaLlena(TColaChar q)
{
    if (((q.atras+1) == q.frente) || ((q.atras == q.size-1) && (q.frente == 0)))
        return 1;
    else 
    	return 0;
	//return ((q.atras+1) == q.frente) || 
    //((q.atras == q.size-1) && (q.frente == 0));
}

int inserta(TColaChar *q, Tipo x)
{
	if(ColaLlena(*q) == 1){
		printf("Desbordamiento de la Cola...\n");
        return 0;//error	
	}else{
		if(q->atras == (q->size-1))
			q->atras = 0;
		else
		    q->atras = q->atras + 1;
		q->vector[q->atras] = x;
		if(q->frente == -1) q->frente = 0;
		return 1; //exito
	}
	
/*    if(ColaLlena(*q)){
        printf("Desbordamiento de la Cola...\n");
        return 0;//error
    }else{
        q->atras = q->atras == q->size-1 ? 0 : q->atras + 1;   
        q->vector[q->atras] = x;
        if (q->frente==-1)  q->frente = 0;
        return 1;//exito  
    }
*/       
}
  
int elimina(TColaChar *q, Tipo *elem)  
{
	if(colaVacia(*q)== 1){
		printf("Subdesbordamiento de la Cola...\n");
        return 0;//error
	}else{
		*elem = q->vector[q->frente];
		if(q->frente == q->atras){
			q->atras = -1;
			q->frente = -1;
		}else{
			if(q->frente == (q->size-1))
				q->frente = 0;
			else
			 	q->frente = q->frente + 1;
		}
		return 1;
	}
/*    if(colaVacia(*q)){
        printf("Subdesbordamiento de la Cola...\n");
        return 0;//error    
    }else{
        *elem = q->vector[q->frente];
        if(q->frente == q->atras)
              q->frente = q->atras = -1;        
        else   
             q->frente = q->frente == q->size-1 ? 0 : q->frente + 1;
        
    return 1;
    }
*/
} 

void liberaCola(TColaChar *q)
{
    free(q->vector);
    q->vector = NULL;
}   

#endif //Colachar 
