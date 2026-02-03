if __name__ == "__main__":
    d = int(input())
    current = 0
    total = 0
    for x in range(d):
        current += (x+1)
        total += current
    print(current)
    print(total)
