#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
int toint(string x)
{
    istringstream ss(x);
    int a;
    ss>>a;
    return a;
}
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
int main() {
    // your code goes here
    int suma=0,sumb=0;
    char s[15000],sra[7500],srb[7500],src[7500];
    scanf("%s",&s);
    for(int i=0;i<(strlen(s)/2);i++){
        suma+=s[i];
    }
    for(int i=(strlen(s)/2);i<strlen(s);i++){
        sumb+=s[i];
    }
    for(int i=0;i<strlen(s);i++){
        if (i>=(strlen(s)/2)){
            srb[i-(strlen(s)/2)]=((s[i]+sumb)%26);
        }else{
            sra[i]=((s[i]+suma)%26);
        }
    }
    for(int i=0;i<(strlen(s)/2);i++){
        src[i]=(sra[i]+srb[i])%26;
        src[i]+='A';
    }
    for(int i=0;i<(strlen(s)/2);i++){
        sra[i]+='A';
        srb[i]+='A';
    }
    cout<<src<<"\n";
    return 0;
}
