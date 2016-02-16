#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
long long sumevenfib(long long n)
{
    long long counter=0,curr=1,i=0,j=1;
    while (curr<=n)
    {
        if(curr%2==0){counter+=curr;}
        i=j;
        j=curr;
        curr=i+j;
    }
    return counter;
}

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */  
    int tc;
    cin>>tc;
    long long temp,res[tc];
    for(int i=0;i<tc;i++)
    {
        cin>>temp;
        res[i]=sumevenfib(temp);
    }
    for(int i=0;i<tc;i++)
    {cout<<res[i]<<"\n";}
    return 0;
}
