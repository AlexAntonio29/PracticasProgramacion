

/*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */

let m3 //fizz
let m5 //buzz
let m35 //fizzbuzz

let acum=""
let sum=0

let palabra

for (let index = 1; index<=100; index++) {
    palabra=""
    sum=0

    if(index%3==0){palabra="fizz" 
        sum++}
    if(index%5==0){palabra="buzz"
    sum=2}
        if(sum==1&&index%5==0) palabra+="buzz"
        if(sum==2&&index%3==0)palabra="fizz"+palabra
        if(sum==0) palabra=index

    acum+=palabra
    acum+=("\n")
    
}

console.log(acum)
