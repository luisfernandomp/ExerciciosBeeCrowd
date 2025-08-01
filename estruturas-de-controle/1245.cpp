#include <iostream>
#include <string>
#include <sstream>
#include <vector>

using namespace std;
int main() {
    int pares = 0, i = 0, j = 0, total = 0, direito = 0, esquerdo = 0;
    string numero, lado;
    bool existe = false;

    while(cin >> pares){
        total = 0;

        vector<string> numeros;
        vector<vector<string>> sapatos(pares, vector<string>(2));
        
        for(i = 0; i < pares; i++){
            existe = false;
            cin >> sapatos[i][0] >> sapatos[i][1];

            for(string n : numeros){
                if(n == sapatos[i][0]){
                    existe = true;
                    break;
                }
            }

            if(!existe){
                numeros.push_back(sapatos[i][0]);
            }
        }

        for(i = 0; i < numeros.size(); i++){
            direito = 0;
            esquerdo = 0;

            for(j = 0; j < pares; j++){
                if(numeros[i] == sapatos[j][0]){
                    if(sapatos[j][1] == "D"){
                        direito++;
                    }
                    else {
                        esquerdo++;
                    }
                }
            }

            if(direito > esquerdo){
                total += esquerdo;
            }
            else if(direito < esquerdo){
                total += direito;
            }else{
                total += (esquerdo + direito)/2;
            }
        }

        cout << total << endl;
    }   

    return 0;
}
