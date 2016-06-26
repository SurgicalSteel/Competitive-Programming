#include <bits/stdc++.h>
using namespace std;
int main() {
    int n,p,temp;
    scanf("%d %d",&n,&p);
    int vs[n];
    for(int i=0;i<n;++i)
    {
        scanf("%d",&vs[i]);
        vs[i]-=p;
    }

    //Kadane's Algorithm
    int mEndingHere=0,mSoFar=0;
    for(int i=0;i<n;i++)
    {
        mEndingHere=max(0,mEndingHere+vs[i]);
        mSoFar=max(mSoFar,mEndingHere);
    }
    printf("%d\n",mSoFar);
    
    return 0;
}
