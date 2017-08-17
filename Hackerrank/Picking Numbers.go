package main
import "fmt"

func maxi(a,b int) int{
    if a>b{
        return a
    }else{
        return b
    }
}

func main() {
    var m map[int]int
    m= make(map[int]int)
    var sz,t,mm,rm,tm int
    mm=0
    rm=0
    fmt.Scanf("%d",&sz)
    for i:=0;i<sz;i++{
        fmt.Scanf("%d",&t)
        mm=maxi(mm,t)
        if _,ok := m[t];ok{
            m[t]++
        } else {
            m[t]=1
        }
    }
    for i:=1;i<sz;i++{
        tm=0
        if _,ok:=m[i];ok{
            tm+=m[i]
            if _,ok:=m[i+1];ok{
                tm+=m[i+1]
            }
        }
        rm=maxi(tm,rm)
    }
    fmt.Println(rm)
}
