if __name__ == "__main__":
    d = dict()
    sarr = []
    nw = int(input())
    s = input()
    ne = int(input())
    for x in range(ne):
        sarr = input().split(" ")
        d[sarr[0]] = sarr[1]
    
    sarr = s.split(" ")
    for x in range(nw):
        sarr[x] = d[sarr[x]]

    print(" ".join(sarr))
