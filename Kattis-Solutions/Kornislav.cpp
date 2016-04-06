#include <bits/stdc++.h>
#include <algorithm>
#define pb push_back
using namespace std;

int main() {
    int temp;
    vector<int> v;
    for(int i=0;i<4;i++)
    {cin>>temp;v.pb(temp);}
    sort(v.begin(),v.end());
    cout<<v[0]*v[2]<<"\n";
    return 0;
}
