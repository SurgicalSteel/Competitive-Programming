//============================================================================
// Name        : binarytreeforms.cpp
// Author      : Yuwono Bangun Nagoro a.k.a SurgicalSteel
// Version     :
// Copyright   : You can respect and/or blame the author
// Description : Count the forms of binary trees with a given number of node.
//============================================================================
#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
int toInt(string x){
    istringstream ss(x);
    int a;
    ss>>a;
    return a;
}
string tostr(int x){
    ostringstream ss;
    ss<<x;
    return ss.str();
}

int counter(int n){
	if(n<=1){
		return 1; //base case
	}
	n--;
	int sum=0,left,right;
	for(int i=0;i<=n;i++){
		left = counter(i);
		right = counter(n-i);
		sum+= left*right;
	}
	return sum;
}

int main() {
	// your code goes here
	cout<<counter(14)<<"\n";
	return 0;
}
