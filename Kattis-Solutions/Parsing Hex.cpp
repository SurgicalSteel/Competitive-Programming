#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
int tolli(string x)
{
    istringstream ss(x);
    lli a;
    ss>>a;
    return a;
}
string tostr(lli x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
string low(string inp)
{
    string res;
    locale loc;
    for(string::size_type i=0;i<inp.length();i++){
        res+=tolower(inp[i],loc);
    }
    return res;
}
string hexchars[16] = {"0","1","2","3","4","5","6","7","8","9","a","b","c","d","e","f"};
lli getNum(string s){
    lli res;
    if (s=="f"){res=15;}else
    if (s=="e"){res=14;}else
    if (s=="d"){res=13;}else
    if (s=="c"){res=12;}else
    if (s=="b"){res=11;}else
    if (s=="a"){res=10;}else
    {res=tolli(s);}
    return res;
}
bool ishex(string s){
    bool found =false;
    int i=0;
    s=low(s);
    while(i<16&&!found){
        found= (s==hexchars[i]);
        i++;
    }
    return found;
}

lli pow(lli base,lli exp){
    if (exp==0){
        lli r = 1;
        return r;
    }else{
        return base*pow(base, exp-1);
    }
}
string translateHex(string s){
    lli res=0;
    s= s.substr(2,s.length()-2);
    s=low(s);
    for(int i=0;i<s.length();i++){
        res += getNum(s.substr(i,1))*pow(16,s.length()-i-1);
    }
    return tostr(res);
}
vector<string> getHexMap(string s){
    int i=0;
    bool chex=false,breaker=false;
    string currhex;
    vector<string> vs,orihex;
    while(i<s.length()&&!breaker){
        if(i<s.length()-2){
            if(s.substr(i,2)=="0x" || s.substr(i,2)=="0X"){
                currhex += s.substr(i,2);
                chex=true;
                i+=2;
            }
            if(chex && i<s.length()){
                if(ishex(s.substr(i,1))){
                   currhex += s.substr(i,1);
                }else{
                    orihex.psb(currhex);
                    chex=false;
                    currhex="";
                }
            }
        }else{
            if(chex && i<s.length()){
                if(ishex(s.substr(i,1))){
                   currhex += s.substr(i,1);
                }else{
                    orihex.psb(currhex);
                    chex=false;
                    currhex="";
                }
            }
        }
        i++;
        if (i==s.length()){
            breaker=true;
            if(currhex!=""){orihex.psb(currhex);}
        }
    }
    for(int x=0;x<orihex.size();x++){
        vs.psb(orihex[x]);
        vs.psb(translateHex(orihex[x]));
    }
    return vs;
}
int main() {
    // your code goes here
    string s;
    vector<string> vs;
    while(getline(cin,s)){
        vs.clear();
        vs = getHexMap(s);
        int i=0;
        while(i<vs.size()-1){
            cout<<vs[i]<<" "<<vs[i+1]<<"\n";
            i+=2;
        }
    }
    return 0;
}
