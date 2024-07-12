if __name__=="__main__":
    sarr = input().split(' ')
    nq = int(sarr[0])
    tot = int(sarr[1])
    temp = 0
    tt = 0
    for x in range(nq):
        temp = int(input())
        tt += temp
    
    if tt > tot:
        print("Neibb")
    else:
        print("Jebb")
