package main

import (
    "bufio"
    "os"
    "fmt"
    "strconv"
    "strings"
)

type Address struct{
    Street string
    No int
}

func buildSingleItemUp(a Address)string{
    return fmt.Sprintf("'%s %d'", a.Street, a.No)
}

func buildMultipleItemsUp(arr []Address)string{
    if len(arr) == 0{
        return "[]"
    }
    
    multi := make([]string, len(arr))
    for i, a := range arr{
        multi[i] = buildSingleItemUp(a)
    }
    
    return "[" + strings.Join(multi, ", ") + "]"
}

func buildSingleItemDown(a Address)string{
    return fmt.Sprintf("('%s', '%d')", a.Street, a.No)
}

func buildMultipleItemsDown(arr []Address)string{
    if len(arr) == 0{
        return "[]"
    }
    
    multi := make([]string, len(arr))
    for i, a := range arr{
        multi[i] = buildSingleItemDown(a)
    }
    
    return "[" + strings.Join(multi, ", ") + "]"
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
    
    var str string
    var no int
    var addressList []Address
    for true {
        sc.Scan()
        str = sc.Text()
        if str == "q"{
            fmt.Println(buildMultipleItemsUp(addressList))
            fmt.Println(buildMultipleItemsDown(addressList))
            break
        }else{
            no = readInt()
            addressList = append(addressList, Address{Street : str, No: no})
        }
    }
    
}
