def min(a,b):
    if a<b:
        return a
    else:
        return b

if __name__ == "__main__":
    n = int(input())
    md = dict()
    mk = dict()
    str = ""
    for x in range(n):
        str = input()
        if str in md:
            md[str] += 1
        else:
            md[str] = 1
    
    for x in range(n):
        str = input()
        if str in mk:
            mk[str] += 1
        else:
            mk[str] = 1
    
    tot = 0
    for key in md:
        if key in mk:
            tot += min(md[key], mk[key])

    print(tot)
