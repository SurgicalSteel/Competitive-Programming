#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

string isfibo(long long n)
{
    long long a=0,b=1,curr=1;
    string ret=" ";
    bool flag=true;
    if(n==0||n==1){return "IsFibo";}
    else {
        while (curr<n&&flag)
        {
            curr=a+b;
            a=b;
            b=curr;
            if(curr+a==n){
                ret="IsFibo";
                flag=false;
                         }
            else if(curr+a>n){ret="IsNotFibo";flag=false;}
        }
    }
    return ret;
}
int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int tc;
    cin>>tc;
    long long temp;
    string res[tc];
    for(int i=0;i<tc;i++)
    {
        cin>>temp;
        res[i]=isfibo(temp);
    }
    for(int i=0;i<tc;i++)
    {cout<<res[i]<<"\n";}
    return 0;
}
