#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
typedef pair<int, int> pii;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
#define fff first
#define sss second

int main() {
    // your code goes here
    string s;
    cin>>s;
    bool hiss=false;
    for(int i=0;i<s.length()-1;i++){
        if(s.substr(i,2)=="ss"){
            hiss=true;
        }
    }
    if(hiss){
        cout<<"hiss\n";
    }else{
        cout<<"no hiss\n";
    }
    return 0;
}
