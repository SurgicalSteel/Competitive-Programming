package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

func verify(arr []int) bool {
	if len(arr) != 9 {
		//fmt.Println("DEBUG : len(arr) != 9")
		return false
	}

	m := make(map[int]int)
	var counter int
	for _, a := range arr {
		counter = m[a]
		counter += 1
		m[a] = counter
	}

	for i := 1; i <= 9; i++ {
		if m[i] != 1 {
			//fmt.Println("DEBUG : i=", i, " m[i]=", m[i])
			return false
		}
	}

	return true
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

	var matrix [][]int
	var temp int
	var arr []int
	var res bool = true
	matrix = make([][]int, 9)

	for j := 0; j < 9; j++ {
		matrix[j] = make([]int, 9)
		for i := 0; i < 9; i++ {
			temp = readInt()
			matrix[j][i] = temp
		}
	}

	//vertical
	for i := 0; i < 9; i++ {
		arr = make([]int, 0)
		for j := 0; j < 9; j++ {
			arr = append(arr, matrix[j][i])
		}
		//if !verify(arr) {
		//fmt.Println("DEBUG : vertical i=", i)
		//}

		res = res && verify(arr)
	}

	//horizontal
	for j := 0; j < 9; j++ {
		arr = make([]int, 0)
		for i := 0; i < 9; i++ {
			arr = append(arr, matrix[j][i])
		}
		//if !verify(arr) {
		//fmt.Println("DEBUG : horizontal j=", j)
		//}
		res = res && verify(arr)
	}

	//box
	// {0, 0} {0, 3} {0, 6}
	// {3, 0} {3, 3} {3, 6}
	// {6, 0} {6, 3} {6, 6}

	for j := 0; j <= 6; j += 3 {
		for i := 0; i <= 6; i += 3 {
			arr = make([]int, 0)
			for y := j; y < j+3; y++ {
				for x := i; x < i+3; x++ {
					arr = append(arr, matrix[y][x])
				}
			}
			//if !verify(arr) {
			//fmt.Println("DEBUG : box j=", j, " i=", i)
			//}
			res = res && verify(arr)
		}
	}

	if res {
		fmt.Println("VALID")
	} else {
		fmt.Println("INVALID!")
	}
}
