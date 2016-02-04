#include <bits/stdc++.h>
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
#define pb push_back
int getdiff(int a, int b)
{
    int diff;
    (a-b)<0?diff=(a-b)*-1:diff=(a-b);
    return diff;
}
int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int n,x;
    cin>>n;
    vector <int> col;
    for(int i=0;i<n;i++)
    {
        cin>>x;
        col.pb(x);
    }
    sort(col.begin(),col.end());
    int mindiff=2000000000;
    for(int i=0;i<n-1;i++)
    {if(getdiff(col[i],col[i+1])<mindiff){mindiff=getdiff(col[i],col[i+1]);}}
    for(int i=0;i<n-1;i++)
    {if(getdiff(col[i],col[i+1])==mindiff){cout<<col[i]<<" "<<col[i+1]<<" ";}}
    cout<<"\n";
    return 0;
}
