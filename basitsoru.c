#include <stdio.h>
int main()
{
	int x;
	printf("lutfen x degerini giriniz:");
	scanf_s("%d", &x);
	if (x < 0)
		printf("islemin sonucu:%f", (1 / x * x));
	else if (x > 0)
		printf("islemin sonucu:%d", x * x);
	else if (x == 0)
		printf("0");

	return 0;

}