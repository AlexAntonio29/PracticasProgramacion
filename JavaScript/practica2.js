/**
 
Desarrollar un programa  que calcule el rendimiento de gasolina de un automóvil, 
pidiéndole al usuario los siguientes datos: 
Introduce los kilómetros recorridos con el primer tanque: 
Introduce los litros consumidos en el primer tanque: 
Introduce los kilómetros recorridos con el segundo tanque: 
Introduce los litros consumidos en el segundo tanque: 
Introduce los kilómetros recorridos con el tercer tanque: 
Introduce los litros consumidos en el tercer tanque:
 El programa debe calcular y mostrar el rendimiento  en kilómetros por litro de cada tanque, este calculo se hace dividiendo los kilómetros entre los litros. 
 */

 function selec_valor_auto(){
    let sum=1
    let gasolina
    let kms
    let autos= new auto(0,0)


    while(sum<=3){
        kms=prompt("cuantos litros de gasolina consumio el auto "+sum,"");
        gasolina=prompt("Cuantos kilometros recorrio el auto","")
        autos.gas=gasolina
        autos.km=kms
        autos.num=sum

        autos.rend()

        sum++
    }
 }

 class auto{

    constructor(gas,km,num){
            this.gas=gas
            this.km=km
            this.num=num
        
    }
    rend(gas,km,num){
        //return (this.km/this.gas)
        //console.log("El rendimiento del auto "+this.num+" es "+(this.km/this.gas))
        alert("El rendimiento del auto "+this.num+" es "+(this.km/this.gas))


    }
 }


 selec_valor_auto()





