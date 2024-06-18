import string

if __name__ == "__main__":
    lo = list(string.ascii_lowercase)
    up = list(string.ascii_uppercase)

    alle = set()

    for x in lo:
        alle.add(str(x))

    for x in up:
        alle.add(str(x))

    counter = 0
    s = input()

    for x in range(len(s)):
        if s[x] in alle:
            counter += 1 

    print(counter)
