#include <bits/stdc++.h>
#define psb push_back
#define mkp make_pair
using namespace std;
//by Yuwono Bangun Nagoro a.k.a SurgicalSteel
struct cell{
    int x,y,v,o;
};
bool validate(int nx,int ny,int sz){ // validate point
    if (nx<0 || ny < 0 || nx>=sz || ny>=sz){
        return false;
    }
    return true;
}
bool isnvisland(cell x){ //validate cell, check if the selected cell is an island (not visited)
    return x.v==0;
}
int main()
{
    int sz,tic,it,np=0,ib;
    cin>>sz;
    vector<cell> vc;
    cell mc[sz][sz],tc;

    for(int j=0;j<sz;j++){
        for(int i=0;i<sz;i++){
            tc.x=i;
            tc.y=j;
            cin>>tic;
            tc.o=tic;
            if(tic==0){
                tc.v=-1;
            }else{
                tc.v=0;
                vc.psb(tc);
            }
            mc[i][j]=tc;
        }
    }
    if (vc.size()==0){
        cout<<"0\n";
        return 0;
    }
    it=0;
    ib=0;
    while(it<vc.size()){
        if (mc[vc[it].x][vc[it].y].v==1){it++;ib++;}
        else{
            stack<cell> sta;
            sta.push(vc[it]);
            while(sta.size()>0){
                tc = sta.top();
                sta.pop();
                if (mc[tc.x][tc.y].v == 0){
                    mc[tc.x][tc.y].v++;
                    //get neighbour
                    if (validate(tc.x-1,tc.y,sz)){
                        if (isnvisland(mc[tc.x-1][tc.y])){
                            sta.push(mc[tc.x-1][tc.y]);
                        }
                    }
                    if (validate(tc.x-1,tc.y+1,sz)){
                        if (isnvisland(mc[tc.x-1][tc.y+1])){
                            sta.push(mc[tc.x-1][tc.y+1]);
                        }
                    }
                    if (validate(tc.x-1,tc.y-1,sz)){
                        if (isnvisland(mc[tc.x-1][tc.y-1])){
                            sta.push(mc[tc.x-1][tc.y-1]);
                        }
                    }
                    if (validate(tc.x,tc.y+1,sz)){
                        if (isnvisland(mc[tc.x][tc.y+1])){
                            sta.push(mc[tc.x][tc.y+1]);
                        }
                    }
                    if (validate(tc.x,tc.y-1,sz)){
                        if (isnvisland(mc[tc.x][tc.y-1])){
                            sta.push(mc[tc.x][tc.y-1]);
                        }
                    }
                    if (validate(tc.x+1,tc.y,sz)){
                        if (isnvisland(mc[tc.x+1][tc.y])){
                            sta.push(mc[tc.x+1][tc.y]);
                        }
                    }
                    if (validate(tc.x+1,tc.y+1,sz)){
                        if (isnvisland(mc[tc.x+1][tc.y+1])){
                            sta.push(mc[tc.x+1][tc.y+1]);
                        }
                    }
                    if (validate(tc.x+1,tc.y-1,sz)){
                        if (isnvisland(mc[tc.x+1][tc.y-1])){
                            sta.push(mc[tc.x+1][tc.y-1]);
                        }
                    }
                }
            }
            it++;
        }
        np++;
    }

    cout<<np-ib<<"\n";
    return 0;
}
