#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */ 
    int n,temp;
    cin>>n;
    int arr[100];
    for(int i=0;i<100;i++){arr[i]=0;}
    for(int i=0;i<n;i++)
    {
        cin>>temp;
        arr[temp]++;
    }
    for(int i=0;i<100;i++)
    {cout<<arr[i]<<" ";}
    return 0;
}
