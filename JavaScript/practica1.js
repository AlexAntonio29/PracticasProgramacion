
/*Codifica un programa en donde el usuario capture los valores de cuatro variables (a,b,c,d), 
si el valor de la variable aes diferente de 0, entonces se tendrá que calcular y mostrar el 
resultado de la siguiente formula:
           ((a+b)/2) (((cd)/a))+1

Pero si el valor de la variable a es igual a 0, entonces el programa tendrá que terminar. 


*/

function Eject_program(a,b,c,d){

    let p1=(a+b)/2
    let p2=(c*d)/a
    let p3=(p1*p2)+1

    console.log("El valor de la ecuacion ((a+b)/2) (((cd)/a))+1 es "+ p3)
}

let a,b,c,d;
a=1; b=3; c=6; d=5

if (a!=0 ) Eject_program(a, b,c,d)

else console.log("a no puede llevar 0")

