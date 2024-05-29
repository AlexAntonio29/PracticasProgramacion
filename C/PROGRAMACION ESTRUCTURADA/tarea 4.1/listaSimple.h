	//ListaSimple.h   Alexis Zosimo Antonio Angel  202-B    tarea 4.1. Funciones de Listas simple
#include<stdio.h>
#include<stdlib.h>

typedef int TipoInfo;

struct nodoSimple{
	TipoInfo info;
	struct nodoSimple* sig;
};

typedef struct nodoSimple TipoNodoS;
typedef struct nodoSimple* TLigaS;

//funciones con lista desordenadas
void inicializaListaS(TLigaS* ls);
TLigaS creaNodoS();
int insertaInicio(TLigaS* ls, TipoInfo x);
int listaSVacia(TLigaS ls);
int eliminaInicio(TLigaS* ls, TipoInfo *x);
void imprimeLista(TLigaS ls);

void liberaListaS(TLigaS *ls){
TLigaS repuesto,next;

repuesto= *ls;

while(repuesto!=NULL){
	*ls=repuesto->sig;
	free(repuesto);
	repuesto=*ls;
	
}
printf("Eliminacion lista completa\n");

}
// libera la memoria de todos los nodos que queden 
// en la lista y coloca la lista en null
int insertaFin(TLigaS *ls, TipoInfo x);
int eliminafin(TLigaS *ls, TipoInfo *x);
int insertaAntesY(TLigaS *ls, TipoInfo x, TipoInfo y);
int insertaDespuesY(TLigaS *ls, TipoInfo x, TipoInfo y);
int eliminaX(TLigaS *ls, TipoInfo x);
TLigaS concatenaListas1(TLigaS ls1, TLigaS Ls2); 
 //función que regresa una lista que contiene la información 
 //de la 1ra lista y después la infoirmación de la 2da lista
 // no modfifica las listas de entrada
void concatenaListas2(TLigaS *ls1, TLigaS Ls2); 
//función concatena la información de la primera lista con 
//la información de la segunda todo queda en la primera lista
//no modifica la segunda lista
TLigaS intercalaListas(TLigaS ls1, TLigaS Ls2);
//la Funcion debe regresar una lista con la inforción intercalada 
//de las dos lista empezando por el elemnto de la primera y luego 
//un elemneto de la segunda y así sucesivamente. Si termina una 
//lista colocar todos los elementos de la lista que queda. 
int insertaOrdenAsc(TLigaS *ls, TipoInfo x);
//la función supone que la lista esta ordenada Ascendentemente e inserta el 
//nuevo elemento en su lugar
void modificaInfomacion(TLigaS *ls, TipoInfo newInfo, TipoInfo x);
//esta función busca un elemento x y cambia la información por newInfo

//funciones con lista ordenadas
void ordenaListaAsc(TLigaS *ls);
//esta función entra una lista y la misma lista sale ordenada Ascendentemente
int insertaOrdenDes(TLigaS *ls, TipoInfo x);
//la función supone que la lista esta ordenada Descendentemente e inserta el 
//nuevo elemento en su lugar
void ordenaListaDes(TLigaS *ls);
//esta función entra una lista y la misma lista sale ordenada Descendentemente

int insertaFin(TLigaS *ls, TipoInfo x){
	TLigaS t, nuevo;
	
	nuevo = creaNodoS();
	if(nuevo != NULL){
		nuevo->info = x;
		nuevo->sig = NULL;
		if (listaSVacia(*ls) == 1){
			*ls = nuevo;
		} else{
			t = *ls;
			while(t->sig != NULL){
				t = t->sig;
			}
			t->sig = nuevo;
		}
		return 1;
	}
	printf("Memoria insuficiente...");
	return 0;
}
 
 int eliminafin(TLigaS *ls, TipoInfo *x){
 TipoInfo i,j;
TLigaS repuesto,antes;
TLigaS Nliga;
antes = NULL;
Nliga = NULL;
 
 if(listaSVacia(*ls)!=1){
 	
 	
 	
 	//printf("\nno vacia\n");
//imprimeLista(Nliga);
 	
 	
repuesto=*ls;

if(repuesto->sig != NULL){

//printf("\n\nprimera impresion\n\n");

while(repuesto->sig!=NULL){
	insertaInicio(&Nliga,repuesto->info);
	repuesto=repuesto->sig;
}
insertaInicio(&Nliga,repuesto->info);
*x=repuesto->info;
repuesto=*ls;
free(repuesto);

eliminaInicio(&Nliga, &i);

while(Nliga->sig!=NULL){
	insertaInicio(&antes,Nliga->info);
	Nliga = Nliga->sig;
}


insertaInicio(&antes,Nliga->info);
*ls=antes;
//*ls=Nliga;
}
else{
	eliminaInicio(&repuesto, &i);
	*ls=repuesto;
}
return 1;


 }else{
 	printf("memoria insuficiente...");
 	return 0;
 }
 }
 
