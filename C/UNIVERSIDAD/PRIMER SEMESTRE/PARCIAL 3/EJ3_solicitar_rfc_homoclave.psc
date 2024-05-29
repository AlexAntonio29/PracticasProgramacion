
Funcion h<- homoclave(rfc)
	Definir j Como Caracter
	long<-Longitud(rfc)-3
	
	
		Para i<-1 Hasta 3 Con Paso 1 Hacer
			j<- Subcadena(rfc,long+i,long+i)
			h<-h+""+j
		Fin Para
FinFuncion

Algoritmo solicitar_rfc
	
	
	Definir rfc Como Caracter
	Escribir "Introducir RFC"
	leer rfc
	si Longitud(rfc)==12 o Longitud(rfc)==13 Entonces
		homo<-homoclave(rfc)
		
		si Longitud(rfc)==12 Entonces
			Escribir "La homoclave de la persona fisica es " homo
		SiNo
			Escribir "La homoclave de la persona moral es " homo
		FinSi
	
	SiNo
		Escribir "RFC invalido..."
	FinSi
	
	
	
FinAlgoritmo
