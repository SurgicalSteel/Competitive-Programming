#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
int main() {
    // your code goes here
    float D,V;
    cin>>D>>V;
    while(D!=0&&V!=0)
    {
        float res=pow((6*((PI*pow(D,3)/4)-V)/PI)-(pow(D,3)/2),1.0/3);
        printf("%.10f\n",res);
        cin>>D>>V;  
    }
    return 0;
}
