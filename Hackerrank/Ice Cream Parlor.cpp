#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
int main() {
    int tc,m,n,temp;
    scanf("%d",&tc);
    for(int i=0;i<tc;i++)
    {
        vector<int> v;
        cin>>m>>n;
        for(int x=0;x<n;x++)
        {
            cin>>temp;
            v.push_back(temp);
        }
        for(int x=0;x<v.size();x++)
        {
            for(int y=x+1;y<v.size();y++)
            {
                if(v[x]+v[y]==m)
                printf("%d %d\n",x+1,y+1);
            }
        }
    }
    return 0;
}
