#include <stdlib.h>
#include <stdio.h>
#include <iostream>


/*
Listas Doblemente Ligadas

Alexis Zosimo Antonio Angel

3B

Estructura de datos

*/


using namespace std;

typedef int TipoDato;

struct nodo {
    TipoDato Info;
    nodo* LigaIzq;
    nodo* LigaDer;
};

typedef nodo* TipoListaDoble;

void InicializarListaDoble(TipoListaDoble& P, TipoListaDoble& F) {
    P = NULL;
    F = NULL;
}

bool ListaVacia(TipoListaDoble P, TipoListaDoble F) {
    return P == NULL && F == NULL;
}

void RecorridoIzq(TipoListaDoble F) {
    TipoListaDoble Q = F;
    while (Q != NULL) {
        cout << Q->Info << "\t";
        Q = Q->LigaIzq;
    }
    cout << endl;
}

void RecorridoDer(TipoListaDoble P) {
    TipoListaDoble Q = P;
    while (Q != NULL) {
        cout << Q->Info << "\t";
        Q = Q->LigaDer;
    }
    cout << endl;
}

void InsertarInicio(TipoListaDoble& P, TipoListaDoble& F, TipoDato Dato) {
    TipoListaDoble Q = new nodo;
    Q->Info = Dato;
    Q->LigaIzq = NULL;
    Q->LigaDer = P;

    if (ListaVacia(P, F)) {
        F = Q;
    } else {
        P->LigaIzq = Q;
    }

    P = Q;
}

void InsertarFinal(TipoListaDoble& P, TipoListaDoble& F, TipoDato Dato) {
    TipoListaDoble Q = new nodo;
    Q->Info = Dato;
    Q->LigaDer = NULL;
    Q->LigaIzq = F;

    if (ListaVacia(P, F)) {
        P = Q;
    } else {
        F->LigaDer = Q;
    }

    F = Q;
}

void EliminarAntes(TipoListaDoble &P, TipoListaDoble &F, TipoDato Ref) {
    TipoListaDoble Q, T, R;

    if (ListaVacia(P, F)) {
        cout << "La lista está vacía." << endl;
        return;
    }

    Q = P;
    while (Q != NULL && Q->Info != Ref) {
        Q = Q->LigaDer;
    }

    if (Q == NULL) {
        cout << "Referencia no encontrada." << endl;
        return;
    }

    if (Q->LigaIzq == NULL) {
        cout << "No hay un nodo anterior a la referencia." << endl;
        return;
    }

    T = Q->LigaIzq; // Nodo a eliminar

    if (T->LigaIzq != NULL) {
        R = T->LigaIzq;
        R->LigaDer = Q;
        Q->LigaIzq = R;
    } else {
        P = Q; // T era el primer nodo
        Q->LigaIzq = NULL;
    }

    delete T;
    cout << "Nodo anterior eliminado correctamente." << endl;
}

void InsertarXAntes(TipoListaDoble &P, TipoListaDoble &F, TipoDato Dato, TipoDato X) {
    if (ListaVacia(P, F)) {
        cout << "La lista está vacía." << endl;
        return;
    }

    TipoListaDoble Q = P;

    while (Q != NULL && Q->Info != X) {
        Q = Q->LigaDer;
    }

    if (Q == NULL) {
        cout << "Referencia no encontrada." << endl;
        return;
    }

    TipoListaDoble T = new nodo;
    T->Info = Dato;
    T->LigaDer = Q;
    T->LigaIzq = Q->LigaIzq;

    if (Q->LigaIzq != NULL) {
        Q->LigaIzq->LigaDer = T;
    } else {
        P = T; // T es el nuevo primer nodo
    }

    Q->LigaIzq = T;
    cout << "Nodo insertado antes de la referencia." << endl;
}

void InsertarX(TipoListaDoble &P, TipoListaDoble &F, TipoDato Dato, TipoDato X) {
    if (ListaVacia(P, F)) {
        cout << "La lista está vacía." << endl;
        return;
    }

    TipoListaDoble Q = P;

    while (Q != NULL && Q->Info != X) {
        Q = Q->LigaDer;
    }

    if (Q == NULL) {
        cout << "Referencia no encontrada." << endl;
        return;
    }

    TipoListaDoble T = new nodo;
    T->Info = Dato;
    T->LigaIzq = Q;
    T->LigaDer = Q->LigaDer;

    if (Q->LigaDer != NULL) {
        Q->LigaDer->LigaIzq = T;
    } else {
        F = T; // T es el nuevo último nodo
    }

    Q->LigaDer = T;
    cout << "Nodo insertado después de la referencia." << endl;
}


