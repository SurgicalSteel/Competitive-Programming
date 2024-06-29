if __name__ == "__main__":
    nq = int(input())
    d = dict()
    sarr = []
    tempc = 0
    tmaxi = 0
    tname = ""
    for x in range(nq):
        sarr = input().split(' ')
        if sarr[0] in d:
            tempc = d[sarr[0]]
            tempc += int(sarr[1])
            
        else:
            tempc = int(sarr[1])
        
        d[sarr[0]] = tempc

    for key in d.keys():
        if d[key] > tmaxi :
            tmaxi = d[key]
            tname = key
    
    print(tname)

