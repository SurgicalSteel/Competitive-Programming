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
char toCharSingle(string x)//single substring as input. Converts single substring to single char
{
    char a[1];
    strncpy(a,x.c_str(),sizeof(a));
    return a[0];
}

vector<int> graph[26];
bool finder(vector<int> v, int x)
{
    vector<int>::iterator it=find(all(v),x);
    return !(it==v.end());
}

bool reachable(int a,int b)//from a to b using dfs
{
    int discovered[26];
    memset(discovered,0,sizeof(discovered));
    if (a==b){return true;}
    int cur;
    stack<int> sta;
    sta.push(a);
    while(sta.size()>0){
    	cur=sta.top();
    	sta.pop();
        discovered[cur]++;
    	if (cur==b){
    	    return true;
    	}else{
    	    for(int i=0;i<graph[cur].size();i++){
                if (discovered[graph[cur][i]]==0){
                    sta.push(graph[cur][i]);
                }
    	    }
    	}
    }
    return false;
}
void addConnection(int a,int b){
    graph[a].psb(b);
}
int main() {
    // your code goes here
    int ne,np,j;
    string sa,sb;
    bool reach;
    cin>>ne>>np;
    for(int i=0;i<ne;i++){
  	cin>>sa>>sb;
	addConnection(int(toCharSingle(sa))-97,int(toCharSingle(sb))-97);
    }
    for(int k=0;k<np;k++){
	cin>>sa>>sb;
	if(sa.length()!=sb.length()){
	    cout<<"no\n";
	}else{ //equal length, then check reachability
	    j=0;
            reach=true;
            while(j<sa.length()&&reach){
		//cout<<(int(toCharSingle(sa.substr(j,1)))-97)<<" "<<(int(toCharSingle(sb.substr(j,1)))-97)<<"\n";
	        reach=reachable((int(toCharSingle(sa.substr(j,1)))-97),(int(toCharSingle(sb.substr(j,1)))-97));
	        //cout<<"test "<<reach<<"\n";
                j++;
	    }
	    if (reach){
	        cout<<"yes\n";
	    }else{
	        cout<<"no\n";
            }
	}
    }
    return 0;
}
