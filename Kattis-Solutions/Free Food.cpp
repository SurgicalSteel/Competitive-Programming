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

int gcd(int a, int b) {
    return b == 0 ? a : gcd(b, a % b);
}

char toCharSingle(string x) {
    char a[1];
    strncpy(a, x.c_str(), sizeof (a));
    return a[0];
}

string toStringSingle(char x) {
    string c;
    stringstream ss;
    ss << x;
    ss>>c;
    return c;
}

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

int main() {
    // your code goes here
    int ev,ts,te,days[365];
    for(int i=0;i<365;i++){days[i]=0;}
    cin>>ev;
    for(int i=0;i<ev;i++){
        cin>>ts;
        cin>>te;
        for(int x=ts;x<=te;x++){
            days[x-1]++;
        }
    }
    int count=0;
    for(int i=0;i<365;i++){
        if(days[i]>0){
            count++;
        }
    }
    cout<<count<<"\n";
    return 0;
}
