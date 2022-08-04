#include <stdio.h>

float aOrt() {
	int sayi,toplam=0,i,adet=0;
	float sonuc;
	for (i = 1; i <= 10; i++) {
		printf("%d. sayiyi girin: ",i);
		scanf_s("%d", &sayi);
		toplam += sayi;
		adet++;
	}
	sonuc = toplam / adet;
	return sonuc;
}

int main() {
	printf("A.Ort= %.2f",aOrt());
	return 0;
}