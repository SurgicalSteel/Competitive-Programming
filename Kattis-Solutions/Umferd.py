if __name__ == "__main__":
    nc = int(input())
    nr = int(input())
    s = ""
    te = 0 
    ta = nc * nr
    for x in range(nr):
        s = input()
        for y in range(nc):
            if s[y] == ".":
                te += 1

    print(te/ta)
