package main
import "fmt"

func main(){
    var i int
    fmt.Scanf("%d", &i)
    if i%2==1{
        fmt.Println("Alice")
    }else{
        fmt.Println("Bob")
    }
}
