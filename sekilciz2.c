#include <stdio.h>

int islemYap(int sayi) {
	for (int i = sayi; i > 0; i--) {
		if (i % 2 == 0) {
			for (int j = 0; j < i; j++)
				printf("*");
		}
		else {
			for (int k = 0; k < i; k++)
				printf("+");
		}
		printf("\n");
	}
	printf("\n");
}
int main() {
	int sayi;
	printf("sayi girin: ");
	scanf_s("%d",&sayi);
	islemYap(sayi);
}