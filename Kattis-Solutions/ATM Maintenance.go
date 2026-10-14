package main

import (
    "bufio"
    "fmt"
    "os"
    "strconv"
)

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
    
    var n,k,t int
    
    n = readInt()
    k = readInt()
    res := ""
    
    for i:=0;i<n;i++{
        t = readInt()
        if t <= k{
            k -= t
            res += "1"
        }else{
            res += "0"
        }
    }
    
    fmt.Println(res)
}
