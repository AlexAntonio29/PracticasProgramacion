//En esta practica abra una recopilacion de ejercicios sencillos para ponerlos en practica y ver si se comprende los pasos de la programacion basica

//Realiza un programa en donde el usuario capture los valores de las variables A, B, C, y a continuación se muestre el resultado del siguiente calculo:

//A=20  ,  B=10  , C=15   Resultado =115        A+B-C+100

let A=20
let B=10
let C=15

console.log(A+B-C+100)

//Ahora en este mismo mini proyecto practiquemos algo de algebra

//Ejercicio    Tengo   10x-20= 110  lo dividiermos en parte   A2=10x  B2=20  C2=-110(Se pone menos 110 porque se pasa del otro lado), Aqui convertimos x en otra variable la llamaremos D2

let  D2
let A2=10*D2

let B2=-20
let C2=-110

//Lo siguiente seria despejar D2 de A2 para eso tenemos que saber cuanto es D2 por tanto realizamos primeros  las variables que ya tienen valores
let B2C2=B2+C2

console.log(B2C2)
//En la formula tenermos 10x-20-110 => 10x-130  Para despejar x=D2 tenemos que mover x del otro lado por tanto  10x=130 => x= 130/10 => x =13 por tanto
D2=13
A2=10*D2
//Comprobamos

console.log(A2+B2)//y el resultado nos da lo siguiente 110 por lo tanto nuestra operacion es correcta






//Realiza un programa en donde el usuario capture un número,  el programa tendrá que indicar si el numero capturado es positivo, negativo o nulo.

let numero

//Esta operacion se puede hacer de dos maneras sumamente faciles. Solucion mas comun

if(numero>0) console.log("El numero es positivo") 
if (numero<0)console.log("El numero es negativo")
if (numero==null) console.log("El numero es nulo")

//aqui en efecto el valor como no tiene asignado el valor, se identifica como nulo
numero=20
console.log(numero)
if(numero>0) console.log("El numero es positivo")
if (numero<0)console.log("El numero es negativo")
if (numero==null) console.log("El numero es nulo")
//y si cambiamos
numero=-20
console.log(numero)
if(numero>0) console.log("El numero es positivo")
if (numero<0)console.log("El numero es negativo")
if (numero==null) console.log("El numero es nulo")

//o tambien

numero=null
if(numero<0) console.log("El numero es negativo")
else{
if (numero>0) {
    console.log("El numero es positivo")
} else console.log("El numero es nulo")}

//aunque si se dan cuenta los if y else suelen ser sumamente versatiles en este tipo de movimientos hay maneras de evitar esto como poner valores limitar la libertad al usuario 
//o usando un switch aunque no son tan buenas para estas cuestiones
//asi que una manera de simplificar esto es haciendo lo siguiente
let numero2=80

const respuesta= numero2>0?("El numero es positivo"):numero2<0?("El numero es negativo"):("El numero es nulo")
    console.log(respuesta)

    //o mas simplificado en una linea
    const respuesta2= numero2>0?console.log("El numero es positivo"):numero2<0?console.log("El numero es negativo"):console.log("El numero es nulo")//Ha estos se le llama operadores ternarios




    //Realiza un programa en donde se capturen tres números, el programa deberá indicar cuál es el menor de los tres números capturados
    //este puede parecer facil y puede serlo siempre y cuando se sepa como hacerlo

    let A3=20
    let B3=2
    let C3=2
    let con=false

    if(A3<B3) if(A3<C3) {console.log(A3+ " es el menor") 
    con=true}
    if (B3<A3) if(B3<C3) {console.log(B3+ " es el menor")
    con=true}
    if (C3<A3) if(C3<B3) {console.log(C3+ " es el menor")
    con=true}

    if(con==false){
    if(A3==B3&&B3==C3) console.log("Empate")
    if(A3==B3&&B3!=C3) console.log("Empate")
    if(A3==C3&&A3!=B3) console.log("Empate")
    if(B3==C3&&B3!=A3) console.log("Empate")}

    //como se puede ver esta es una manera en la que se puede emplear este inconveniente
        let numeroMenor
        let num

    function NumMenor(a,b,c){
        

        if(a<=b) if(a<=c) return a
        else return NumMenor(c,b,a)
        else return NumMenor(b,a,c)

    }

    function IdentificarNumMenor(id, a,b,c){
        let num=""
        if (id==a) num+="A3 "
        if (id==b) num+="B3 "
        if (id==c) num+="C3 "

        
        return num
    }


    numeroMenor=NumMenor(A3,B3,C3)//Otra manera es utilizando la funcion recursiva. Ordenandolo de la manera que nos agrade hara que esta se posiciones segun nuestras instrucciones

    num=(IdentificarNumMenor(numeroMenor,A3,B3,C3))
    console.log(num+" tiene el numero menor: "+numeroMenor)
    //alert(num+" tiene el numero menor: "+numeroMenor)

    //Se pueden recrear formulas para que inmediatamente se pueda obtener su valor

    //Convertir grados centigrados en Farenheit
    //Grados Farenheit=  ((Grados centigrados*9)/5)+32

    let GradosC=100

    let ConvertidosF= ((GradosC*9)/5)+32

    console.log(GradosC +" grados Centigrados en Farenheit son "+ConvertidosF)

    //Desarrolla un programa que permita hacer conversiones de unidades de longitud, específicamente convertir metros a pulgadas o pies. 
    //Se le pedirá al usuario capturar la cantidad de metros y posteriormente el usuario podrá elegir si desea convertir a pulgadas o convertir a pies. 
    //1 metro =  39.37 pulgadas 1 metro =  3.281 pies

    let metros=20
    let desicion=false
    const pulgadas=  39.37 //1 metro
    let  pies=3.281//1 metro



    let resultado= desicion?metros*pulgadas:metros*pies

    console.log(resultado)

    /*Realiza  un  programa  en  donde  se  le  pidan  al  usuario  dos  números  para  especificar  un  rango,    el  programa  deberá imprimir  secuencias  
    ascendentes  de  números  de  acuerdo  a  los  ejemplos  mostrados  y  debe  verificar  que  el  primer número  capturado  sea  menor  o  igual  que  el  
    segundo  número  capturado,  si  esto  no  sucede,  indicarlo  mediante  un mensaje y terminar el programa.

    */

    function Impresion(Min,Max,c){
       
        

        let i,j
        for (i=Min;i<=Max ;i++) {
            for(j=Min;j<=i;j++){
                c+=(j+" ")
            }
            c+=("\n")
        }

      
        

        return c
    }

    let RanMn=15
    let RanMx=19
    let acum=""

    if (RanMx>=RanMn) {acum =Impresion(RanMn,RanMx,acum)
    console.log(acum)
    }
    else console.log("ERROR: El rango menor es mayor")











