#include <string>
#include <iostream>
#include <sstream>
#include <iomanip>
#include <cmath>

using namespace std;

int main() {
    int n = 0, j = 0, x = 0, soma = 0;

    while (cin >> n) {
        while(n--){
            soma = 1;

            cin >> x;

            for(j = 2; j * j <= x; j++) {
                if(x % j == 0){
                    soma += j;

                    if(j != x/j){
                        soma += x/j;
                    }
                }
            }

            if (soma == x && x != 1)
                cout << x << " eh perfeito" << endl;
            else 
                cout << x << " nao eh perfeito" << endl;

        }
    }
    return 0;
}