#include <bits/stdc++.h>
using namespace std;
int main() {
  // your code goes here
  int mat[20][20];
  for(int j=0;j<20;j++)
  {
  	for(int i=0;i<20;i++)
  	{cin>>mat[i][j];}
  }
  int maxi=0;
  for(int j=0;j<20;j++)
  {
  	for(int i=0;i<20;i++)
	  {
		  //cek diagonal miring kekanan
			if(i>=3&&j<=16)
    	{
  			if(mat[i][j]*mat[i-1][j+1]*mat[i-2][j+2]*mat[i-3][j+3]>maxi)
  			{maxi=mat[i][j]*mat[i-1][j+1]*mat[i-2][j+2]*mat[i-3][j+3];}
  		}
  		//cek diagonal miring kekiri
  		if(i<=16&&j<=16)
  		{
  			if(mat[i][j]*mat[i+1][j+1]*mat[i+2][j+2]*mat[i+3][j+3]>maxi)
  			{maxi=mat[i][j]*mat[i+1][j+1]*mat[i+2][j+2]*mat[i+3][j+3];}
  		}
  		//cek kebawah
  		if(j<=16)
  		{
  			if(mat[i][j]*mat[i][j+1]*mat[i][j+2]*mat[i][j+3]>maxi)
  			{maxi=mat[i][j]*mat[i][j+1]*mat[i][j+2]*mat[i][j+3];}
  		}
  		//cek kekanan
  		if(i<=16)
  		{
  			if(mat[i][j]*mat[i+1][j]*mat[i+2][j]*mat[i+3][j]>maxi)
  			{maxi=mat[i][j]*mat[i+1][j]*mat[i+2][j]*mat[i+3][j];}
  		}
  	}
  }
  cout<<maxi<<"\n";
  return 0;
}
