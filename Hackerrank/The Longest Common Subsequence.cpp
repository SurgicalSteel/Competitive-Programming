#include <bits/stdc++.h>
#define psb push_back
using namespace std;
vector<int> va,vb,build;
struct cell{
    int num, prevx,prevy;
};
int absolutey(int x)
{
	if(x<0){return x*-1;}
	else{return x;}
}
int main() {
    int sza,szb,tmp;
    scanf("%d %d",&sza,&szb);
    cell temp;
    cell matrix[szb+1][sza+1]; // a = x horizontal, b = y vertical
    for(int x=0;x<sza;++x)
    {
        scanf("%d",&tmp);
        va.psb(tmp);
    }
    for(int x=0;x<szb;++x)
    {
        scanf("%d",&tmp);
        vb.psb(tmp);
    }
    //---let's play with the matrix!---
    //initialize
    int largest=0;
    for(int y=0;y<szb+1;++y)
    {
        for(int x=0;x<sza+1;++x)
        {
            if(x==0||y==0)
            {
                temp.num=0;
                matrix[y][x]=temp;
            }
            else if(va[x-1]==vb[y-1])
            {
                temp.prevx=x-1;
                temp.prevy=y-1;
                temp.num=matrix[y-1][x-1].num+1;
                matrix[y][x]=temp;
                largest=max(largest,matrix[y][x].num);
            }
            else
            {
                temp.num=max(matrix[y-1][x].num,matrix[y][x-1].num);
                if(max(matrix[y-1][x].num,matrix[y][x-1].num)==matrix[y-1][x].num)
                {
                    temp.prevx=x;
                    temp.prevy=y-1;
                }
                else
                {
                  temp.prevx=x-1;
                  temp.prevy=y;
                }
                matrix[y][x]=temp;
            }
        }
    }
    int tj=0;                      
    int ti=0;                      
    bool found=false;
    for(int y=0;y<szb+1;++y)
    {
        for(int x=0;x<sza+1;++x)
        {if(matrix[y][x].num==largest&&!found){tj=y;ti=x;found=true;break;}}
    }
    //BACKTRACK CUY!!!
    cell current=matrix[tj][ti];
    while(current.num!=0){
        if(current.prevx==(ti-1)&&current.prevy==(tj-1))
        {
            build.psb(vb[tj-1]);
            current=matrix[current.prevy][current.prevx];
            tj--;
            ti--;
        }
        else
        {
        	tj=tj-absolutey(tj-current.prevy);
        	ti=ti-absolutey(ti-current.prevx);
        	current=matrix[current.prevy][current.prevx];
        }
    }
    int start=build.size()-1;
    for(int i=start;i>=0;--i)
    {printf("%d ",build[i]);}
    printf("\n");
    return 0;
}