TLigaS concatenaListas(TLigaS ls1, TLigaS ls2){
	TLigaS l3, t;
	
	inicializaListaS(&l3);

	t = ls1;	
	while(t !=NULL){
		insertaFin(&l3, t->info);
		t = t->sig;
	}
	
	t = ls2;
	while(t !=NULL){
		insertaFin(&l3, t->info);
		t = t->sig;
	}
	
	return l3;
} 
 
void inicializaListaS(TLigaS* ls){
	*ls = NULL;
}

TLigaS creaNodoS(){
	return (TLigaS)malloc(sizeof(TipoNodoS));
}

int insertaInicio(TLigaS* ls, TipoInfo x){
	TLigaS nuevo;
	
	nuevo = creaNodoS();

	if (nuevo != NULL){
		nuevo->info = x;
		nuevo->sig = *ls;
		*ls = nuevo;
		return 1;//exito
	}else{
		printf("Memoeria insuficiente...\n");
		return 0;//error
	}
}

int listaSVacia(TLigaS ls){
	if (ls == NULL)
		return 1;
	else
		return 0;
}

int eliminaInicio(TLigaS* ls, TipoInfo *x){
	TLigaS t;
	
	if(listaSVacia(*ls) != 1 ){
		t = *ls;
		*ls = t->sig;
		*x = t->info;
		free(t);
		return 1;//exito
	}else{
		printf("Memoeria insuficiente...\n");
		return 0;//error
	}
}

int eliminaX(TLigaS *ls, TipoInfo x){
	TLigaS t, ant;
	t = *ls;
	ant = *ls;
	
	while(t!=NULL && t->info != x){
		ant = t;
		t = t->sig;
	}
	
	if(t==NULL){
		printf("el elemento %d no esta en la lista", x);
		return 0;
	}else{
		if(ant == t){
			*ls = t->sig;
		}else{
			ant->sig = t->sig;
		}
		free(t);
		return 1;
	}
	
}

void imprimeLista(TLigaS ls){
	TLigaS t;
	
	t = ls;
	printf("\n\n Lista ");
	while(t != NULL){
		printf("==>%d",t->info);
		t = t->sig;
	}
}

int insertaOrdenAsc(TLigaS *ls, TipoInfo x){
	TLigaS t, ant, nuevo;
	
	t = *ls; ant = *ls;
	nuevo = creaNodoS();
	if (nuevo != NULL){
		nuevo->info = x;
		nuevo->sig = NULL;
		while(t!=NULL && t->info<x ){
		///while( t->info<x && t!=NULL ){ ERRORRRRRRRRRRRRRRRRR
			ant = t; 
			t = t->sig;
		}
	
		if(t == ant){
			nuevo->sig = t;
			*ls = nuevo;
		}else{
			nuevo->sig = t;
			ant->sig = nuevo;
		}
		return 1;
	}else{
		printf("memoria insuficiente...");
		return 0;
	}
	
}

void ordenaListaAsc(TLigaS *ls){
	TLigaS lt, t;
	
	inicializaListaS(&lt);
	t = *ls;
	while(listaSVacia(*ls) != 1){
		insertaOrdenAsc(&lt, t->info);
		*ls = t->sig;
		free(t);
		t = *ls;
	}	
	*ls = lt;
}

void concatenaListas2(TLigaS *ls1, TLigaS Ls2){
	TLigaS t;
	t=*ls1;
	
	while(Ls2->sig != NULL){
		insertaFin(&t, Ls2->info);
		Ls2 = Ls2->sig;
	}
	insertaFin(&t, Ls2->info);
	
	*ls1 = t;
	
}

