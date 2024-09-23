def getKey(tr, tc):
    return str(tr)+":"+str(tc)

if __name__ == "__main__":
    sarr = input().split(' ')
    nr = int(sarr[0])
    nc = int(sarr[1])
    nb = int(sarr[2])

    tr = 0
    tc = 0
    d = dict()
    temps = ""

    for x in range(nb):
        sarr = input().split(' ')
        tr =int(sarr[0]) - 1
        tc = int(sarr[1]) - 1
        d[getKey(tr,tc)]=1
    
    for x in range(nr):
        # x is row
        temps = ""
        for y in range(nc):
            if getKey(x,y) in d :
                temps += "*"
            else:
                temps += "."
        print(temps)
