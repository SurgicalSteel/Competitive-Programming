#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#define psb push_back
using namespace std;
int pangkat(int base,int exp)
{
    if(exp==0){return 1;}
    else{return base*pangkat(base,exp-1);}
}
int main() {
    int tc,temp;
    scanf("%d",&tc);
    int prima[]={2,3,5,7,11,13,17,19,23,29,31,37};
    for(int i=0;i<tc;i++)
    {
        scanf("%d",&temp);
        vector<int> pres;
        long long kali=1;
        int exp,x=0;
        while(prima[x]<=temp)
        {
            bool breaker=false;
            exp=1;
            int tempnum=prima[x];
            while(!breaker)
            {
                if(pangkat(prima[x],exp)<=temp){tempnum=pangkat(prima[x],exp);}
                else{breaker=true;}
                exp++;
            }
            pres.psb(tempnum);
            x++;
        }
        for(int it=0;it<pres.size();it++){kali*=pres[it];}
        printf("%lld\n",kali);
    }
    return 0;
}
