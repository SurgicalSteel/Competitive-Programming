def maxi(a,b):
    if a >b :
        return a
    else:
        return b

if __name__ == "__main__":
    a = int(input())
    b = int(input())
    c = int(input())
    
    print(maxi(maxi(a,b),c))
