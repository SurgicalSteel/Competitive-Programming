package main

import "fmt"

type light struct {
	pos, red, green int
}

func absolutey(x int) int {
	if x < 0 {
		return x * -1
	} else {
		return x
	}
}
func main() {
	var nl, l, tm, progdist, currl int
	fmt.Scanf("%d %d", &nl, &l)
	col := make([]light, nl)
	for i := 0; i < nl; i++ {
		fmt.Scanf("%d %d %d", &col[i].pos, &col[i].red, &col[i].green)
	}
	progdist = 0
	currl = 0
	tm = 0
	for progdist < l {
		if currl < nl && progdist == col[currl].pos {
			if (tm % (col[currl].red + col[currl].green)) < col[currl].red {
				tm += absolutey(col[currl].red - (tm % (col[currl].red + col[currl].green)))
			} else {
				tm++
				progdist++
			}
			currl++
		} else {
			tm++
			progdist++
		}
	}
	fmt.Printf("%d\n", tm)
}
