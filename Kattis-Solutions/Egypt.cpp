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
void precalc(){

}
void gcji(int caseorder,int res){
    printf("Case #%d: %d\n",caseorder,res);
}
void gcjs(int caseorder,string res){
    cout<<"Case #"<<caseorder<<": "<<res<<"\n";
}
void gcjf(int caseorder,float res){
    printf("Case #%d: %.15f\n",caseorder,res);
}
bool check(int a, int b, int c){
    return (((a*a)+(b*b))==(c*c)); 
}
bool testall(int a,int b, int c){
    bool tc = check(a,b,c);
    bool tb = check(a,c,b);
    bool ta = check(c,b,a);
    return (ta||tb||tc);
}
int main() {
    // your code goes here
    int a,b,c;
    cin>>a>>b>>c;
    while(a>0&&b>0&&c>0){
        if (testall(a,b,c)){
            cout<<"right\n";
        }else{
            cout<<"wrong\n";
        }
        cin>>a>>b>>c;
    }
    return 0;
}
