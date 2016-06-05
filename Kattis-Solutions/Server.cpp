#include <iostream>
using namespace std;

int main() {
    int nt,m,nm=0,ctr=0,temp;
    cin>>nt>>m;
    for(int i=0;i<nt;i++)
    {
        cin>>temp;
        if((nm+temp)<=m){nm+=temp;ctr++;}else{break;}
    }
    cout<<ctr<<"\n";
    return 0;
}
