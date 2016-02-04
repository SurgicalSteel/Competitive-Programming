#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
int main() {
    int tc,temp;
    vector<int> v;
    scanf("%d",&tc);
    for(int i=0;i<tc;i++)
    {
        scanf("%d",&temp);
        v.push_back(temp);
    }
    sort(v.begin(),v.end());
    if(v.size()%2!=0){printf("%d\n",v[(v.size()-1)/2]);}
    return 0;
}
