#include <bits/stdc++.h>
using namespace std;
int main() {
    int szm, npath,nq, a,b,e;
    scanf("%d %d",&szm,&npath);
    int matrix[szm][szm];
    for(int j=0;j<szm;j++)
    {
        for(int i=0;i<szm;i++)
        {
            if(i!=j){matrix[i][j]=200000000;}
            else{matrix[i][j]=0;}
        }
    }
    for(int i=0;i<npath;i++)
    {
        scanf("%d %d %d",&a,&b,&e);
        matrix[a-1][b-1]=e;
    }
    int dmatrix[szm][szm],i,j,k;
    for(int j=0;j<szm;j++)
    {
        for(int i=0;i<szm;i++)
        {dmatrix[i][j]=matrix[i][j];}
    }
    for(int k=0;k<szm;k++)
    {
        for(int i=0;i<szm;i++)
        {
            for(int j=0;j<szm;j++)
            {
                if(dmatrix[i][k]+dmatrix[k][j]<dmatrix[i][j]){dmatrix[i][j]=dmatrix[i][k]+dmatrix[k][j];}
            }    
        }
    }
    scanf("%d",&nq);
    while(nq--)
    {
        scanf("%d %d",&a,&b);
        if(dmatrix[a-1][b-1]==200000000){printf("-1\n");}
        else{printf("%d\n",dmatrix[a-1][b-1]);}
    }
    return 0;
}
