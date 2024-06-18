if __name__ == '__main__':
    sarr = input().split()

    sz = int(sarr[0])
    target = int(sarr[1])
    sarr = input().split()
    temp = int(0)
    res = ""
    for x in range(sz):
        temp = int(sarr[x])
        if temp == target :
            if  (x + 1) == 1 :
                res = "fyrst"
            elif (x+1) == 2 :
                res = "naestfyrst"
            else :
                res = f"{x+1} fyrst"

    print(res)
