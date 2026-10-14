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

func getNormal(x int)int{
    if x >= 24 {
        return x - 24
    }
    return x
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
    
    n := readInt()
    k := readInt()
    
    var start, end int
    
    hourMap := make(map[int]int)
    
    for i:=0;i<n;i++{
        start = readInt()
        end = readInt()
        if end < start{
            end += 24
        }
        
        for x :=start;x<end;x++{
            counter := hourMap[getNormal(x)]
            hourMap[getNormal(x)] = counter + 1
        }
    }
    
    ctr := 0
    for i:=0;i<=24;i++{
        if hourMap[i] >=k{
            ctr++;
        }
    }
    
    fmt.Println(ctr)
}
