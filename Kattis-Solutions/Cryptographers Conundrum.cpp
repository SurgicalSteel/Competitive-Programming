#include <bits/stdc++.h>
using namespace std;
string low(string inp)
{
    string res;
    locale loc;
    for(string::size_type i=0;i<inp.length();i++)
    {res+=tolower(inp[i],loc);}
    return res;
}
int main() {
    string inp;
    cin>>inp;
    inp=low(inp);
    int tot=0;
    for(int i=0;i<inp.length();i++)
    {
        if((i%3==0&&inp.substr(i,1)!="p")||(i%3==1&&inp.substr(i,1)!="e")||(i%3==2&&inp.substr(i,1)!="r"))
        {tot++;}
    }
    cout<<tot<<"\n";
    return 0;
}
