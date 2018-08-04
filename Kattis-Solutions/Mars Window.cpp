#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
int months[95796];

void precalc(){
    memset(months,0,sizeof(months));
    int curr=3;
    for(int i=curr;i<95796;i+=26){
        months[i]++;
    }
}
bool getposs(int idx){
    for(int i=idx;i<min((idx+12),95796);i++){
        if(months[i]>0){
            return true;
        }
    }
    return false;
}
int getidx(int y){
    return (y-2018)*12;
}
int main() {
    // your code goes here
    precalc();
    int y;
    cin>>y;
    if(getposs(getidx(y))){
        cout<<"yes\n";
    }else{
        cout<<"no\n";
    }
    return 0;
}
