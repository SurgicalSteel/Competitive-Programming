#include <bits/stdc++.h>
#include <algorithm>
#define pub push_back
#define pob pop_back
using namespace std;
int main() {
    int sz,k,nq,q,temp;
    cin>>sz>>k>>nq;
    vector<int> v;
    for(int i=0;i<sz;i++)
    {
        scanf("%d",&temp);
        v.pub(temp);
    }
    for(int i=0;i<k%sz;i++)
    {
        temp=v[v.size()-1];
        v.pob();
        v.insert(v.begin(),temp);
    }
    for(int i=0;i<nq;i++)
    {
        cin>>q;
        cout<<v[q]<<"\n";
    }
    return 0;
}
