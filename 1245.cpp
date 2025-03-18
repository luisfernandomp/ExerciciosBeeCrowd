#include <iostream>
#include <iomanip>
#include <string>
#include <sstream>
#include <vector>

using namespace std;
int main() {
    int pares = 0, i = 0, total = 0;
    string linha;

    while(cin >> pares){

        vector<vector<string>> M(pares, vector<string>(2));

        for(i = 0; i < pares; i++){
            getline(cin, linha);
            istringstream stream(linha);
            stream >> M[i][0] >> M[i][1];
        }
         

        float matriz[12][12];

        for(int i = 0; i < 12; i++){
            for(int j = 0; j < 12; j++){
                cin >> matriz[i][j];
            }
        }

        for(int i = 0; i < 12; i++){
            total += matriz[i][coluna];
        }

        if(operacao == 'M'){
            total /= 12.0;
        }

        cout << fixed << setprecision(1) << total << endl;
    }   

    return 0;
}