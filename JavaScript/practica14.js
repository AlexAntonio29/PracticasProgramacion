/*
 * Crea un programa que calcule quien gana más partidas al piedra,
 * papel, tijera, lagarto, spock.
 * - El resultado puede ser: "Player 1", "Player 2", "Tie" (empate)
 * - La función recibe un listado que contiene pares, representando cada jugada.
 * - El par puede contener combinaciones de "🗿" (piedra), "📄" (papel),
 *   "✂️" (tijera), "🦎" (lagarto) o "🖖" (spock).
 * - Ejemplo. Entrada: [("🗿","✂️"), ("✂️","🗿"), ("📄","✂️")]. Resultado: "Player 2".
 * - Debes buscar información sobre cómo se juega con estas 5 posibilidades.
 */
function reglas(player1,player2){//Aqui se deben de cumplir las reglas de dicho juego entre dos jugadores

console.log("Confrontacion:\nJugador1:"+player1.ataq+" VS "+"Jugador2:"+player2.ataq)

if(player1.ataq==player2.ataq) {
    console.log("Empate")
    return 3}

    


if(player1.deb1==player2.ataq||player1.deb2==player2.ataq){
    
    console.log("El jugador 1 pierde un punto")
    return 0//regresa 1 para jugador 1
}

if(player2.deb1==player1.ataq || player2.deb2==player1.ataq){
    
    console.log("El jugador 2 pierde un punto")
    return 1//regresa 2 para jugador 2
}

   
      


}

class player{//Esta clase es especificamente para obtener datos de un jugador 

    constructor(vida,ataq,deb1,deb2){
        this.deb1=deb1
        this.deb2= deb2
        this.vida=vida
        this.ataq=ataq
        
        this.ataq=this.ataque
        //console.log(this.ataq)

       this.deb1=this.debilidad1(this.ataq)
       //console.log(this.deb1)
       this.deb2= this.debilidad2(this.ataq)
      // console.log(this.deb2)

    }

    set vidaPlayer(atq){

         this.vida-atq

    }

   get ataque(){

    let atq=Math.floor(Math.random()*5-1+1)+1
    
    switch(atq){
            
            case 1:
            return "piedra"
            break
            case 2:
            return "papel"
            break
            case 3:
            return "tijera"
            break
            case 4:
            return "lagarto"
            break
            case 5:
            return "spock"
            break
            default:
                return "piedra"
    }

    
   }

    debilidad1(deb1){
    //this.deb1= deb1
       
    switch(deb1){
        case "piedra":
            return "papel"
            break
            case "papel":
                return "tijera"
            break
            case "tijera":
                return "spock"
            break
            case "lagarto":
                return "piedra"
            break
            case "spock":
                return "lagarto"
            break
    }
   }

   debilidad2(deb2){
   
//console.log(deb2)
    switch(deb2){
        case "piedra":
            return "spock"
            break
            case "papel":
            return "lagarto"
            break
            case "tijera":
            return "piedra"
            break
            case "lagarto":
                return "tijera"
            
            break
            case "spock":
            return "papel" 
            break
    }
   } 


}

let jugador1=new player(2)
let jugador2=new player(2) 

//jugador1.ataq=jugador1.ataque


/*

console.log(jugador1.vida) 
console.log(jugador1.ataq)
console.log(jugador1.deb1)
console.log(jugador1.deb2) 
      

console.log(jugador2.vida) 
console.log(jugador2.ataq)
console.log(jugador2.deb1)
console.log(jugador2.deb2) */

let condicion=3
let vidap1=jugador1.vida
let vidap2=jugador2.vida
while(vidap1!=0&&vidap2!=0){

    condicion=reglas(jugador1,jugador2)
    
   
      
    if (condicion==1) vidap2--
        else if(condicion==0) vidap1--
       
       
          
        jugador2=new player(vidap2)
        jugador1=new player(vidap1)
  

} 

if(jugador1.vida!=0) console.log("Jugador 1 ha ganado")
else console.log("Jugador 2 ha ganado")
 

        


 