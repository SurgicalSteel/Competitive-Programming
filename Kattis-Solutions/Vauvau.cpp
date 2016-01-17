    #include <bits/stdc++.h>
    using namespace std;
    int ba,ra,bb,rb;//bark and rest
    string solve(int t)
    {
    	int ctrdog=0;
    	if(t%(ba+ra)<=ba&&t%(ba+ra)!=0){ctrdog++;}
    	if(t%(bb+rb)<=bb&&t%(bb+rb)!=0){ctrdog++;}
    	if(ctrdog==0){return "none\n";}
    	else if(ctrdog==1){return "one\n";}
    	else if(ctrdog==2){return "both\n";}
    	else{return " ";}
    }
    int main() {
     
    	int s,d,t;
    	cin>>ba>>ra>>bb>>rb>>s>>d>>t;
    	cout<<solve(s);
    	cout<<solve(d);
    	cout<<solve(t);
    	return 0;
    }
