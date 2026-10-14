package main

import (
    "bufio"
    "fmt"
    "os"
    "strconv"
)

func goUp(x int)int{
    return x + ((2*x) + 1)
}

func goDown(x int)int{
    return x/2
}

func isEven(x int)bool{
    return x%2 == 0
}

func main() {
    sc := bufio.NewScanner(os.Stdin)
    sc.Buffer(make([]byte, 1<<20), 1<<24)
    sc.Split(bufio.ScanWords)

    w := bufio.NewWriterSize(os.Stdout, 1<<20)
    defer w.Flush()

    readInt := func() int {
        sc.Scan()
        n, _ := strconv.Atoi(sc.Text())
        return n
    }
    
    x := readInt()
    numOps := 0
    for true{
        if x ==1{
            break
        }else {
            if isEven(x){
                x = goDown(x)
                numOps++
            }else{
                x = goUp(x)
                numOps++
            }
            
        }
    }
    
    fmt.Println(numOps)
}
