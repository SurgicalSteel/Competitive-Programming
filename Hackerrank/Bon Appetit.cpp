#include <bits/stdc++.h>
using namespace std;
int main() {
    int n,k,b,tb=0;
    scanf("%d %d",&n,&k);
    int arr[n];
    for(int i=0;i<n;i++)
    {
        scanf("%d",&arr[i]);
        tb+=arr[i];
    }
    scanf("%d",&b);
    if(b==((tb-arr[k])/2)){printf("Bon Appetit\n");}
    else{printf("%d",b-((tb-arr[k])/2));}
    return 0;
}
