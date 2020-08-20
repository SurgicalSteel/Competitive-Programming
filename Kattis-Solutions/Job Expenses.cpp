#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n;
    long long xtot=0,tmp;
    cin>>n;
    for(int i=0;i<n;i++){
        cin>>tmp;
        if(tmp<0){
            xtot += (tmp * -1);
        }
    }
    cout<<xtot<<"\n";
    return 0;
}
