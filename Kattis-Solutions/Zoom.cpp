#include <bits/stdc++.h>
using namespace std;
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
int main() {
    int tot, skip,temp;
    cin>>tot>>skip;
    string s = "";
    for(int i=1;i<=tot;i++)
    {   
        cin>>temp;
        if((i%skip)==0){
            if(s.length()==0){s+=tostr(temp);}
            else{s+= (" "+tostr(temp));}
        }
    }
    
    cout<<s<<"\n";

    return 0;
}
