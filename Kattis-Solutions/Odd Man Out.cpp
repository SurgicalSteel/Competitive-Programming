#include <bits/stdc++.h>
#include <algorithm>
#define pb push_back
using namespace std;

int main() {
    int tc,sz,temp;
    cin>>tc;
    for(int i=0;i<tc;i++)
    {
        cin>>sz;
        vector<int> v;
        for(int j=0;j<sz;j++)
        {
            cin>>temp;
            v.pb(temp);
        }
        sort(v.begin(),v.end());
        bool found=false;
        int j=0;
        while(j<=sz-1&&!found)
        {
            if(j==0&&v[j]!=v[j+1])
            {cout<<"Case #"<<i+1<<": "<<v[j]<<"\n";found=true;}
            else if(j>0&&j<sz-2&&v[j-1]!=v[j]&&v[j]!=v[j+1])
            {cout<<"Case #"<<i+1<<": "<<v[j]<<"\n";found=true;}
            else if(j==sz-1&&v[j]!=v[j-1]){cout<<"Case #"<<i+1<<": "<<v[j]<<"\n";found=true;}
            j++;
        }
    }
    return 0;
}
