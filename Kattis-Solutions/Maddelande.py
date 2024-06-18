if __name__ == "__main__":
    sarr = input().split()
    nline = int(sarr[0])
    slen = int(sarr[1])
    s = ""
    res = ""
    for x in range(nline):
        s = input()
        for x in range(slen):
            if s[x] != ".":
                res += s[x]

    print(res)