void EliminarInicio(TipoListaDoble& P, TipoListaDoble& F) {
    if (ListaVacia(P, F)) {
        cout << "La lista está vacía." << endl;
        return;
    }

    TipoListaDoble Q = P;
    P = P->LigaDer;

    if (P != NULL) {
        P->LigaIzq = NULL;
    } else {
        F = NULL; // Si solo había un nodo
    }

    delete Q;
}

void EliminarFinal(TipoListaDoble& P, TipoListaDoble& F) {
    if (ListaVacia(P, F)) {
        cout << "La lista está vacía." << endl;
        return;
    }

    TipoListaDoble Q = F;
    F = F->LigaIzq;

    if (F != NULL) {
        F->LigaDer = NULL;
    } else {
        P = NULL; // Si solo había un nodo
    }

    delete Q;
}

void EliminarDespues(TipoListaDoble& P, TipoListaDoble& F, TipoDato Ref) {
    if (ListaVacia(P, F)) {
        cout << "La lista está vacía." << endl;
        return;
    }

    TipoListaDoble Q = P;
    while (Q != NULL && Q->Info != Ref) {
        Q = Q->LigaDer;
    }

    if (Q == NULL || Q->LigaDer == NULL) {
        cout << "No hay un nodo posterior a la referencia." << endl;
        return;
    }

    TipoListaDoble T = Q->LigaDer;
    Q->LigaDer = T->LigaDer;

    if (T->LigaDer != NULL) {
        T->LigaDer->LigaIzq = Q;
    } else {
        F = Q; // Si T era el último nodo
    }

    delete T;
}

int main() {
    TipoListaDoble P, F;
    InicializarListaDoble(P, F);

    int opcion, dato, ref;

    do {
        cout << "\n--- MENU ---" << endl;
        cout << "1. Insertar al inicio" << endl;
        cout << "2. Insertar al final" << endl;
        cout << "3. Insertar antes de un nodo" << endl;
        cout << "4. Insertar despues de un nodo" << endl;
        cout << "5. Eliminar nodo al inicio" << endl;
        cout << "6. Eliminar nodo al final" << endl;
        cout << "7. Eliminar nodo antes de referencia" << endl;
        cout << "8. Eliminar nodo despues de referencia" << endl;
        cout << "9. Mostrar lista de izquierda a derecha" << endl;
        cout << "10. Mostrar lista de derecha a izquierda" << endl;
        cout << "0. Salir" << endl;
        cout << "Seleccione una opcion: ";
        cin >> opcion;

        switch (opcion) {
            case 1:
                cout << "Ingrese el dato: ";
                cin >> dato;
                InsertarInicio(P, F, dato);
                break;

            case 2:
                cout << "Ingrese el dato: ";
                cin >> dato;
                InsertarFinal(P, F, dato);
                break;

            case 3:
                cout << "Ingrese la referencia: ";
                cin >> ref;
                cout << "Ingrese el dato: ";
                cin >> dato;
                InsertarXAntes(P, F, dato, ref);
                break;

            case 4:
                cout << "Ingrese la referencia: ";
                cin >> ref;
                cout << "Ingrese el dato: ";
                cin >> dato;
                InsertarX(P, F, dato, ref);
                break;

            case 5:
                EliminarInicio(P, F);
                break;

            case 6:
                EliminarFinal(P, F);
                break;

            case 7:
                cout << "Ingrese la referencia: ";
                cin >> ref;
                EliminarAntes(P, F, ref);
                break;

            case 8:
                cout << "Ingrese la referencia: ";
                cin >> ref;
                EliminarDespues(P, F, ref);
                break;

            case 9:
                cout << "Lista de izquierda a derecha:" << endl;
                RecorridoDer(P);
                break;

            case 10:
                cout << "Lista de derecha a izquierda:" << endl;
                RecorridoIzq(F);
                break;

            case 0:
                cout << "Saliendo del programa..." << endl;
                break;

            default:
                cout << "Opcion no valida. Intente de nuevo." << endl;
        }
    } while (opcion != 0);

    return 0;
}
