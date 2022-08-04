#include <stdio.h>
#include <stdlib.h>
#include <time.h> //time() fonksiyonunu iceren kutuphane

int main() {
	int rastgeleSayi = 0, istenensayi;
	int ustSinir;
	int altSinir;
	printf("Alt sinir giriniz:");
	scanf_s("%d", &altSinir);
	printf("Ust sinir giriniz:");
	scanf_s("%d", &ustSinir);
	printf("Istenen sayi giriniz:");
	scanf_s("%d", &istenensayi);
	srand(time(NULL));
	while (rastgeleSayi != istenensayi) {
		rastgeleSayi = (rand() % (ustSinir - altSinir)) + altSinir + 1;
		printf("Uretilen rastgele sayi: %d\n", rastgeleSayi);
		if (rastgeleSayi == istenensayi)
			break;
		printf("Istenen sayi giriniz:");
		scanf_s("%d", &istenensayi);
	}
	printf("Istenen sayi bulundu\n");
	system("pause");
}