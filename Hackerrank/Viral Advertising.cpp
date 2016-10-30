#include <bits/stdc++.h>
using namespace std;

int main() {
    int d;
    long long int n=0,cdl=0;
    cin>>d;
    if(d==1){n=2;}
    else{
        cdl=2;
        n=cdl;
        for(int i=1;i<d;i++)
        {
            cdl = ((cdl*3)-((cdl*3)%2))/2;
            n+=cdl;
        }
    }
    cout<<n<<"\n";
    return 0;
}
