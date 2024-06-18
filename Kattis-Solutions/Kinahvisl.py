if __name__ == "__main__" :
    sa = input()
    sb = input()

    ndiff = 0

    for x in range(len(sa)):
        if sa[x] != sb[x]:
            ndiff += 1
    
    if ndiff == 0 :
        print(1)
    else:
        print(ndiff+1)
