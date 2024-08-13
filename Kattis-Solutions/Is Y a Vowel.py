if __name__ == "__main__":
    s = input()
    vowels = {'a','i','u','e','o'}
    sny=0
    sy=0
    for x in range(len(s)):
        if s[x] in vowels:
            sny += 1
            sy += 1
        elif s[x] == "y":
            sy += 1

    print(f"{sny} {sy}")
