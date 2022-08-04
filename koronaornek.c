#include <stdio.h>
int main() {
	int durum,durum1;
	printf("Bugun nasil hissediyorsun?\n(1.cok iyiyim\n2.iyiyim,ama biraz halsizim\n3.iyi hissetmiyorum\n4.halsiz ve hasta hissediyorum\n");
	scanf_s("%d", &durum);
	switch (durum) {
	case 1:
		printf("saglikli gunler dileriz!");
		break;
	case 2:
		printf("sikayetleriniz nelerdir?\n");
		printf("1.yeni baslayan 38 derece uzeri ates\n");
		printf("2.yeni baslayan kuru oksuruk\n");
		printf("3.yeni baslayan nefes darligi\n");
		printf("4.yeni baslayan tat ve koku kaybi\n");
		printf("5.yukaridaki sikayetlerden hepsi ya da birden fazla\n");
		scanf_s("%d", &durum1);
		switch (durum1) {
		case 1:
			printf("kendini takip et semptomlar degisirse testi tekrar yap!!");
			break;
		case 2:
			printf("kendini takip et semptomlar degisirse testi tekrar yap!!");
			break;
		case 3:
			printf("kendini takip et semptomlar degisirse testi tekrar yap!!");
			break;
		case 4:
			printf("maske takarak en yakin saglik kurulusuna basvur!!");
			break;
		case 5:
			printf("maske takarak en yakin saglik kurulusuna basvur!!");
			break;
        }
		break;
	case 3:
		printf("sikayetleriniz nelerdir?\n");
		printf("1.yeni baslayan 38 derece uzeri ates\n");
		printf("2.yeni baslayan kuru oksuruk\n");
		printf("3.yeni baslayan nefes darligi\n");
		printf("4.yeni baslayan tat ve koku kaybi\n");
		printf("5.yukaridaki sikayetlerden hepsi ya da birden fazla\n");
		scanf_s("%d", &durum1);
		switch (durum1) {
		case 1:
			printf("kendini takip et semptomlar degisirse testi tekrar yap!!");
			break;
		case 2:
			printf("kendini takip et semptomlar degisirse testi tekrar yap!!");
			break;
		case 3:
			printf("kendini takip et semptomlar degisirse testi tekrar yap!!");
			break;
		case 4:
			printf("maske takarak en yakin saglik kurulusuna basvur!!");
			break;
		case 5:
			printf("maske takarak en yakin saglik kurulusuna basvur!!");
			break;
		}
		break;
	case 4:
		printf("sikayetleriniz nelerdir?\n");
		printf("1.yeni baslayan 38 derece uzeri ates\n");
		printf("2.yeni baslayan kuru oksuruk\n");
		printf("3.yeni baslayan nefes darligi\n");
		printf("4.yeni baslayan tat ve koku kaybi\n");
		printf("5.yukaridaki sikayetlerden hepsi ya da birden fazla\n");
		scanf_s("%d", &durum1);
		switch (durum1) {
		case 1:
			printf("kendini takip et semptomlar degisirse testi tekrar yap!!");
			break;
		case 2:
			printf("kendini takip et semptomlar degisirse testi tekrar yap!!");
			break;
		case 3:
			printf("kendini takip et semptomlar degisirse testi tekrar yap!!");
			break;
		case 4:
			printf("maske takarak en yakin saglik kurulusuna basvur!!");
			break;
		case 5:
			printf("maske takarak en yakin saglik kurulusuna basvur!!");
			break;
		}
		break;
	}

	return 0;
}










	




