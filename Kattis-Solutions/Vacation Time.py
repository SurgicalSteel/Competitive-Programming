import heapq

if __name__ == "__main__":
    splitted_input = input().split(" ")
    nAirports = int(splitted_input[0])
    nFlights = int(splitted_input[1])

    flights = []
    for i in range(nFlights):
        raw_input = input()
        splitted_input = raw_input.split(" ")
        # append source airport, destination airport, cost, and  plane type
        flights.append((int(splitted_input[0]), int(splitted_input[1]), int(splitted_input[2]), splitted_input[3]))

    # Build adjacency list from the directed flights.
    adj = [[] for _ in range(nAirports)]
    for src, dst, cost, plane in flights:
        adj[src].append((dst, cost, plane == "A380"))

    # Dijkstra over a doubled state space:
    #   state 0 -> the route has not used an A380 flight yet
    #   state 1 -> the route has already used at least one A380 flight
    # Taking an A380 flight moves state 0 -> 1; state 1 stays 1.
    INF = float("inf")
    dist = [[INF, INF] for _ in range(nAirports)]
    dist[0][0] = 0
    pq = [(0, 0, 0)]  # (cost so far, airport, state)

    while pq:
        d, u, s = heapq.heappop(pq)
        if d > dist[u][s]:
            continue
        for v, cost, is_a380 in adj[u]:
            ns = s | (1 if is_a380 else 0)
            nd = d + cost
            if nd < dist[v][ns]:
                dist[v][ns] = nd
                heapq.heappush(pq, (nd, v, ns))

    # We need a route that used an A380 at least once => state 1 at the target.
    answer = dist[nAirports - 1][1]
    print(answer if answer != INF else -1)
