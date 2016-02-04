#include <iostream>

using namespace std;

int main()
{
    int t,n,k;
    cin>>t;
    string ans[t];
    for(int i=0;i<t;i++)
    {
        cin>>n>>k;
        int arrivaltime[n],counter=0;
        for(int x=0;x<n;x++)
        {
            cin>>arrivaltime[x];
            if(arrivaltime[x]<=0){counter++;}
        }
        if(counter>=k){ans[i]="NO";}else{ans[i]="YES";}
    }
    for(int i=0;i<t;i++)
    {cout<<ans[i]<<endl;}
    return 0;
}
