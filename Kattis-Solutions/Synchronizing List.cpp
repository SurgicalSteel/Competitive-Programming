#include <bits/stdc++.h>
#include <algorithm>
#define pb push_back
using namespace std;

int main() {
	int tc;
	cin>>tc;
	while(tc!=0)
	{
		vector<int> la,lb,lao;
		int temp;
		for(int i=0;i<2*tc;i++)
		{
			cin>>temp;
			if(i<tc){la.pb(temp);lao.pb(temp);}
			else{lb.pb(temp);}
		}
		sort(la.begin(),la.end());
		sort(lb.begin(),lb.end());
		vector<int>::iterator iter;
		for(int i=0;i<tc;i++)
		{
			iter=la.begin();
			iter=find(la.begin(),la.end(),lao[i]);
			cout<<lb[distance(la.begin(),iter)]<<"\n";
		}
		cout<<"\n";
		cin>>tc;
	}
	return 0;
}
