int main()
{
	float boy, kilo, vke;
	printf("lutfen boy (m) ve kilo bilgilerinizi girin:");
	scanf_s("%f%f", &boy, &kilo);
	printf("vucut kutle endeksiniz:%.1f", vke = kilo / (boy * boy));
	if (0 <= vke && vke <= 18.4)
		printf("\tzayif");
	else if (18.5 <= vke && vke <= 24.9)
		printf("\tnormal");
	else if (25.0 <= vke && vke <= 29.9)
		printf("\tfazla kilolu");
	else if (30.0 <= vke && vke <= 34.9)
		printf("\tobez-I.sinif");
	else if (35.0 <= vke && vke <= 44.9)
		printf("\tobez-II.sinif");
	else if (vke >= 45.00)
		printf("\tasiri obez");


	return 0;
}