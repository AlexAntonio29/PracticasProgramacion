
/*
 * Escribe un programa que, dado un número, compruebe y muestre si es primo, fibonacci y par.
 * Ejemplos:
 * - Con el número 2, nos dirá: "2 es primo, fibonacci y es par"
 * - Con el número 7, nos dirá: "7 es primo, no es fibonacci y es impar"
 */

function fibonacci(number){

    let sum=1
    let i=1
    let value=false

    while (sum<=number) {
       
        console.log(sum)
        i=sum-i
        sum+=i
        if (sum==number) value=true
        
    }
    return value

}


function par(number){
    return number%2? false:true
}

function primo(number){
    let acum=0
let i

for(i=number;i>0;i--){
   
    

    if(number%i==0){ acum++}//Detecta si el modulo de el numero con los numero del rango de 0 a el numero den 0
}
    if (acum==2) return true//si son dos ceros son numeros primos ya que un numero primo solo puede dividirse entre el y el 1
    else return false//de lo contrario manda falso
}

function num(number,acum){

if(number.get("Fibonacci")) acum+=" es un numero Fibonacci, "
else acum+= " no es un numero fibonacci, "
if(number.get("par")) acum+=" es un numero par, "
else acum+= " no es un numero par, "
if(number.get("primo")) acum+=" es un numero primo. "
else acum+= " no es un numero primo. "

return acum


}


let number=prompt("Introduce el valor de un numero para saber si es par, fibonacci o primo","")
let numero=new Map([["Fibonacci",fibonacci(number)],["par",par(number)],["primo",primo(number)]])//El new map es una de las nuevas caracteristicas de es6 para facili

let request = num(numero,"")

console.log(number+request)
alert(number+request)



