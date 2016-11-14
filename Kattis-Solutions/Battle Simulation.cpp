#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
int toInt(string x)
{
    istringstream ss(x);
    int a;
    ss>>a;
    return a;
}
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
int main() {
    // your code goes here
    string outp="";
    char inp[1000001];
    scanf("%s",&inp);
    int a = strlen(inp);
    int i=0;
    while(i<a)
    {
        if(a-i>=3)
        {
            if(inp[i]!=inp[i+1]&&inp[i+2]!=inp[i+1]&&inp[i]!=inp[i+2])
            {
                outp+="C";
                i+=3;
            }
            else
            {
                if(inp[i]=='R'){outp+="S";}else
                if(inp[i]=='B'){outp+="K";}else
                if(inp[i]=='L'){outp+="H";}
                i++;
            }
        }
        else
        {
            if(inp[i]=='R'){outp+="S";}else
            if(inp[i]=='B'){outp+="K";}else
            if(inp[i]=='L'){outp+="H";}
            i++;
        }
    }
    cout<<outp<<"\n";
    return 0;
}
