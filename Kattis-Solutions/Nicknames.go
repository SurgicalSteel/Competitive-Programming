package main

import (
	"bufio"
	"os"
	"strconv"
)

type Node struct {
	children map[byte]*Node
	count    int
}

func newNode() *Node {
	return &Node{children: make(map[byte]*Node)}
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

	root := newNode()

	nWords := readInt()
	for i := 0; i < nWords; i++ {
		sc.Scan()
		word := sc.Bytes()
		node := root
		for _, ch := range word {
			child, ok := node.children[ch]
			if !ok {
				child = newNode()
				node.children[ch] = child
			}
			node = child
			node.count++
		}
	}

	nQueries := readInt()
	for i := 0; i < nQueries; i++ {
		sc.Scan()
		prefix := sc.Bytes()
		node := root
		count := 0
		ok := true
		for _, ch := range prefix {
			child, exists := node.children[ch]
			if !exists {
				ok = false
				break
			}
			node = child
		}
		if ok {
			count = node.count
		}
		w.WriteString(strconv.Itoa(count))
		w.WriteByte('\n')
	}
}
