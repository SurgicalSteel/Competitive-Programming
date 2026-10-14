package main

import (
    "bufio"
    "fmt"
    "os"
)

func main() {
    sc := bufio.NewScanner(os.Stdin)
    sc.Buffer(make([]byte, 1<<20), 1<<24)
    sc.Split(bufio.ScanWords)

    if !sc.Scan() {
        return
    }
    fileA := sc.Text()

    if !sc.Scan() {
        return
    }
    fileB := sc.Text()

    i, j := 0, 0
    for i < len(fileA) && j < len(fileB) {
        if fileA[i] == fileB[j] {
            i++
        }
        j++
    }

    if i == len(fileA) {
        fmt.Println("Ja")
    } else {
        fmt.Println("Nej")
    }
}
