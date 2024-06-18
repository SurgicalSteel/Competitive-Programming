if __name__ == "__main__":
    sarr = input().split(" ")
    nl = int(sarr[0])
    nc = int(sarr[1])

    nd = 0
    cset = set()
    for x in range(nl):
        cset.clear()
        sarr = input().split(" ")
        for x in sarr:
            if x not in cset:
                cset.add(x)
            else:
                nd += 1
    
    print(nd)
