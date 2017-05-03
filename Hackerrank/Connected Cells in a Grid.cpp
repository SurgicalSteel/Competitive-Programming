#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define all(x) (x).begin(),(x).end()
struct cell{
    int x,y,v,o;
};
int szx,szy;
bool validate(int nx,int ny){ // validate point
    if (nx<0 || ny < 0 || nx>=szx || ny>=szy){
        return false;
    }
    return true;
}
bool isnvisland(cell x){ //validate cell, check if the selected cell is an island (not visited)
    return x.v==0;
}

int main() {
    int tic,it,np=0,ib,maxsz=0,sztemp=0;
    cin>>szy>>szx;
    vector<cell> vc;
    cell mc[szx][szy],tc;

    for(int j=0;j<szy;j++){
        for(int i=0;i<szx;i++){
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
        if (mc[vc[it].x][vc[it].y].v==1||mc[vc[it].x][vc[it].y].v==-1){it++;ib++;}
        else if(mc[vc[it].x][vc[it].y].v==0) {
            sztemp=0;
            stack<cell> sta;
            sta.push(vc[it]);
            sztemp++;
            while(sta.size()>0){
                tc = sta.top();
                sta.pop();
                if (mc[tc.x][tc.y].v == 0){
                    mc[tc.x][tc.y].v++;
                    sztemp++;
                    //get neighbour
                    if (validate(tc.x-1,tc.y)){
                        if (isnvisland(mc[tc.x-1][tc.y])){
                            sta.push(mc[tc.x-1][tc.y]);
                        }
                    }
                    if (validate(tc.x-1,tc.y+1)){
                        if (isnvisland(mc[tc.x-1][tc.y+1])){
                            sta.push(mc[tc.x-1][tc.y+1]);
                        }
                    }
                    if (validate(tc.x-1,tc.y-1)){
                        if (isnvisland(mc[tc.x-1][tc.y-1])){
                            sta.push(mc[tc.x-1][tc.y-1]);
                        }
                    }
                    if (validate(tc.x,tc.y+1)){
                        if (isnvisland(mc[tc.x][tc.y+1])){
                            sta.push(mc[tc.x][tc.y+1]);
                        }
                    }
                    if (validate(tc.x,tc.y-1)){
                        if (isnvisland(mc[tc.x][tc.y-1])){
                            sta.push(mc[tc.x][tc.y-1]);
                        }
                    }
                    if (validate(tc.x+1,tc.y)){
                        if (isnvisland(mc[tc.x+1][tc.y])){
                            sta.push(mc[tc.x+1][tc.y]);
                        }
                    }
                    if (validate(tc.x+1,tc.y+1)){
                        if (isnvisland(mc[tc.x+1][tc.y+1])){
                            sta.push(mc[tc.x+1][tc.y+1]);
                        }
                    }
                    if (validate(tc.x+1,tc.y-1)){
                        if (isnvisland(mc[tc.x+1][tc.y-1])){
                            sta.push(mc[tc.x+1][tc.y-1]);
                        }
                    }
                }
                it++;    
            }
            maxsz=max(maxsz,sztemp);
        }
        
    }
    cout<<maxsz-1<<"\n";
	return 0;
}
