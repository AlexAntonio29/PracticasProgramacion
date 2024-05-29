/*
 * Escribe un programa que muestre cómo transcurre un juego de tenis y quién lo ha ganado.
 * El programa recibirá una secuencia formada por "P1" (Player 1) o "P2" (Player 2), según quien
 * gane cada punto del juego.
 * 
 * - Las puntuaciones de un juego son "Love" (cero), 15, 30, 40, "Deuce" (empate), ventaja.
 * - Ante la secuencia [P1, P1, P2, P2, P1, P2, P1, P1], el programa mostraría lo siguiente:
 *   15 - Love
 *   30 - Love
 *   30 - 15
 *   30 - 30
 *   40 - 30
 *   Deuce
 *   Ventaja P1
 *   Ha ganado el P1
 * - Si quieres, puedes controlar errores en la entrada de datos.   
 * - Consulta las reglas del juego si tienes dudas sobre el sistema de puntos.   
 */


let P1
let P2


class jugador{
    constructor(name, punto){
        this.name=name
        this.punto=punto
    }
}

function sumaPuntos(jugador,punto) {

    if(punto==0||punto==15){ punto=15
        
    }
    if(punto==30) {punto=10
    
    }
    if (punto==40) {console.log("Ventaja para "+jugador) 
    punto++}
    if(punto>40) console.log("Ha ganado "+jugador)
    return punto
    
}

p1=new jugador("jugador 1", 0)
p2=new jugador("jugador 2", 0)
let seleccion=Math.floor(Math.random()* 2-1+1)+1



while(p1.punto< 41 && p2.punto<41){
    seleccion=Math.floor(Math.random()* 2-1+1)+1
   
    if(p1==40&&p2==40) console.log("Deuce")


    if (seleccion==1) p1.punto+=sumaPuntos(p1.name, p1.punto) 
    else p2.punto+=sumaPuntos(p2.name, p2.punto) 
    if (p1.punto==0 || p2.punto==0)  if (p1.punto==0) console.log(p1.name+":love   "+p2.name+":"+p2.punto) 
    else console.log(p1.name+":"+p1.punto+"   "+p2.name+": love")
if (p1.punto< 41 && p2.punto<41 && p1.punto!=0&&p2.punto!=0) console.log(p1.name+":"+p1.punto+"   "+p2.name+":"+p2.punto)


}





