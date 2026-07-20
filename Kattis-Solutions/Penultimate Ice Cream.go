package main

import (
	"bufio"
	"container/heap"
	"os"
	"strconv"
)

// IntegerHeap defines a custom slice type for our heap.
type IntegerHeap []int

// 1. Len returns the total number of elements in the heap.
func (h IntegerHeap) Len() int {
	return len(h)
}

// 2. Less determines the ordering.
// For a Min-Heap, use '<'. For a Max-Heap, flip it to '>'.
func (h IntegerHeap) Less(i, j int) bool {
	return h[i] > h[j]
}

// 3. Swap exchanges the elements at the given indexes.
func (h IntegerHeap) Swap(i, j int) {
	h[i], h[j] = h[j], h[i]
}

// 4. Push appends a new element to the underlying slice.
// Note: This takes an 'any' (interface{}) type and uses a pointer receiver.
func (h *IntegerHeap) Push(x any) {
	*h = append(*h, x.(int))
}

// 5. Pop removes and returns the last element of the underlying slice.
// Note: The container/heap package handles swapping the root to the end first.
func (h *IntegerHeap) Pop() any {
	old := *h
	n := len(old)
	item := old[n-1]
	*h = old[0 : n-1]
	return item
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
	intHeap := &IntegerHeap{}
	for i := 0; i < sz; i++ {
		num := readInt()
		heap.Push(intHeap, num)
	}
	heap.Init(intHeap)

	//get the second highest number
	heap.Pop(intHeap) // Remove the highest
	secondHighest := heap.Pop(intHeap).(int)
	w.WriteString(strconv.Itoa(secondHighest))
	w.WriteByte('\n')
}
