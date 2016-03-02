#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main(){
    int n;
    int t;
    cin >> n >> t;
    vector<int> width(n);
    for(int width_i = 0;width_i < n;width_i++){
       cin >> width[width_i];
    }
    for(int a0 = 0; a0 < t; a0++){
        int a;
        int b;
        cin >> a >> b;
        int mini=3;
        for(int i=a;i<=b;i++){mini=min(width[i],mini);}
        printf("%d\n",mini);
    }
    return 0;
}
