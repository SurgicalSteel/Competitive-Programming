package main

import "fmt"

func mini(x int, y int) int {
	if x < y {
		return x
	}
	return y
}

func main() {
	var x, y int
	fmt.Scanf("%d %d", &x, &y)
	if x == y {
		fmt.Println(x + 1)
	} else {
		if x == mini(x, y) {
			for i := x + 1; i <= y+1; i++ {
				fmt.Println(i)
			}
		} else {
			for i := y + 1; i <= x+1; i++ {
				fmt.Println(i)
			}
		}
	}
}
