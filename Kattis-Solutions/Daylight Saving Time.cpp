#include <bits/stdc++.h>
using namespace std;
int main() {
	string forb;
	int tc,temp,nm,h,m;
	cin>>tc;
	while(tc--)
	{
		cin>>forb>>nm>>h>>m;
		if(forb=="F")//forward
		{
			m+=nm;
			h+=((m-(m%60))/60);
			m=m%60;
			h=h%24;
		}
		else//backward
		{
			while(nm>m)
			{
				m+=60;
				h--;
			}
			m=m-nm;
			if(h<0){h+=24;}
		}
		printf("%d %d\n",h,m);
	}
	return 0;
}
