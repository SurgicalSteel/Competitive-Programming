#include <bits/stdc++.h>
#define psb push_back
using namespace std;
int main() {
    int a,b,c;
    vector<int> v;
    cin>>a>>b>>c;
    v.psb(a);
    v.psb(b);
    v.psb(c);
    sort(v.begin(),v.end());
    if(abs(v[0]-v[1])>abs(v[1]-v[2]))
    {
        cout<<v[0]+abs(v[1]-v[2])<<"\n";
    }
    else if (abs(v[0]-v[1])<abs(v[1]-v[2]))
    {
        cout<<v[1]+abs(v[0]-v[1])<<"\n";
    }
    else{cout<<v[2]+abs(v[1]-v[2])<<"\n";}
    return 0;
}
