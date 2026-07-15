if __name__ == "__main__":
    arr_input = input().split(" ")
    initial = int(arr_input[0])
    n = int(arr_input[1])
    arr_input = input().split(" ")
    s = int(arr_input[0])
    f = int(arr_input[1])
    i = int(arr_input[2])
    l = int(arr_input[3])
    for j in range(n):
        raw_input = input()
        if raw_input == "standard":
            initial -= s
        elif raw_input == "fire":
            initial -= f
        elif raw_input == "ice":
            initial -= i
        elif raw_input == "light":
            initial -= l

    if initial > 0:
        print(str(initial))
    else:
        print("dead")
