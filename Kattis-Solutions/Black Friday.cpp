#include <bits/stdc++.h>
#include <algorithm>
#define pb push_back
using namespace std;

int main() {
    int tc,temp;
    cin>>tc;
    vector<int> vh,vd;
    for(int i=0;i<6;i++)
    {vh.pb(0);}
    for(int i=0;i<tc;i++)
    {
        cin>>temp;
        vd.pb(temp);
        vh[temp-1]++;
    }
    int i=5;
    bool found=false;
    while(i>=0&&!found)
    {
        if(vh[i]==1)
        {
            vector<int>::iterator iter=vd.begin();
            iter=find(vd.begin(),vd.end(),i+1);
            if(iter!=vd.end())
            {
                cout<<distance(vd.begin(),iter)+1<<"\n";
                found=true;
            }
        }
        i--;
    }
    if(!found){cout<<"none\n";}
    return 0;
} 
