package main

import (
	"bufio"
	"fmt"
	"os"
	"sort"
	"strings"
)

type wordo struct {
	usedcount int
	isusedall bool
	word      string
}
type wordos []wordo

func (w wordos) Len() int      { return len(w) }
func (w wordos) Swap(i, j int) { w[i], w[j] = w[j], w[i] }
func (w wordos) Less(i, j int) bool {
	if w[i].usedcount > w[j].usedcount {
		return true
	} else if w[i].usedcount < w[j].usedcount {
		return false
	} else {
		return w[i].word < w[j].word
	}
}
func main() {
	var n int
	var stemp string
	m := make(map[string]map[string]int)
	bow := make(map[string]wordo)
	allwordo := make([]wordo, 0)
	fmt.Scanf("%d", &n)
	reader := bufio.NewReader(os.Stdin)
	for i := 0; i < n; i++ {
		stemp, _ = reader.ReadString('\n')
		stemp = strings.TrimSpace(stemp)
		sarr := strings.Split(stemp, " ")
		if len(sarr) == 0 {
			break
		}
		if _, ok := m[sarr[0]]; !ok {

			m[sarr[0]] = make(map[string]int)
			for j := 1; j < len(sarr); j++ {
				if _, ok2 := m[sarr[0]][sarr[j]]; ok2 {
					m[sarr[0]][sarr[j]]++
				} else {
					m[sarr[0]][sarr[j]] = 1
				}
				if _, okbow := bow[sarr[j]]; !okbow {
					bow[sarr[j]] = wordo{
						word:      sarr[j],
						isusedall: true,
						usedcount: 1,
					}
				} else {
					tsbow := bow[sarr[j]]
					tsbow.usedcount++
					bow[sarr[j]] = tsbow
				}
			}

		} else {

			for j := 1; j < len(sarr); j++ {
				if _, ok2 := m[sarr[0]][sarr[j]]; ok2 {
					m[sarr[0]][sarr[j]]++
				} else {
					m[sarr[0]][sarr[j]] = 1
				}
				if _, okbow := bow[sarr[j]]; !okbow {
					bow[sarr[j]] = wordo{
						word:      sarr[j],
						isusedall: true,
						usedcount: 1,
					}
				} else {
					tsbow := bow[sarr[j]]
					tsbow.usedcount++
					bow[sarr[j]] = tsbow
				}
			}

		}
	}
	for _, vbow := range bow {
		useall := true
		for km, _ := range m {
			currentpm := m[km]
			if _, okpw := currentpm[vbow.word]; !okpw {
				useall = false
			}
		}
		vbow.isusedall = useall
		if useall {
			allwordo = append(allwordo, vbow)
		}
	}
	sort.Sort(wordos(allwordo))
	if len(allwordo) > 0 {
		for i := 0; i < len(allwordo); i++ {
			fmt.Println(allwordo[i].word)
		}
	} else {
		fmt.Println("ALL CLEAR")
	}
}
