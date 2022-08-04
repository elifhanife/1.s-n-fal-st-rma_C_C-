#include <stdio.h>
int main() {
	int i=0,sayi=1,cift=0,tek=0;
	while (sayi != i) {
		printf("sayi girin:");
		scanf_s("%d", &sayi);
		if (sayi % 2 == 0) {
			cift++;
		}
		else {
			tek++;
		}
		i++;
	}
	printf("Toplam Cift Sayi:%d , Toplam Tek Sayi:%d", cift, tek);
	return 0;
}









	



