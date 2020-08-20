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
    int n;
    cin>>n;
    float total=0 , qt , ql;
    for(int i=0;i<n;i++){
        cin>>ql>>qt;
        total = total + (ql*qt);
    }
    cout<<total<<"\n";
    return 0;
}
