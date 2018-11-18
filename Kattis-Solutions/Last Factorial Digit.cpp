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

int findlast(int rem, int x){
    rem=rem%10;
    x=x%10;
    return x*rem;
}
int main() {
    // your code goes here
    int tc,n,rem=1;
    cin>>tc;
    while(tc--){
        cin>>n;
        rem=1;
        for(int i=1;i<=n;i++){
            rem = findlast(rem,i);
        }
        cout<<rem%10<<"\n";
    }
    return 0;
}
