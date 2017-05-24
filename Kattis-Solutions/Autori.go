package main

import (
	"fmt"
	"strings"
)

func main() {
	var i, r string
	var c []string
	fmt.Scanf("%s", &i)
	c = strings.Split(i, "-")
	r = ""
	for x := 0; x < len(c); x++ {
		r += c[x][0:1]
	}
	fmt.Println(r)
}
