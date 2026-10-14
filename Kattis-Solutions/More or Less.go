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
    
    var a,b int
    
    for true{
        a = readInt()
        b = readInt()
        if a == b{
            return
        }else{
            if a > b{
                fmt.Println("More")
            }else{
                fmt.Println("Less")
            }
        }
    }
}
