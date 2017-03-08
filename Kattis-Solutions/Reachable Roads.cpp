#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()

vector<int> graph[1000];

int main() {
    int tc,nc,nr,ts,td;
    vector<int>tn;
    scanf("%d",&tc);
    while(tc--){
        scanf("%d %d",&nc,&nr);
        int discovered[nc];
        memset(discovered,0,sizeof(discovered));
        for(int p=0;p<nr;p++){
            scanf("%d %d",&ts,&td);
            graph[ts].psb(td);
            graph[td].psb(ts);
        }
        int id=0,ndfs=0,currv;
        while (id<nc){
            if(discovered[id]==1){id++;}
            else{
                //DFS
                stack<int> sta;
                sta.push(id);
                while(sta.size()>0){
                    currv=sta.top();
                    sta.pop();
                    if(discovered[currv]==0){discovered[currv]++;}
                    tn=graph[currv];
                    for(int x=0;x<tn.size();x++){
                        if(discovered[tn[x]]==0){sta.push(tn[x]);}
                    }
                }
                ndfs++;
            }
        }
        //clear graph & temporary neighbor
        printf("%d\n",ndfs-1);
        for(int i=0;i<1000;i++){
            graph[i].clear();
            if(i==0){tn.clear();}   
        }
    }
    return 0;
}
