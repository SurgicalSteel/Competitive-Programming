#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()

int main() {
    int step,lv=0,nov=0;
    string sq;
    cin>>step>>sq;
    for(int i=0;i<sq.length();i++){
        if (sq.substr(i,1)=="U"){
            lv++;
        }else{
            lv--;
        }
        if (lv==0&&sq.substr(i,1)=="U"){
            nov++;
        }
    }
	cout<<nov<<"\n";
	return 0;
}
