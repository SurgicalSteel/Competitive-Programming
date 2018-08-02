#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007

int toint(string x) {
    istringstream ss(x);
    int a;
    ss>>a;
    return a;
}

string tostr(int x) {
    ostringstream ss;
    ss << x;
    return ss.str();
}

void precalc() {

}

void gcji(int caseorder, int res) {
    printf("Case #%d: %d\n", caseorder, res);
}

void gcjs(int caseorder, string res) {
    cout << "Case #" << caseorder << ": " << res << "\n";
}

void gcjf(int caseorder, float res) {
    printf("Case #%d: %.15f\n", caseorder, res);
}

int main() {
    // your code goes here
    int limit,nevents,nreject=0;
    int curr=0,statc;
    cin>>limit>>nevents;
    string stat;
    for(int i=0;i<nevents*2;i++){
        if(i%2==0){
            cin>>stat;
        }else{
            cin>>statc;
            if (stat == "leave"){
                curr-=statc;
            }else{
                if(curr+statc>limit){
                    nreject++;
                }else{
                    curr+=statc;
                }
            }
        }
    }
    cout<<nreject<<"\n";
    return 0;
}
