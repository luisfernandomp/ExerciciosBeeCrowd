#include <iostream>
#include <iomanip>

using namespace std;
int main() {
    int coluna = 0;
    char operacao;
    float total = 0.0f;

    while(cin >> coluna){
        cin >> operacao;

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