#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
lli toInt(string x)
{
    istringstream ss(x);
    lli a;
    ss>>a;
    return a;
}
string toStr(lli x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
string reverse(string a) //reverses a given string
{
  string x;
  for(int y=a.length()-1;y>=0;y--)
  {x+=a.substr(y,1);}
  return x;
}
struct person{
    string name;
    lli score;
};
string getname(string n){
    return n.substr(0,n.length()-1);
}
lli decodeclass(string spl){
    string cres;
    lli res;
    int i=0;
    while(i<spl.length()){
        if(spl.substr(i,1)=="l"){ //lower
            cres+="1";
            i+=5;
        }
        else if(spl.substr(i,1)=="m"){ //middle
            cres+="2";
            i+=6;
        }
        else if(spl.substr(i,1)=="u"){ //upper
            cres+="3";
            i+=5;
        }
        i++;
    }
    cres=reverse(cres);
    while(cres.length()<10){
        cres+="2";
    }
    
    return toInt(cres);
}
bool cmp(person const &pa,person const &pb){
     if(pa.score>pb.score){return true;}
     else if (pa.score == pb.score){
     	if (pa.name<pb.name){return true;}
     }
     return false;
}
void printsep(){
    string s="";
    for(int i=0;i<30;i++){s+="=";}
    cout<<s<<"\n";
}
vector<person> vp;
int main() {
	// your code goes here
	int tc,np;
        string tn,tl,tclass;
        lli ts;
        person tp;
        scanf("%d",&tc);
        while(tc--){
            vp.clear();
            scanf("%d",&np);
            while(np--){
                cin>>tn>>tl>>tclass;
                tn=getname(tn);
                ts=decodeclass(tl);
                tp.name=tn;
                tp.score=ts;
                vp.psb(tp);
            }
            sort(vp.begin(),vp.end(),cmp);
            for(int i=0;i<vp.size();i++){
                cout<<vp[i].name<<"\n";
            }
            printsep();
        }
	return 0;
}
