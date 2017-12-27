package main

import (
    "fmt"
    "math"
)

func getDiagonal(x, y int) float64 {
    return math.Sqrt(float64(x*x + y*y))
}

func main() {
    var tc,w,h,x int
    fmt.Scanf("%d",&tc)
    fmt.Scanf("%d",&w)
    fmt.Scanf("%d",&h)
    d := getDiagonal(w, h)
    for i := 0; i < tc; i++ {
        fmt.Scanf("%d",&x)
        if float64(x) > d {
            fmt.Println("NE")
        } else {
            fmt.Println("DA")
        }
    }
} 
