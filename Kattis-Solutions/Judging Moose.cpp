#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007

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
    int x,y;
    cin>>x>>y;
    if(x==y){
        if(x==0){
            cout<<"Not a moose\n";
        }else{
            cout<<"Even "<<x*2<<"\n";
        }
    }else{
        cout<<"Odd "<<max(x,y)*2<<"\n";
    }
    return 0;
}
