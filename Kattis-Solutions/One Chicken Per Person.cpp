#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
int toInt(string x)
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
    int nc,np;
    cin>>np>>nc;
    if (nc>np){
        if (abs(nc-np)>1){
            printf("Dr. Chaz will have %d pieces of chicken left over!\n",abs(nc-np));    
        }else{
            printf("Dr. Chaz will have %d piece of chicken left over!\n",abs(nc-np));
        }
    }else{
        if (abs(nc-np)>1){
            printf("Dr. Chaz needs %d more pieces of chicken!\n",abs(nc-np));
        }else{
            printf("Dr. Chaz needs %d more piece of chicken!\n",abs(nc-np));
        }
    }
    return 0;
} 
