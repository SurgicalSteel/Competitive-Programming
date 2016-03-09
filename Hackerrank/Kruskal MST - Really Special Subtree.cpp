#include <bits/stdc++.h>
#include <algorithm>
#define psb push_back
using namespace std;
struct edge
{int sa,du,bo;};
vector<edge> graph,res;
bool compare(edge s,edge d){return s.bo<d.bo;}
bool xorshit(bool x,bool y)
{
    if((x&&!y)||(!x&&y)){return true;}
    else{return false;}
}
bool cekres(edge e)
{
    bool trutha=false,truthb=false;
    for(int i=0;i<res.size();i++)
    {
        if(res[i].sa==e.sa||res[i].du==e.sa){trutha=true;}
        if(res[i].sa==e.du||res[i].du==e.du){truthb=true;}
    }
    return xorshit(trutha,truthb);
}
int main() {
    edge temp;
    int tsa,tdu,tbo,nv,ne,sta,tot=0;
    scanf("%d %d",&nv,&ne);
    for(int i=0;i<ne;i++)
    {
        scanf("%d %d %d",&tsa,&tdu,&tbo);
        temp.sa=tsa;
        temp.du=tdu;
        temp.bo=tbo;
        graph.psb(temp);
    }
    scanf("%d",&sta);
    sort(graph.begin(),graph.end(),compare);
    
    int iterator=0;
    while(iterator<nv-1)
    {
        if(iterator==0)
        {
            bool breaker=false;
            int x=0;
            //find initial edge
            while(!breaker&&x<graph.size())
            {
                if(graph[x].sa==sta||graph[x].du==sta)
                {
                    res.psb(graph[x]);
                    tot+=graph[x].bo;
                    breaker=true;
                }
                else{x++;}
            }
            iterator++;
        }
        else
        {
            int it = 0;
            bool breaker = false;
            while(it<graph.size()&&!breaker)
            {
                if (cekres(graph[it]))
                {
                    res.psb(graph[it]);
                    tot+=graph[it].bo;
                    iterator++;
                    breaker = true;
                }
                else { it++; }
            } 
        }
    }
    for(int i=0;i<ne;i++)
    {
        if(cekres(graph[i]))
        {
            res.psb(graph[i]);
            tot+=graph[i].bo;
        }
    }
    /*
    for(int i=0;i<graph.size();i++){printf("%d %d %d\n",graph[i].sa, graph[i].du, graph[i].bo);}
    printf("\n");
    for(int i=0;i<res.size();i++){printf("%d %d %d\n",res[i].sa, res[i].du, res[i].bo);}
    */
    printf("%d\n",tot);
    return 0;
}
