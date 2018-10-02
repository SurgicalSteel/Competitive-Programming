package main

import (
	"bufio"
	"fmt"
	"os"
	"strings"
)

func main() {
	reader := bufio.NewReader(os.Stdin)
	s, _ := reader.ReadString('\n')
	ss := strings.Split(s, " ")
	tot := len(ss)
	ctr := int(0)
	for _, v := range ss {
		if strings.Contains(v, "ae") {
			ctr++
		}
	}
	p := float64(0)
	p = (float64(ctr) / float64(tot)) * 100
	if p >= 40 {
		fmt.Println("dae ae ju traeligt va")
	} else {
		fmt.Println("haer talar vi rikssvenska")
	}
}
