import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    public static int toInteger(String s)//substring 1 char
    {return Integer.parseInt(s);}
    public static BigInteger pangkatp(int base,int exp)
    {
        if(exp==0){return BigInteger.valueOf(1);}
        else{return BigInteger.valueOf(base).multiply(pangkatp(base,exp-1));}
    }
    public static long sumstr(int a,int b)
    {
        long ctr=0;
        String s=pangkatp(a,b).toString();
        for(int i=0;i<s.length();i++)
        {ctr+=Integer.parseInt(s.substring(i,i+1));}
        return ctr;
    }

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner s=new Scanner(System.in);
        int n=s.nextInt();
        long countertemp=0;
        for(int x=1;x<n;x++)
        {
            for(int y=1;y<n;y++)
            {
                long v=sumstr(x,y);
                if(v>countertemp){countertemp=v;}
            }
        }
        System.out.println(countertemp);
    }
}
