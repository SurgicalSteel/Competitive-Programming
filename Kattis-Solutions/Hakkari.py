if __name__ == "__main__":
    sarr = input().split(" ")
    stemp = ""
    nrow = int(sarr[0])
    ncol = int(sarr[1])
    counter = 0
    arr = []
    for x in range (nrow):
        stemp = input()
        for y in range(ncol):
            if stemp[y] == "*":
                counter += 1
                arr.append(f"{x+1} {y+1}")
    
    print(counter)
    for x in arr:
        print(x)
