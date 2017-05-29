#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
vector<int> col;
void init(){
	col.psb(0);
	col.psb(31);
	col.psb(28);
	col.psb(31);
	col.psb(30);
	col.psb(31);
	col.psb(30);
	col.psb(31);
	col.psb(31);
	col.psb(30);
	col.psb(31);
	col.psb(30);
	col.psb(31);
}
string getday(int n){
	n=max(n,0);
	if (n==0){return "Thursday"; }else
	if (n==1){return "Friday"; }else
	if (n==2){return "Saturday"; }else
	if (n==3){return "Sunday"; }else
	if (n==4){return "Monday"; }else
	if (n==5){return "Tuesday"; }else
	if (n==6){return "Wednesday"; }else
	{return "";}
}
int main() {
	// your code goes here
	int d,m,ctrd=0,t;
	init();	
	cin>>d>>m;
	for(int i=0;i<m;i++){
		ctrd+=col[i];
	}
	ctrd+=d;
	t=(ctrd%7)-1;
	if (t<0){t=6;}
	cout<<getday(t)<<"\n";
	return 0;
}
