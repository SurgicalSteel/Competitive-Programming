#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define MOD 1000000007
vector<int> v;
int getindex(int x){
    vector<int>::iterator it=find(all(v),x);
    if (it != v.end()){
        return distance(v.begin(),it)+1;
    }
    return -1;
}

int main() {
	// your code goes here
	int n,t;
    scanf("%d",&n);
    for(int i=0;i<n;i++){
        scanf("%d",&t);
        v.psb(t);
    }
    for(int i=1;i<=n;i++){
        printf("%d\n",getindex(getindex(i)));
    }
	return 0;
}
