#include <bits/stdc++.h>
using namespace std;
int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int t,n,c,m;
    cin>>t;
    while(t>0){
        cin>>n>>c>>m;
        int x=(n-(n%c))/c;
        int y=x;
        int sisa=0;
        if(y>=m)
        {
            while (y>=m)
            {
            	sisa=y%m;
                y=(y-sisa)/m;
                x+=y;
                y+=sisa;
            }
        }
        cout<<x<<"\n";
        t--;
    }
    return 0;
}
