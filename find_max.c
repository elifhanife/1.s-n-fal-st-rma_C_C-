#include <stdio.h>

int func() {
	int sayi, i, max = 0;
	printf("0 ve 10.000 arasinda 100 sayi girin! \n");
	for (i = 0; i < 100; i++) {
		printf("%d. sayiyi girin: ", i + 1);
		scanf_s("%d", &sayi);
		if (sayi > max) {
			max = sayi;
		}
	}

	return max;
}



int main() {
	int a;
	a = func();
	printf("En buyuk sayi: %d", a);
}