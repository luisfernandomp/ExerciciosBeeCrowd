#include <iostream>

using namespace std;
int main() {
    int n = 0, q = 0, qatual = 0, qanterior = 0, atual = 0, prox = 0;

    while(cin >> n){
        int M[n];

        for(int i = 0; i < n; i++){
            
            cin >> M[i];
            cout << M[i] << " " << flush;
        }
        cout << endl;
        
        for(int i = 0; i < n; i++)
        {
            atual = M[i];
            
            if(i < n) 
                prox = M[i+1];
            
            qatual++;

            if(qatual > qanterior){
                q = qatual;
            }else if (qatual < qanterior){
                q = qanterior;
            }

            if(atual != prox){
                if(qatual > qanterior) 
                    qanterior = qatual;

                qatual = 0;
            }
        }

        cout << q << endl;

    }   

    return 0;
}