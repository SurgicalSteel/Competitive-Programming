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

	pa := readInt()
	pb := readInt()

	finalResult := powerOfTwo(4 - countSameDigits(pa, pb))
	w.WriteString(strconv.Itoa(finalResult))
	w.WriteByte('\n')

}

func countSameDigits(a, b int) int {
	sa := fmt.Sprintf("%04d", a)
	sb := fmt.Sprintf("%04d", b)
	count := 0
	for i := 0; i < 4; i++ {
		if sa[i] == sb[i] {
			count++
		}
	}
	return count
}

func powerOfTwo(n int) int {
	if n == 0 {
		return 1
	}
	return 2 * powerOfTwo(n-1)
}
