package main
import "fmt"

func main(){
	var sz int=1000
	var arr = make([]int,sz)
	for x:=0;x<sz-1;x++{
		arr[x]=x+2
	}
	var check int=0
	for check<sz-1{
		var iter int =0
		for iter<sz-1{
			if arr[iter]!=-1{
				check++
				var it int=iter
				for it<sz-1{
					if it!=iter&&arr[it]%arr[iter]==0&&arr[it]!=-1{
						arr[it]=-1
						check++
					}
					it+=arr[iter]
				}
			}
			iter++
		}
	}
	for x:=0;x<sz-1;x++{
		if arr[x]!=-1{
			fmt.Println(arr[x])
		}
	}
}
