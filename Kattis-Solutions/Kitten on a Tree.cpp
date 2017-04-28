#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
// by Yuwono Bangun Nagoro a.k.a SurgicalSteel

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
vector<int> ssplit(string s){
    int i=0;
    vector<int> vs;
    string subs="";
    while(i<s.length()){
        if (i==s.length()-1){
            subs+=s.substr(i,1);
            vs.psb(toInt(subs));
            subs="";
        }else if (s.substr(i,1)==" "){
            vs.psb(toInt(subs));
            subs="";
        }
        else if (s.substr(i,1)!=" "){
            subs+=s.substr(i,1);
        }
        i++;
    }
    return vs;
}
bool contains(vector<int> v, int i){
    vector<int>::iterator it;
    it = find(all(v),i);
    return it!=v.end();
}
vector<int> graph[100];
int findp(int x){
    for(int i=0;i<100;i++){
        if(contains(graph[i],x)){
            return i;
        }
    }
    return -1;
}
int main() {
    // your code goes here
    int curr,pcurr;
    string s="";
    vector<int> tm,path;
    scanf("%d",&curr);
    while(s!="-1"){
        getline(cin,s);
        if (s=="-1"){break;}
        tm=ssplit(s);
        for(int x=1;x<tm.size();x++){
            graph[tm[0]-1].psb(tm[x]);
            if (tm[x]==curr){pcurr=tm[0];}
        }
        s="";
        tm.clear();
    }
    curr--;
    while(true){
        path.psb(curr+1);
        if(findp(curr+1)==-1){break;}
        curr=findp(curr+1);
        
    }
    for(int i=0;i<path.size();i++){
        cout<<path[i]<<" ";
    }
    cout<<"\n";
    return 0;
}
