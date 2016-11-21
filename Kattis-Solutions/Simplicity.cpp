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
    string s;
    cin>>s;
    vector<string> c;
    vector<int> n;
    vector<string>::iterator it;
    for(int i=0;i<s.length();i++)
    {
        it=c.begin();
        it=find(all(c),s.substr(i,1));
        if(it==c.end())
        {n.psb(1);c.psb(s.substr(i,1));}
        else{n[distance(c.begin(),it)]++;}
    }
    if(n.size()<=2){cout<<"0\n";}
    else
    {
        sort(all(n));
        int sum=0;
        for(int i=0;i<n.size()-2;i++){sum+=n[i];}
        cout<<sum<<"\n";
    }
    return 0;
}
