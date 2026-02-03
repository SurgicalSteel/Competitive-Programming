if __name__ == "__main__":
    n = int(input())
    m = set()
    arr = []
    for x in range(n):
        s = input()
        if s not in m:
            arr.append(s)
        m.add(s)
    
    for w in arr:
        print(w)
