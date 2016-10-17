package main
import "fmt"

func main(){
	// your code goes here
	var it,t,r int;
	fmt.Scanf("%d",&it);
	for x:=0;x<it;x++ {
		fmt.Scanf("%d",&t);
		if(t%400==0){
			r=t/400;
		}else{
			r=((t-(t%400))/400)+1;
		}
		fmt.Println(r);
	}
}
