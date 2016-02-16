import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    public static BigInteger pangkatp(int base,int exp)
    {
        if(exp==0){return BigInteger.valueOf(1);}
        else{return BigInteger.valueOf(base).multiply(pangkatp(base,exp-1));}
    }
    public static int getlength(BigInteger x)
    {
        String a=x.toString();
        return a.length();
    }
    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner s=new Scanner(System.in);
        int n=s.nextInt();
        int ptrres=0;
        String[] res=new String[100];
        for(int i=0;i<100;i++){res[i]="dead";}
        for(int x=1;x<1000000;x++)
        {
            BigInteger temp=pangkatp(x,n);
            if(getlength(temp)==n)
            {
                res[ptrres]=temp.toString();
                ptrres++;
            }
            else if(getlength(temp)>n){break;}
        }
        for(int j=0;j<ptrres;j++)
        {System.out.println(res[j]);}
    }
}
