if __name__ == "__main__":
    s = input()
    cidx = []
    for i in range(len(s)):
        if s[i:i+1] == "c":
            cidx.append(i)
    
    counter = 0
    for i in cidx:
        if i+9 <= len(s):
            if s[i:i+9] == "certainly":
                counter +=1
                
    print(counter)
