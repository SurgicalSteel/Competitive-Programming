#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#define psb push_back
using namespace std;
int num,first;
vector<int> v;
vector<int> vres;	
int main() {
    first=0;
    num=104730;
    for(int i=1;i<num;i++)
	{v.push_back(i+1);}
	int cek=0;
	while(cek<v.size())
	{
		bool stop=false;
		first=0;
		while(first<v.size()&&!stop)
		{
			if(v[first]!=-1){stop=true;}
			else{first++;}
		}
		if(v[first]!=-1)
		{
			int temp=v[first];
			vres.push_back(temp);
			v[first]=-1;
			cek++;
			int i=first;
			while(i<v.size())
			{
				if(v[i]!=temp&&v[i]%temp==0&&v[i]!=-1)
				{
					v[i]=-1;
					cek++;
				}
				i+=temp;
			}
		}
	}
    int nt,tc,act;
    scanf("%d",&tc);
    for(int i=0;i<tc;i++)
    {
        scanf("%d",&nt);
        printf("%d\n",vres[nt-1]);
    }
    return 0;
}
