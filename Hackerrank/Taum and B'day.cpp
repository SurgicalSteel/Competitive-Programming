#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main(){
    int t;
    unsigned long long ho,htb,htw,b,w,x,y,z;//htw default w
    scanf("%d",&t);
    for(int a0 = 0; a0 < t; a0++){
        scanf("%lld %lld",&b,&w);
        scanf("%lld %lld %lld",&x,&y,&z);
        ho=(b*x)+(w*y);
        htw=((w+b)*y)+(b*z);
        htb=((w+b)*x)+(w*z);
        printf("%lld\n",min(ho,min(htw,htb)));
    }
    return 0;
}
