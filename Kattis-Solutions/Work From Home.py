import math


if __name__ == "__main__":
    watt = int(input())
    minutes = int(input())
    per_kwh_cost = int(input())
    total_cost = math.ceil((watt * minutes * per_kwh_cost) / 6000000)
    print(int(total_cost))
