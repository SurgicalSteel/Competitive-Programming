if __name__ == "__main__":
    counter = 0
    temp = 0
    np = int(input())
    for x in range(np):
        temp = int(input())
        if temp%2 == 1:
            counter += 1
    print(counter)
