#include <bits/stdc++.h>
#include <algorithm>
#define psb push_back
using namespace std;
vector<unsigned long long int> vull;
void initialize()
{
    unsigned long long int x=2;
    for(int i=0;i<63;++i)
    {
        vull.psb(x);
        //printf("%llu\n",vull[i]);
        x*=2;
    }
}
int main() {
    int tc,pos;
    unsigned long long int num;
    initialize();
    
    scanf("%d",&tc);
    while(tc--)
    {
        scanf("%llu",&num);
        
        bool lturn=true;
        while(num!=1)
        {
            if(num==(num&-num))// pow of 2
            {num=num/2;}
            else// !(pow of 2)
            {
                int idx=0;
                while(vull[idx]<num&&idx<vull.size()){idx++;}
                num-=vull[idx-1];
                /*
                pos= __builtin_clzll(num);
                pos=64-pos-1;
                num = num & ~(1<<pos);
                */
            }
            lturn=!lturn;
        }
        if(lturn){printf("Richard\n");}else{printf("Louise\n");}       
    }
    
    return 0;
}
