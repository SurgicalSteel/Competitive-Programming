#include <cstdio>

int main() {
    int size;
    if (scanf("%d", &size) != 1) return 0;

    long long lastLarge = -200001;
    bool first = true;

    for (int i = 0; i < size; ++i) {
        int x;
        if (scanf("%d", &x) != 1) break;

        if (i == 0 || x >= lastLarge) {
            if (!first) putchar(' ');
            printf("%d", x);
            first = false;
            if (x > lastLarge) lastLarge = x;
        }
    }
    putchar('\n');
    return 0;
}
