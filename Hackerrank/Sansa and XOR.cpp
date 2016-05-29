#include <bits/stdc++.h>
using namespace std;
#define psb push_back
int main() {
    int tc,sz,ptr;
    long long int temp,x;
    scanf("%d",&tc);
    while(tc--)
    {
        scanf("%d",&sz);
        vector<long long int> v;
        for(int i=0;i<sz;++i){scanf("%lld",&temp);v.psb(temp);}
        if(sz%2==0){printf("0\n");}
        else
        {
            ptr=0;
            x=0;
            while(ptr<sz)
            {
                x=x^v[ptr];
                ptr+=2;
            }
            printf("%lld\n",x);
        }
    }
    return 0;
}
