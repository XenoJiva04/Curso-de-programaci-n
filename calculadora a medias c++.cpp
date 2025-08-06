#include <iostream>
#include <cmath>

int main () {
    int operacion;
    std::cout << "que quieres hacer:";
    std::cout <<" 1: suma 2: resta 3: multiplicacion 4: division 5: modulo";
    std::cin >> operacion;
    
    int numero1;
    std::cout << "introduce un primer numero";
    std::cin >> numero1;
    std::cout << "elegis" << numero1 << std::endl;
    
    int numero2;
    std::cout << "introduce un segundo numero";
    std::cin >> numero2;
    std::cout << "elegis" << numero2 << std::endl;
    

    int suma = numero1 + numero2; 
    int resta = numero1 - numero2; 
    int mult = numero1 * numero2; 
    int div = numero1 / numero2;  
    int resto = numero1 % numero2;
    
    switch (operacion) {
        case 1:
        std::cout << "resultado:" << numero1 + numero2 << std::endl;
        break;
        
        case 2:
        std:: cout << "resultado:" << numero1 - numero2 << std::endl;
        break;
        
        case 3:
        std::cout << "resultado:" << numero1 * numero2 << std::endl;
        break;
        
        case 4: 
        std::cout << "resultado:" << numero1 / numero2 << std::endl;
        break;
        
        case 5:
        std::cout << "resultado:" << numero1 % numero2 << std::endl;
        break;
        
        return 0;
    }
    
}