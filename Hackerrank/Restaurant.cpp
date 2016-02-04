#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
int findgcd(int a,int b)
{
    int maxi=0;
    for(int i=1;i<=min(a,b);i++)
    {
        if(a%i==0&&b%i==0)
        {maxi=i;}
    }
    return maxi;
}
//hackerrank-->math-->fundamental-->restaurant
int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */  
    int tc,i=0,l,b,res;
    cin>>tc;
    while(i<tc)
    {
        cin>>l>>b;
        res=(l*b)/(findgcd(l,b)*findgcd(l,b));
        cout<<res<<"\n";
        i++;
    }
    return 0;
}
