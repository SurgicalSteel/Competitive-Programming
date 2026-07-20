package main

import (
	"bufio"
	"os"
	"sort"
	"strconv"
	"strings"
)

type WordPos struct {
	Word string
	Pos  int
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

	sz := readInt()
	wps := make([]WordPos, sz)
	word := ""
	pos := 0
	for i := 0; i < sz; i++ {
		sc.Scan()
		word = sc.Text()
		pos = readInt()
		wps[i] = WordPos{Word: word, Pos: pos}
	}
	sort.Slice(wps, func(i, j int) bool {
		return wps[i].Pos < wps[j].Pos
	})

	words := make([]string, sz)
	for i := 0; i < sz; i++ {
		words[i] = wps[i].Word
	}

	finalSentence := strings.Join(words, " ")
	w.WriteString(finalSentence)
	w.WriteByte('\n')
}
