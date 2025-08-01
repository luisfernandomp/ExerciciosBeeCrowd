#include <string>
#include <iostream>
#include <sstream>
#include <iomanip>
#include <cmath>

using namespace std;

int main() {
    int n = 0, x = 0, j = 0;
    bool primo = false;

    while (cin >> n) {
        while(n--){

            primo = true;

            cin >> x;
            if( x > 1 ){
                for(j = x - 1; j > 1; j--) {
                    if(x % j == 0){
                        primo = false;
                        break;
                    }
                }                
            }

        
            if (primo)
                cout << x << " eh primo" << endl;
            else 
                cout << x << " nao eh primo" << endl;

        }
    }
    return 0;
}