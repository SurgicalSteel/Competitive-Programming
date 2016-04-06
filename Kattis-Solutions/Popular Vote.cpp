#include <bits/stdc++.h>
#include <algorithm>
#define pb push_back
#define mae max_element
using namespace std;

int main() {
    int tc;
    cin>>tc;
    for(int i=0;i<tc;i++)
    {
        int nc,tmpv;
        cin>>nc;
        vector<int> vt,vn;
        for(int j=0;j<nc;j++)
        {cin>>tmpv;vt.pb(tmpv);vn.pb(tmpv);}
        sort(vt.begin(),vt.end());
        if(vt[vt.size()-1]==vt[vt.size()-2]){cout<<"no winner\n";}
        else
        {
            vector<int>::iterator iter=vn.begin();
            iter=find(vn.begin(),vn.end(),vt[vt.size()-1]);
            int sums=0;
            for(int j=0;j<vt.size()-1;j++)
            {sums+=vt[j];}
            if(sums<vt[vt.size()-1])
            {cout<<"majority winner "<<distance(vn.begin(),iter)+1<<"\n";}
            else
            {cout<<"minority winner "<<distance(vn.begin(),iter)+1<<"\n";}
        }
    }
    return 0;
}
