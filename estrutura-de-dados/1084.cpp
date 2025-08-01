#include <stack>
#include <iostream>

using namespace std;
int main() {
    int qDigitos = 0, qApagados = 0, k = 0;
    string linha;

    while(cin >> qDigitos >> qApagados){
        
        if(qDigitos == 0 && qApagados == 0){
            return 0;
        }

        stack<char> premio;
        cin >> linha;
        cout << "-----" << linha << endl; 
        
        for(int i = qDigitos - 1; i >= 0; i--){

            if(premio.empty()){
                premio.push(linha[i]);
            }
            else{
                char digito = premio.top();

                if(linha[i] > digito){
                    premio.pop();
                    premio.push(linha[i]);
                }
                else {
                    premio.push(linha[i]);
                }
            }
        }

        if(premio.size() > (qDigitos - qApagados))
            premio.pop();

        cout << "Tamanho pilha: " << premio.size() << endl;

        while(!premio.empty()){
            cout <<  premio.top() << flush;
            premio.pop();
        }


        cout << endl;
    }   

    return 0;
}