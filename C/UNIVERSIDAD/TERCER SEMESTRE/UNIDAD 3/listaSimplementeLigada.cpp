#include <iostream>
#include <stdio.h>
#include <stdlib.h>

using namespace std;

typedef int TipoDato;

struct nodo
{
    TipoDato Info;
    struct nodo *Liga;
};

typedef struct nodo *TipoLista;

void inicializarLista(TipoLista &P)
{
    P = NULL;
}

bool listaVacia(TipoLista P)
{
    if (P == NULL)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void CrearInicio(TipoLista &P)
{
    TipoLista Q;
    int Res;
    P = new nodo;

    cout << "Escriba el valor del nodo: ";
    cin >> P->Info;
    P->Liga = NULL;

    cout << "Desea ingresar ms nodos a la lista? Si: 1, No: 0: ";
    cin >> Res;

    while (Res == 1)
    {
        Q = new nodo;
        cout << "Escriba el valor del nodo: ";
        cin >> Q->Info;
        Q->Liga = P;
        P = Q;

        cout << "Desea ingresar mas nodos a la lista? Si: 1, No: 0: ";
        cin >> Res;
    }
}

void Recorre_iterativo(TipoLista P)
{
    TipoLista Q = P;

    while (Q != NULL)
    {
        cout << Q->Info << " ";
        Q = Q->Liga;
    }
    system("pause");
}

void Recorre_Recursivo(TipoLista P)
{
    if (P != NULL)
    {
        cout << P->Info << " ";
        Recorre_Recursivo(P->Liga);
    }
}

int main()
{
    TipoLista P;
    inicializarLista(P);
    CrearInicio(P);

    cout << "Recorrido iterativo: " << endl;
    Recorre_iterativo(P);

    cout << "Recorrido recursivo: " << endl;
    Recorre_Recursivo(P);

    system("pause");
    
return 0;
}