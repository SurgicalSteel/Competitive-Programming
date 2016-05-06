package sieve_of_eratosthenes;
import java.util.ArrayList;
import java.util.Scanner;
/**
 *
 * @author Yuwono Bangun Nagoro
 */
public class Sieve_of_Eratosthenes {
    static void sieve(int n)
    {
        int sza=n-1;
        int arr[] = new int[sza];
        ArrayList res=new ArrayList();
        for(int i=0;i<sza;i++){arr[i]=i+2;}
        int currprime=1,ctr=0,ptr=0;
        while(ctr<sza)
        {
            if(arr[ptr]!=-1)
            {
                currprime=arr[ptr];
                arr[ptr]=-1;
                res.add(currprime);
                ctr++;
            }
            else
            {
                int x=ptr;
                boolean breaker=false;
                while(!breaker&&x<sza)
                {
                    if(arr[x]!=-1){ptr=x;breaker=true;}
                    else{x++;}
                }
                if(arr[ptr]!=-1)
                {
                    currprime=arr[ptr];
                    arr[ptr]=-1;
                    res.add(currprime);
                    ctr++;
                }
            }
            int i=ptr;
            while(i<sza)
            {
                if(i!=ptr&&arr[i]!=-1)
                {
                    arr[i]=-1;
                    ctr++;
                }
                i+=currprime;
            }
        }
        for(int i=0;i<res.size();i++){System.out.println(res.get(i));}
    }
    public static void main(String[] args) {
        System.out.println("Enter a limit number n (n>=2)");
        Scanner sc=new Scanner(System.in);
        int n =sc.nextInt();
        if(n>=2)
        {
            System.out.println("The prime numbers <="+n+" are:");
            sieve(n);
        }
        else{System.out.println("Invalid number for n!");}
    }
}
