package main

import (
    "bufio"
    "fmt"
    "math"
    "os"
    "sort"
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
    sz := readInt()
    posMap := make(map[int]int)
    posDist := make(map[int]int)
    positions := make([]int, sz)
    oripositions := make([]int, sz)
    if sz==1{
        fmt.Println(1)
        return
    }
    for i := 0; i < sz; i++ {
        positions[i] = readInt()
        oripositions[i] = positions[i]
        posMap[positions[i]] = i
    }
    
    sort.Slice(positions, func(i, j int) bool {
        return positions[i] < positions[j]
    })
    currDist := 0
    for i := 0; i < sz; i++ {
        if i == 0 {
            dist := positions[i+1] - positions[i]
            posDist[positions[i]] = dist
            if dist > currDist {
                currDist = dist
            }
        } else if i == (sz - 1) {
            dist := positions[i] - positions[i-1]
            posDist[positions[i]] = dist
            if dist > currDist {
                currDist = dist
            }
        } else if sz > 2 {
            dist := math.Min((float64(positions[i] - positions[i-1])), float64(positions[i+1]-positions[i]))
            posDist[positions[i]] = int(dist)
            if dist > float64(currDist) {
                currDist = int(dist)
            }
        }
    }
    for i := 0; i < sz; i++ {
        if posDist[oripositions[i]] == currDist{
            fmt.Println(i+1)
            return
        }
    }
}
