package main

import "fmt"

func main() {
	var (
		price, tmpW, tmpH, tot float64
		ng                     int
	)
	tot = 0
	fmt.Scanf("%f", &price)
	fmt.Scanf("%d", &ng)
	for i := 0; i < ng; i++ {
		fmt.Scanf("%f %f", &tmpW, &tmpH)
		tot += (tmpW * tmpH * price)
	}
	fmt.Printf("%.7f\n", tot)
}
