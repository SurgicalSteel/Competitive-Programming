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
    int n,sum;
    string st,each;
    cin>>n;
    for(int i=0;i<n;i++){
        cin>>st;
        if (st=="P=NP"){
            cout<<"skipped\n";
        }else{
            sum=0;
            each="";
            for(int j=0;j<=st.length();j++){
                if(st.substr(j,1)=="+" || j==st.length()){
                    sum+=toint(each);
                    each="";
                }else{
                    each = each + st.substr(j,1);
                }
            }
            cout<<sum<<"\n";
        }
    }
    return 0;
}
