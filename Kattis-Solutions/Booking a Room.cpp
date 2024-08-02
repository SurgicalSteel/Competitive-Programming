#include <bits/stdc++.h>
#include <algorithm>
#define pb push_back
using namespace std;

int main() {
    int r,n,temp;
    cin>>r>>n;
    int arr[r];
    for(int i=0;i<r;i++)
    {arr[i]=0;}
    for(int i=0;i<n;i++)
    {
        cin>>temp;
        arr[temp-1]=temp;
    }
    if(r==n){cout<<"too late\n";}
    int i=0;
    while(i<r)
    {
        if(arr[i]==0){cout<<i+1<<"\n";break;}
        i++;
    }
    return 0;
}
