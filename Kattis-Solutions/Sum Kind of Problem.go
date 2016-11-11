package main

import "fmt"

func solve(no int, x int) {
	var nall, nev, nod int
	nall = 0
	nev = 0
	nod = 0
	for c := 1; c <= x; c++ {
		nall += c
	}
	var ctrev, ctrodd int
	ctrev = 0
	ctrodd = 0
	var i int = 0
	for ctrev = 0; ctrev <= x; {
		if i%2 == 0 {
			nev += i
			ctrev++
		}
		i += 2
	}
	i = 1
	for ctrodd = 0; ctrodd < x; {
		if i%2 != 0 {
			ctrodd++
			nod += i
		}
		i += 2
	}
	fmt.Println(no, nall, nod, nev)
}
func main() {
	var ntc, nno, nnum int
	fmt.Scanf("%d", &ntc)
	for x := 0; x < ntc; x++ {
		fmt.Scanf("%d %d", &nno, &nnum)
		solve(nno, nnum)
	}
}
