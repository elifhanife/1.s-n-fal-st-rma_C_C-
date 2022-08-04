#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
	printf("64'un karekoku: %f\n", sqrt(64.0));
	printf("e'nin ucuncu kuvveti: %f\n", exp(3.0));
	printf("Logaritma e tabaninda 2.718282: %f\n", log(2.718282));
	printf("Logaritma 10 tabaninda 100.0: %f\n", log10(100.0));
	printf("|-5.67|: %f\n", fabs(-5.67));
	printf("|-5|: %d\n", abs(-5));
	printf("8.34'un yukari yuvarlanma sonucu: %f\n", ceil(8.34));
	printf("-8.34'un yukari yuvarlanma sonucu: %f\n", ceil(-8.34));
	printf("8.34'un asagiya yuvarlanma sonucu: %f\n", floor(8.34));
	printf("-8.34'un asagiya yuvarlanma sonucu: %f\n", floor(-8.34));
	printf("5.0 uzeri 9.0: %f\n", pow(5.0, 9.0));
	printf("4.9'nin 1.2'ye bolumunden kalan: %f\n", fmod(4.9, 1.2));
	printf("Sinus 45: %f\n", sin(45.0 * (3.142 / 180.0)));
	printf("Kosinus 45: %f\n", cos(45.0 * (3.142 / 180.0)));
	printf("Tanjant 45: %f\n", tan(45.0 * (3.142 / 180.0)));
	system("pause");

	int x = 0, y;
	int sonuc = 1;
	printf("X degerini giriniz:");
	scanf_s("%d", &x);
	printf("Y degerini giriniz:");
	scanf_s("%d", &y);
	sonuc = pow(x, y);
	printf("X'in Y kuvveti: %d\n", sonuc);
	system("pause");
	return 0;
}