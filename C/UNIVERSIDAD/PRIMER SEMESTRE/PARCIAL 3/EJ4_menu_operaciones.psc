Funcion r<-rectangulo
	Escribir "Introduzca la base del rectangulo"
	leer base
	Escribir "Introduzca la altura del rectangulo"
	leer altura
	
	r<-base*altura
FinFuncion

Funcion r<-triangulo
	Escribir "Introduzca la base del traingulo"
	leer base
	Escribir "Introduzca la altura del triangulo"
	leer altura
	
	r<-(base*altura)/2
FinFuncion
Funcion r<-cuadrado
	Escribir "Introduzca el lado del cuadrado"
	leer lado
	r<-lado^2
FinFuncion
Funcion r<-circulo
	Escribir "Introduzca el radio del circulo"
	leer radio
	
	r<-PI*radio^2
FinFuncion


Funcion menu
	Definir area Como Real
	Definir select Como Caracter
	Escribir "***************************************************************"
	Escribir "Selecciona cual de las operaciones deseas realizar:"
	Escribir "1) Calcular el área de un rectángulo"
	Escribir "2) Calcular el área de un triángulo"
	Escribir "3) Calcular el área de un cuadrado"
	Escribir "4) Calcular el área de un círculo"
	Escribir "5) Salir"
	
	leer select
	Escribir "****************************************************************"
	Segun select Hacer
		"1":
			area<-rectangulo
		"2":
			area<-triangulo
		"3":
			area<-cuadrado
		"4":
			area<-circulo
		"5":
			Escribir "SALIENDO..."
			
		De Otro Modo:
			Escribir ""
			Escribir ""
			Escribir 	"DATO INVALIDO...INTENTE NUEVAMENTE"
			Escribir ""
			Escribir ""
			
			menu
	Fin Segun
	si select<>"5" Entonces
		
		Escribir "El area es " area
	FinSi
	
FinFuncion



Algoritmo menu_operaciones
	
	menu
	
FinAlgoritmo
