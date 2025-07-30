//intento de calculadora//

let dato = Number(prompt("ingresa un numero:"));
console.log("has ingresado:",dato);
let dato2 = Number(prompt("ingresa otro numero:"));
console.log("has ingresado:", dato2);
let operacion = prompt("sumar, restar, multiplicar, dividir, sacar modulo, calcular raiz, exponenciacion");
console.log("eliges:", operacion)

switch(operacion){
    case "sumar":
        let suma = dato + dato2;
        console.log(`sumar: ${suma}`)
        break
    case "restar":
        let resta = dato - dato2
        console.log(`restar: ${resta}`)
        break
    case "multiplicar":
        let multiplicacion = dato * dato2;
        console.log(`multiplicar: ${multiplicacion}`)
        break
    case "dividir":
        let division = dato / dato2;
        console.log(`dividir: ${division}`)
        break
    case "sacar modulo":
        let modulo = dato % dato2;
        console.log(`sacar modulo: ${modulo}`)
        break
     case "exponenciacion":
        let exponenciacion = dato ** dato2;
        console.log(`expnenciacion: ${exponenciacion}`)
        break
    case "calcular raiz":
        let 
    
}



