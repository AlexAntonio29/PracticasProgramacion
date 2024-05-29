//Practica 7 crear un programa que me diga si un numero es primo o no


function NumeroPrimo(n,dis){
/*
  if (dis==0||n%dis==0&&dis!=1){  Este es una manera de poder darle recursion a un valor para que nos de los numeros primos
   return dis}
  else
  {
    
  return NumeroPrimo(n,dis-1)}




*/
return dis==0||n%dis==0&&dis!=1? dis :NumeroPrimo(n,dis-1) //Este es la manera simplificada de hacerlo a traves de los retornos ternarios



}

function recursividad(RangoMin,RangoMax,acum){

    
    RangoMin++
   
const acumulador=RangoMin%2&&RangoMin%5!=1? (RangoMin+", "):("")

acum+=acumulador



return RangoMax==RangoMin ? acum :recursividad(RangoMin,RangoMax,acum)
}





let nPrimo=1
let acum=""
while(nPrimo<100){
nPrimo++
if((NumeroPrimo(nPrimo,nPrimo-1))==0){
    acum+=(nPrimo+" ")
}



}

console.log(acum)



//Hare otra practica que contenga numeros primos pero usando otros metodos sin recursion



let NPrimo_n=1
let i,j;
let sumador=0
let acumulador=""
for(i=2; i<=100;i++){
    sumador=0
    for(j=i;j>1;j--){
            if(i%j==0){

                sumador++


            }
            
            
    }
    if (sumador==1) acumulador+=(i+" ")
    
}

console.log(acumulador)//En esta practica utilice el bucle for para que en un for se genere otro for para asi poder tener encontrar los recursivos




