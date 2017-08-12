package main
import "fmt"

func main() {
    var om map[string]int
    var na,nb int
    var s string
    var as []string
    as=make([]string,0)
    valid:=true
    om=make(map[string]int)
    fmt.Scanf("%d",&na)
    fmt.Scanf("%d",&nb)
    for i:=0;i<na;i++{
        fmt.Scanf("%s",&s)
        if _,ok:=om[s];ok{
            om[s]++
        }else{
            om[s]=1
        }
    }
    for i:=0;i<nb;i++{
        fmt.Scanf("%s",&s)
        as=append(as,s)
    }
    
    for i:=0;i<nb;i++{
        if _,ok:=om[as[i]];ok{
            if om[as[i]]>0{
                om[as[i]]--
            }else{
                valid =false
                break
            }
        }else{
            valid=false
        }
    }
    if valid{
        fmt.Printf("Yes\n")
    }else{
        fmt.Printf("No\n")
    }
    
}
