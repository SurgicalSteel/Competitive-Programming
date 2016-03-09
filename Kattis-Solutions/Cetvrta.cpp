#include <bits/stdc++.h>
#include <algorithm>
using namespace std;
int main()
{
    int ax,bx,cx,ay,by,cy,dx,dy;
    scanf("%d %d %d %d %d %d",&ax,&ay,&bx,&by,&cx,&cy);
    if(ax!=bx&&ax!=cx){dx=ax;}
    else if(bx!=ax&&bx!=cx){dx=bx;}
    else if(cx!=ax&&cx!=bx){dx=cx;}
    if(ay!=by&&ay!=cy){dy=ay;}
    else if(by!=ay&&by!=cy){dy=by;}
    else if(cy!=ay&&cy!=by){dy=cy;}
    printf("%d %d\n",dx,dy);
    return 0;
}
