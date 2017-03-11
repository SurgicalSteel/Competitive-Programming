#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007

int main() {
    // your code goes here
    int num[9],temp,tsum=0,xa,xb;
    for(int i=0;i<9;i++){
        scanf("%d",&num[i]);
        tsum+=num[i];
    }
    for(int i=0;i<9;i++){
        for(int j=0;j<9;j++){
            if(i!=j&&(tsum-num[i]-num[j]==100)){
                xa=i;
                xb=j;
            }
        }
    }
    for(int x=0;x<9;x++){
        if(x!=xa&&x!=xb){
            printf("%d\n",num[x]);
        }
    }
    return 0;
}
