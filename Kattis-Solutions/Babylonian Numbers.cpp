#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
int toint(string x)
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
lli pow(int base,int exp){
    if (exp==0){
        lli r = 1;
        return r;
    }else{
        return base*pow(base, exp-1);
    }
}
lli calc(vector<int> v){
    lli tot = 0;
    for(int i=0;i<v.size();i++){
        tot += ((v[i])*pow(60,v.size()-i-1));
    }
    return tot;
}

vector<int> split(string s){
    vector<int> vi;
    int i=0;
    string curr="";
    while(i<s.length()){
        if ((s.substr(i,1)==",") || (i+1 == s.length())){
            curr += s.substr(i,1);
            vi.psb(toint(curr));
            curr = "";
        }
        else{
            curr += s.substr(i,1);
        }
        i++;
    }
    return vi;
}
string replace(string s){
    string builder="";
    int i=0;
    while(i<s.length()){
        if ((i+1 == s.length()) && (s.substr(i,1) == ",")){
            builder += (s.substr(i,1) + "0");
        }else if((i+2 <= s.length()) && (s.substr(i,2)==",,")){
            builder+= ((s.substr(i,1)) + "0");
        }
        else{
            builder+= (s.substr(i,1));
        }
        i++;
    }
    return builder;
}
int main() {
    // your code goes here
    int tc;
    string s;
    cin>>tc;
    for(int i=0;i<tc;i++){
        cin>>s;
        cout<<calc(split(replace(s)))<<"\n";
    }
    return 0;
}
