package main

import (
	"bufio"
	"os"
	"strings"
)

func main() {
	sc := bufio.NewScanner(os.Stdin)
	sc.Buffer(make([]byte, 1<<20), 1<<24)
	sc.Split(bufio.ScanWords)

	w := bufio.NewWriterSize(os.Stdout, 1<<20)
	defer w.Flush()

	sc.Scan()
	str := sc.Text()
	chars := []string{"U", "A", "P", "C"}
	for _, char := range chars {
		if !strings.Contains(str, char) {
			w.WriteString(char)
		}
	}
	w.WriteByte('\n')
}
