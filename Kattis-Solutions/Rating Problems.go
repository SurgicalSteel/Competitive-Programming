package main

import (
	"bufio"
	"os"
	"strconv"
	"fmt"
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

	sz := readInt()
	nr := readInt()
	
	temp, tot := int(0), int(0)
	for i:=0;i<nr;i++{
	    temp = readInt()
	    tot += temp
	}
	
	totmin := tot + ((sz-nr)* -3)
	totmax := tot + ((sz-nr)* 3)
	
	var avemin, avemax float32
	avemin = float32(totmin)/float32(sz)
	avemax = float32(totmax)/float32(sz)
	
	fmt.Printf("%.4f %.4f\n",avemin, avemax)
}
