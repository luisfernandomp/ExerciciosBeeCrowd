#include <string>
#include <iostream>
#include <sstream>
#include <iomanip>
#include <cmath>

using namespace std;

int main() {
    string linha;

    double a = 0.0, b = 0.0, c = 0.0;
    string mensagem = "";

    while (getline(cin, linha)) {
        istringstream stream(linha);
        stream >> a >> b >> c;

        if(a < b) swap(a, b);
        if(a < c) swap(a, c);
        if(b < c) swap(c, b);

        if (a >= (b + c)){
            mensagem = "NAO FORMA TRIANGULO";
            cout << mensagem << endl;
        }
        else{
            if(pow(a,2) == (pow(b,2) + pow(c,2))){
                mensagem = "TRIANGULO RETANGULO";
            } 
           else {
                if(pow(a,2) > (pow(b,2) + pow(c,2))){ 
                    mensagem = "TRIANGULO OBTUSANGULO";
                }
                else if(pow(a,2) < (pow(b,2) + pow(c,2))){ 
                    mensagem = "TRIANGULO ACUTANGULO";
                }

                if(a == b && b == c){ 
                    mensagem.append("\nTRIANGULO EQUILATERO");
                }
                else if((a == b && b != c) || (a == c && c != b) || (c == b && b != a)){  
                    mensagem.append("\nTRIANGULO ISOSCELES");
                }
           }

           cout << mensagem << endl;
        }
    }
    return 0;
}