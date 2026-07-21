package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

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
	n := readInt()
	w.WriteString(fmt.Sprintf("%d ml gin\n", n*45))
	w.WriteString(fmt.Sprintf("%d ml fresh lemon juice\n", n*30))
	w.WriteString(fmt.Sprintf("%d ml simple syrup\n", n*10))
	if n > 1 {
		w.WriteString(fmt.Sprintf("%d slices of lemon\n", n))
	} else {
		w.WriteString("1 slice of lemon\n")
	}
}
