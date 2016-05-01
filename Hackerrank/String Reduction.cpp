#include <bits/stdc++.h>
using namespace std;
#define psb push_back
int solve(string s)
{
    vector<int> v;
    v.psb(0);v.psb(0);v.psb(0);
    for(int i=0;i<s.length();++i)
    {
        if(s.substr(i,1)=="a"){v[0]++;}
        else if(s.substr(i,1)=="b"){v[1]++;}
        else if(s.substr(i,1)=="c"){v[2]++;}
    }
    if((v[0]>0&&v[1]==0&&v[2]==0)||(v[0]==0&&v[1]>0&&v[2]==0)||(v[0]==0&&v[1]==0&&v[2]>0)){return max(v[0],max(v[1],v[2]));}
    else{
        int ctr=0;
        bool finished=false;
        while(!finished)
        {
            if(min(v[0],min(v[1],v[2]))==v[0])
            {
                v[0]++;
                v[1]--;
                v[2]--;
            }
            else if(min(v[0],min(v[1],v[2]))==v[1])
            {
                v[0]--;
                v[1]++;
                v[2]--;
            }
            else if(min(v[0],min(v[1],v[2]))==v[2])
            {
                v[0]--;
                v[1]--;
                v[2]++;
            }
            finished=((v[0]>0&&v[1]==0&&v[2]==0)||(v[0]==0&&v[1]>0&&v[2]==0)||(v[0]==0&&v[1]==0&&v[2]>0));
        }
        return max(v[0],max(v[1],v[2]));
    }
}
int main() {
    int tc;
    scanf("%d",&tc);
    string temp;
    while(tc--)
    {
        cin>>temp;
        printf("%d\n",solve(temp));
    }
    return 0;
}
