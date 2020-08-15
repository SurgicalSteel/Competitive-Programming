package main

import (
    "bufio"
    "fmt"
    "io"
    "os"
    "strconv"
    "strings"
)

// Complete the surfaceArea function below.
func surfaceArea(A [][]int32) int32 {
    
    var w int32 = int32(len(A))
    var h int32 = int32(len(A[0]))
    var res int32 = 0

    if (h==1 && w==1){return 4 * A[0][0] + 2;}

    res += (h*w*2)
    var j int32 = 0 
    var i int32 = 0

    for j=0;j<w;j++{
        for i=0;i<h;i++{
            if j+1 < w {
                res += diff(A[j][i], A[j+1][i])
            }

            if i+1<h{
                res += diff(A[j][i], A[j][i+1])
            }
        }
    }
    i = 0
    j = 0
    for j=0;j<w;j++{
        res+= A[j][0]
        res+= A[j][h-1]
    }

    for i=0;i<h;i++{
        res+= A[0][i]
        res+= A[w-1][i]
    }


    return res

}
func diff(a, b int32)int32{
    if a>b{
        return a-b
    }
    return b-a
}
func main() {
    reader := bufio.NewReaderSize(os.Stdin, 1024 * 1024)

    stdout, err := os.Create(os.Getenv("OUTPUT_PATH"))
    checkError(err)

    defer stdout.Close()

    writer := bufio.NewWriterSize(stdout, 1024 * 1024)

    HW := strings.Split(readLine(reader), " ")

    HTemp, err := strconv.ParseInt(HW[0], 10, 64)
    checkError(err)
    H := int32(HTemp)

    WTemp, err := strconv.ParseInt(HW[1], 10, 64)
    checkError(err)
    W := int32(WTemp)

    var A [][]int32
    for i := 0; i < int(H); i++ {
        ARowTemp := strings.Split(readLine(reader), " ")

        var ARow []int32
        for _, ARowItem := range ARowTemp {
            AItemTemp, err := strconv.ParseInt(ARowItem, 10, 64)
            checkError(err)
            AItem := int32(AItemTemp)
            ARow = append(ARow, AItem)
        }

        if len(ARow) != int(int(W)) {
            panic("Bad input")
        }

        A = append(A, ARow)
    }

    result := surfaceArea(A)

    fmt.Fprintf(writer, "%d\n", result)

    writer.Flush()
}

func readLine(reader *bufio.Reader) string {
    str, _, err := reader.ReadLine()
    if err == io.EOF {
        return ""
    }

    return strings.TrimRight(string(str), "\r\n")
}

func checkError(err error) {
    if err != nil {
        panic(err)
    }
}
