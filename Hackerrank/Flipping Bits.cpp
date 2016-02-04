#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int tc;
    cin>>tc;
    long long res[tc],temp;
    for(int i=0;i<tc;i++)
    {
        cin>>temp;
        res[i]=4294967295-temp;
    }
    for(int i=0;i<tc;i++)
    {cout<<res[i]<<"\n";}
    return 0;
}
