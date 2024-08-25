if __name__ == "__main__":
    nf = int(input())
    sarr = []
    maxf = 0
    name = ""
    for x in range(nf):
        sarr = input().split(" ")
        if int(sarr[1]) > maxf:
            name = sarr[0]
            maxf = int(sarr[1])

    print(name)
