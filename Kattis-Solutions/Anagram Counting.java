import java.util.*;
import java.lang.*;
import java.io.*;
import java.math.*;
/**
 *
 * @author Yuwono Bangun Nagoro
 */
class AnagramCounting {
    static BigInteger factorial(BigInteger n)
    {
        if(n.compareTo(BigInteger.valueOf(1))==0){return BigInteger.valueOf(1);}
        else{return n.multiply(factorial(n.subtract(BigInteger.valueOf(1))));}
    }
    static String solve(String sin)
    {
        HashMap hm=new HashMap();
        for(int x=0;x<sin.length();++x)
        {
            if(hm.containsKey(sin.substring(x,x+1)))
            {
                int ctr=(int) hm.get(sin.substring(x,x+1));
                hm.put(sin.substring(x,x+1), new Integer(ctr+1));
            }
            else{hm.put(sin.substring(x, x+1), new Integer(1));}
        }
        BigInteger lengthin=factorial(BigInteger.valueOf(sin.length()));
        BigInteger siji=BigInteger.valueOf(1);
        Set set = hm.entrySet();
        Iterator i = set.iterator();
        while(i.hasNext()) {
           Map.Entry me = (Map.Entry)i.next();
           siji=siji.multiply(factorial(BigInteger.valueOf((int) me.getValue())));
        }
        lengthin=lengthin.divide(siji);
        return lengthin.toString();
    }
    public static void main (String[] args) throws java.lang.Exception
    {
	Scanner scan = new Scanner(System.in);
        try 
        {
            while (scan.hasNextLine())
            {
                String line = scan.nextLine();
	        System.out.println(solve(line));    
	    }
        } 
        finally 
        {
            if (scan != null)
            {scan.close();}
	}
    }
}
