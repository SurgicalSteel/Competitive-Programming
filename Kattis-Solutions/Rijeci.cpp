#include <bits/stdc++.h>
using namespace std;

int main() {
    int n,a=1,b=0,iter=0,temp;
    cin>>n;
    while(iter<n)
    {
        temp=a;
        a=b;
        b+=temp;
        iter++;
    }
    cout<<a<<" "<<b<<"\n";
    return 0;
}
