package main

import (
    "bufio"
    "fmt"
    "os"
    "strings"
)

func main() {
    var s string
    reader := bufio.NewReader(os.Stdin)
    s, _ = reader.ReadString('\n')
    s = strings.Trim(s, " ")
    if strings.Contains(s, ":)") {
        if strings.Contains(s, ":(") {
            fmt.Println("double agent")
        } else {
            fmt.Println("alive")
        }
    } else if strings.Contains(s, ":(") {
        fmt.Println("undead")
    } else {
        fmt.Println("machine")
    }
}
