import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static BigInteger factorial(int num)
    {
        if(num==1){return BigInteger.valueOf(1);}
        else{return BigInteger.valueOf(num).multiply(factorial(num-1));}
    }
    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner s = new Scanner(System.in);
        int bil = s.nextInt();
        System.out.println(factorial(bil));
    }
}
