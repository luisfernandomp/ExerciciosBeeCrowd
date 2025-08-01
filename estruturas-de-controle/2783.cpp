#include <iostream>
#include <vector>

using namespace std;
int main() {
    int nFigurinhas = 0,
        nFigurinhasCarimbadas = 0,
        nFigurinhasCompradas = 0,
        q = 0;
    
    bool encontrado = false;

    int valor = 0;
    while(cin >> nFigurinhas >> nFigurinhasCarimbadas >> nFigurinhasCompradas){
        
        vector<int> figurinhasCarimbadas(nFigurinhasCarimbadas);
        vector<int> figurinhasCompradas(nFigurinhasCompradas);

        for(int i = 0; i < nFigurinhasCarimbadas; i++){
            encontrado = false;
            cin >> valor;

            for(int v:figurinhasCarimbadas){
                if(valor == v){
                    encontrado = true;
                    break;
                }
            }

            if(!encontrado)
                figurinhasCarimbadas[i] = valor;
        }

        

        for(int i = 0; i < nFigurinhasCompradas; i++){
            encontrado = false;
            cin >> valor;

            for(int v:figurinhasCompradas){
                if(valor == v){
                    encontrado = true;
                    break;
                }
            }

            if(!encontrado)
            figurinhasCompradas[i] = valor;
        }

        for(int i = 0; i < nFigurinhasCarimbadas; i++){
            for(int j = 0; j < nFigurinhasCompradas; j++){
                if(figurinhasCarimbadas[i] == figurinhasCompradas[j]){
                    q++;
                    break;
                }
            }
        }

        cout << nFigurinhasCarimbadas - q << endl;
    }   

    return 0;
}