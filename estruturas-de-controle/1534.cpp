#include <iostream>

using namespace std;
int main() {
    int n = 0;

    while(cin >> n){
        float M[n][n];

        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if((i + j) == (n - 1)) cout << "2" << flush;
                else if(i == j) cout << "1" << flush;
                else cout << "3" << flush;
            }

            cout << endl;
        }
    }   

    return 0;
}