TLigaS intercalaListas (TLigaS ls1, TLigaS ls2){

TLigaS ls3;
ls3 = NULL; 

while(ls1->sig!= NULL && ls2->sig != NULL){
	insertaFin(&ls3, ls1->info);
	insertaFin(&ls3, ls2->info);
	ls1=ls1->sig;
	ls2=ls2->sig;
}

if(ls1->sig== NULL && ls2->sig == NULL){
	insertaFin(&ls3, ls1->info);
	insertaFin(&ls3, ls2->info);	
}
if(ls1->sig!= NULL){
	insertaFin(&ls3, ls1->info);
	insertaFin(&ls3, ls2->info);
	
	while(ls1->sig!= NULL){
		ls1=ls1->sig;
		insertaFin(&ls3, ls1->info);
		
	}
}
if(ls2->sig!= NULL){
	insertaFin(&ls3, ls1->info);
	insertaFin(&ls3, ls2->info);
	
	while(ls2->sig!= NULL){
		ls2=ls2->sig;
		insertaFin(&ls3, ls2->info);
		
	}
}
	

return ls3;
}

void modificaInfomacion(TLigaS *ls, TipoInfo newInfo, TipoInfo x){
	
	TLigaS t, n;
	t = NULL;
	t= *ls;
	n= NULL;
	int date=0;
	if(t->info==x){
		t->info=newInfo;
		date=1;	
	}
	while(t->sig!=NULL){
		insertaFin(&n,t->info);
		t=t->sig;
		if(t->info==x){
		t->info=newInfo;
		date=1;	
	}
	
	}
insertaFin(&n,t->info);
	*ls=n;
	if(date==1){
		printf("\ndatos modificados\n");
	} else printf("\nNo se encontraron los datos\n");
	
}

int insertaOrdenDes(TLigaS *ls, TipoInfo x){
	
	TLigaS t, ant, nuevo;
	
	t = *ls; ant = *ls;
	nuevo = creaNodoS();
	if (nuevo != NULL){
		nuevo->info = x;
		nuevo->sig = NULL;
		while(t!=NULL && t->info>x ){
		
			ant = t; 
			t = t->sig;
			//printf("%d", t->sig);
		}
	//	t->sig=t;
		if(t == ant){
			nuevo->sig = t;
			*ls = nuevo;
		}else{
			nuevo->sig = t;
			ant->sig = nuevo;
		}
		return 1;
	}else{
		printf("memoria insuficiente...");
		return 0;
	}
	
}
		
void ordenaListaDes(TLigaS *ls){
TLigaS lt, t;
	
	inicializaListaS(&lt);
	t = *ls;
	while(listaSVacia(*ls) != 1){
		insertaOrdenDes(&lt, t->info);
		*ls = t->sig;
		free(t);
		t = *ls;
	}	
	*ls = lt;
	
			
}

int insertaAntesY(TLigaS *ls, TipoInfo x, TipoInfo y){
	
	
	
	
	TLigaS t, ant, nuevo;
	
	t = *ls; ant = *ls;
	nuevo = creaNodoS();
	if (nuevo != NULL){
		nuevo->info = y;
		nuevo->sig = NULL;
		while(t!=NULL && t->info>x ){
		
			ant = t; 
			t = t->sig;
		}
	
	//	if(t == ant){
	//		nuevo->sig = t;
	//		*ls = nuevo;
	//	}else{
			nuevo->sig = t;
			ant->sig = nuevo;
	//	}
		return 1;
	}else{
		printf("memoria insuficiente...");
		return 0;
	}
}

int insertaDespuesY(TLigaS *ls, TipoInfo x, TipoInfo y){
TLigaS t, ant, nuevo;
	
	t = *ls; ant = *ls;
	nuevo = creaNodoS();
	if (nuevo != NULL){
		nuevo->info = y;
		nuevo->sig = NULL;
		while(t!=NULL && t->info>x ){
		
			ant = t; 
			t = t->sig;
		}
	
		if(t == ant){
			nuevo->sig = t;
			*ls = nuevo;
		}else{
			nuevo->sig = t;
			ant->sig = nuevo;
		}
		return 1;
	}else{
		printf("memoria insuficiente...");
		return 0;
	}
	
	
	
}

