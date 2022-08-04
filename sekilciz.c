#include<stdio.h>
#include <math.h>
#include <stdlib.h>
#include <time.h>
void satirekle() {
	printf("\n");
}
void sekilciz(int n,int m) {
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < m; j++) {
			printf("+");
		}
		satirekle();
	}
}

int main() {
	int m, n;
	srand(time(NULL));
	m = 1 + rand() % 10;
	printf("1-10 arasinda bir sayi girin: ");
	scanf_s("%d", &n);
	printf("secilen sayi:%d idi \n", m);
	sekilciz(n,m);

	return 0;
}