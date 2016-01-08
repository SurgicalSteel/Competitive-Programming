#include <bits/stdc++.h>
using namespace std;

int main() {
    long long temp;
    int tc,n,tot=0;
    cin>>tc;
    for(int i=0;i<tc;i++)
    {
        cin>>n;
        tot=0;
        for(int j=0;j<n;j++)
        {
            cin>>temp;
            tot+=temp%n;
        }
        if(tot%n==0){cout<<"YES\n";}else{cout<<"NO\n";}
    }
    return 0;
}
