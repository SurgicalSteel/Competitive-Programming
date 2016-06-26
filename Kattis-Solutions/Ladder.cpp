#include <bits/stdc++.h>
#include <math.h>  
#define PI 3.1415926535897932384626433832795
using namespace std;
int solve(int h,int a)
{
    double res=(double) (h / (sin((double) (a*PI)/180)));
    return (int) ceil(res);
}
int main() {
    // your code goes here
    int height,angle;
    cin>>height>>angle;
    cout<<solve(height,angle)<<"\n";
    return 0;
}
