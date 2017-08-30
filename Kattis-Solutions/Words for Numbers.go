package main

import (
    "bufio"
    "fmt"
    "os"
    "strconv"
    "strings"
)

var xp, xs map[int]string

func isn(s string) int {
    x, e := strconv.Atoi(s)
    if e != nil {
        return -1
    }
    return x
}
func toi(s string) int {
    x, _ := strconv.Atoi(s)
    return x
}
func upp(s string) string {
    return fmt.Sprintf("%s%s", strings.ToUpper(s[:1]), s[1:])
}
func main() {
    var builder, tbuild string = "", ""
    var tn int
    xp, xs = make(map[int]string), make(map[int]string)
    xs[1], xp[1] = "one", "ten"
    xs[2], xp[2] = "two", "twenty"
    xs[3], xp[3] = "three", "thirty"
    xs[4], xp[4] = "four", "forty"
    xs[5], xp[5] = "five", "fifty"
    xs[6], xp[6] = "six", "sixty"
    xs[7], xp[7] = "seven", "seventy"
    xs[8], xp[8] = "eight", "eighty"
    xs[9], xp[9] = "nine", "ninety"
    xs[0], xp[0] = "zero", "teen"
    reader := bufio.NewReader(os.Stdin)
    for {
        builder = ""
        s, err := reader.ReadString('\n')
        if err != nil {
            break
        }
        arr := strings.Split(s, " ")
        for i := 0; i < len(arr); i++ {
            if i == len(arr)-1 {
                arr[i] = arr[i][:len(arr[i])-1]
            }
            tn = isn(arr[i])
            tbuild = ""
            if tn >= 0 {
                if tn < 10 {
                    tbuild = xs[tn]
                } else if tn%10 == 0 {
                    tbuild = xp[tn/10]
                } else if tn > 10 && tn < 20 {
                    if tn == 11 {
                        tbuild = "eleven"
                    } else if tn == 12 {
                        tbuild = "twelve"
                    } else if tn == 13 {
                        tbuild = "thirteen"
                    } else if tn == 15 {
                        tbuild = "fifteen"
                    } else if tn == 18 {
                        tbuild = "eighteen"
                    } else {
                        tbuild = (xs[toi(arr[i][1:])] + xp[0])
                    }
                } else {
                    tbuild = xp[toi(arr[i][:1])] + "-" + xs[toi(arr[i][1:])]
                }
                if i == 0 {
                    tbuild = upp(tbuild)
                } else {
                    if arr[i-1][(len(arr[i-1]))-1:] == "." {
                        tbuild = upp(tbuild)
                    }
                }
            } else {
                tbuild = arr[i]
            }
            if i == 0 {
                builder += tbuild
            } else {
                builder += (" " + tbuild)
            }
        }
        fmt.Println(builder)
    }
}
