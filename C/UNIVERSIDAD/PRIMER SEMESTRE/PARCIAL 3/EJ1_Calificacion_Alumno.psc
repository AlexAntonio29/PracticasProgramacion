Funcion promedioFinal<- calExamen ( parcial )
	
	suma<- 0
	parciales<-0
	Para i<- 1 Hasta parcial Con Paso 1 Hacer
		Escribir "Introduzca la calificacion del Examen" i
		leer parciales
		suma<- suma+parciales
	Fin Para
	
	suma<- suma/(i-1)
	
	
	Escribir "Introduzca calificacion de tareas"
	leer tareas
	Escribir "Introduzca calificacion de proyectos"
	leer proyecto
	Escribir "Introduzca calificacion de concursos"
	leer concurso
	
	promedioFinal<-redon((suma+tareas+proyecto+concurso)/4)
	
	
	
	
Fin Funcion



Algoritmo  Calificacion_Alumno
	
	PromedioF<-calExamen(3)
	Escribir "El promedio Final del alumno es " PromedioF

	
	
FinAlgoritmo
