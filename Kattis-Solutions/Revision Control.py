if __name__ == "__main__":
    num = int(input())
    d = dict()
    ares = []
    arin = input().split(" ")
    for x in range(num):
        if arin[x] in d.keys():
            ares.append("0")
        else:
            d[arin[x]] = 1
            ares.append("1")
    print(" ".join(ares))
