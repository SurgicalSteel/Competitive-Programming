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
bool compare(int x, int y){return x>y;}
int main() {
    // your code goes here
    int tc,tmp,tot=0;
    scanf("%d",&tc);
    vector<int> v;
    for(int i=0;i<tc;i++){
        scanf("%d",&tmp);
        v.psb(tmp);
    }
    sort(v.begin(),v.end(),compare);
    for(int i=0;i<tc;i++){
        if(i%3==0||i%3==1){tot+=v[i];}
    }
    printf("%d\n",tot);
    return 0;
}
