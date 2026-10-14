package main

import (
    "bufio"
    "fmt"
    "os"
    "strconv"
)

func maxint(a,b int)int{
    if a>b{
        return a
    }
    return b
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
    
    allmax := 0
    curr := 0
    
    var a,b int
    
    sz := readInt()
    for i:=0;i<sz;i++{
        a = readInt()
        b = readInt()
        curr += (b-a)
        allmax = maxint(allmax, curr)
    }
    fmt.Println(allmax)
}
