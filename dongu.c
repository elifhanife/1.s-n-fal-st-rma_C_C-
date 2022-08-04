#include <stdio.h>
int main() {
	int i = 1, n = 0, tek = 0, cift = 0;
	printf("n degerini girin: ");
	scanf_s("%d", &n);
	for (; i <= n; i++) {
		if (i % 7 == 0 && i % 5 == 0) {
			if (i % 2 == 1) {
				if (i == 35) {
					printf("\n%d sayisi tektir ve 5 ve 7 nin EKOK udur\n", i);
					tek++;
				}
				else {
					printf("%d tektir\n", i);
					tek++;
				}
			}
			else {
				printf("%d cifttir\n", i);
				cift++;
			}
		}
		else
			continue;
	}
	printf("\n");
	printf("[1-%d] araliginda 5 ve 7 ye bolunen %d tek sayi vardir\n", n, tek);
	printf("[1-%d] araliginda 5 ve 7 ye bolunen %d cift sayi vardir\n", n, cift);

	return 0;
}
