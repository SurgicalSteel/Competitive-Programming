#include <bits/stdc++.h>
using namespace std;
#define PI 3.1415926535897932384626433832795


int main() {
    int tc,num;
    float ang,currang=0;
    float sca;
    cin>>tc;
    for(int i=0;i<tc;i++)
    {
        cin>>num;
        float posx=0.00000000,posy=0.000000000;
        for(int j=0;j<num;j++)
        {
            cin>>ang>>sca;
            if(j==0)
            {
            	currang=90+ang;
            	if(currang<0){currang+=360;}
            }
            else
            {
            	currang+=ang;
            	if(currang<0){currang+=360;}
            }
            posx+=(sca*(cos((double) ((currang)*PI/180))));
            posy+=(sca*(sin((double) ((currang)*PI/180))));
        }
        printf("%.6f %.6f \n",posx,posy);//cout<<posx<<" "<<posy<<"\n";
    }
    return 0;
}
