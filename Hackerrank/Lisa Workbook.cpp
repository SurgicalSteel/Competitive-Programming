#include <bits/stdc++.h>
using namespace std;
#define psb push_back
int main() {
    int nchap,maxprob,temp;
    scanf("%d %d",&nchap,&maxprob);
    int npage=1,counter,last,nres=0;
    for(int i=0;i<nchap;++i)
    {
        scanf("%d",&temp);
        vector<int> vi;
        for(int a=0;a<temp;++a){vi.psb(a+1);}
        last=0;
        int x=0;
        while(x<vi.size())
        {
            while(x<min(last+maxprob,(int)(vi.size())))
            {
                if(x==vi.size()){break;}
                else
                {
                    if(vi[x]==npage){nres++;}
                    x++;
                }
            }
            npage++;
            last+=maxprob;
        }
    }
    printf("%d\n",nres);
    return 0;
}
