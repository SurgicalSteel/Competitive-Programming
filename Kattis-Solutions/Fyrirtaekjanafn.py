from sys import stdin, stdout
if __name__ == "__main__":
    s = stdin.readline()
    vs = {"a","i","u","e","o","y","A","I","U","E","O","Y"}
    
    for x in range(len(s)):
        if s[x] in vs:
            stdout.write(s[x])
