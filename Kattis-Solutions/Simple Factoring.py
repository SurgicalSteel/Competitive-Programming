def det(a, b, c):
    return (b*b) - 4*a*c

def is_perfect_square(x):
    if x >= 0:
        sr = int(x ** 0.5)
        return (sr * sr == x)
    return False

n = int(input())
for i in range(n):
    sarr = [int(y) for y in input().split(" ")]
    if is_perfect_square(det(sarr[0], sarr[1], sarr[2])):
        print("YES")
    else:
        print("NO")
