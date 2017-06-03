#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
string low(string inp)
{
	string res;
	locale loc;
	for(string::size_type i=0;i<inp.length();i++)
	{res+=tolower(inp[i],loc);}
	return res;
}
const string h="hackerrank";
string solve(string s){
    bool found=false;
    s=low(s);
    int pth=0,pts=0;
    while(pth<h.length()&&pts<s.length()&&!found){
        if (s.substr(pts,1)==h.substr(pth,1)){
            pth++;
        }
        if (pth+1==h.length()){
            found=true;
        }
        pts++;
    }
    if (found){
        return "YES\n";
    }else{
        return "NO\n";
    }
}
int main() {
	// your code goes here
    string s;
    int tc;
    cin>>tc;
    while(tc--){
        cin>>s;
        cout<<solve(s);
    }
	return 0;
}
