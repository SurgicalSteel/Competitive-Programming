package main

import (
	"fmt"
)

func main() {
	var (
		tc int
		x  int
	)
	fmt.Scanf("%d", &tc)
	for i := 0; i < tc; i++ {
		fmt.Scanf("%d", &x)
		if x%5 >= 0 && x%5 < 3 {
			fmt.Println(x)
		} else {
			if (x + (5 - (x % 5))) >= 40 {
				x += (5 - (x % 5))
			}
			fmt.Println(x)
		}
	}
}
