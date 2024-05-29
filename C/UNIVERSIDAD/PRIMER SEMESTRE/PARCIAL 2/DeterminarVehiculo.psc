Algoritmo DeterminarVehiculo
	
	Escribir "Introducir valor de un vehiculo del 0 al 9"
	Leer matricula
	
	si matricula>=0 & matricula<=9 Entonces
		si matricula==1|matricula==2 Entonces
			Escribir "El color de calcomania es amarillo y el dia que no cicrula es lunes"
		FinSi
		si matricula==3|matricula==4 Entonces
			Escribir "El color de calcomania es rosa y el dia que no circula es martes"
		FinSi
		si matricula==5|matricula==6 Entonces
			Escribir "El color de calcomania es rojo y el dia que no circula es miercoles"
		FinSi
		si matricula==7|matricula==8 Entonces
			Escribir "El color de calcomania es verde y el dia que no circula es jueves"
		FinSi
		si matricula==9|matricula==0 Entonces
			Escribir "El color de calcomania es azul y el dia que no circula es viernes"
		FinSi
	sino 
		Escribir "Valor invalido"
	FinSi
FinAlgoritmo
