if __name__ == "__main__":
    start = int(input())

    sn = set()
    oneFound = start == 1
    next = start
    sn.add(start)
    

    while not oneFound:
        if next%2 == 0:
            next = next/2
        else:
            next = (next *3) + 1
        sn.add(next)

        if next == 1:
            oneFound = True
    
    print(len(sn))
