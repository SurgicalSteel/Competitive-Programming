#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007

int main() {
    // your code goes here
    int sw,so;
    bool breaker=false;
    while(!breaker){
        cin>>sw>>so;
        if(sw==0 && so == 0){
            breaker = true;
        }else{
            if(sw+so==13){
                cout<<"Never speak again.\n";
            }else if(sw>so){
                cout<<"To the convention.\n";
            }else if(sw<so){
                cout<<"Left beehind.\n";
            }else if(sw==so){
                cout<<"Undecided.\n";
            }
        }
    }
    return 0;
}
