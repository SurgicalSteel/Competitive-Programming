import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    public static BigInteger addition(String[] a,int size)
    {
        BigInteger sum=BigInteger.valueOf(0);
        BigInteger b;
        for(int i=0;i<size;i++)
        {
            b=new BigInteger(a[i]);
            sum=sum.add(b);
        }
        return sum;
    }
    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner s=new Scanner(System.in);
        int tc=s.nextInt();
        s.nextLine();
        String[] str=new String[tc];
        for(int i=0;i<tc;i++){str[i]=s.nextLine();}
        BigInteger c=addition(str,tc);
        String res=c.toString();
        res=res.substring(0,10);
        System.out.println(res);
    }
}
