#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>
int sayi,i,asal=1;

int asalmi(int sayi) {
	 if(sayi<=1) {
	 	asal=0;
	 }
	 else {
	 	for(i=2;i<sayi && asal==1;i++) {
	 		if(sayi%i==0) 
	 		asal=0;
		 }
	 	
	 }
	 return sayi;
}
void islemyap(int sayi) {

	static int a=2;
    a*=2;
	if(asal==0) {
		printf("%d asal degildi ve a ile carpildi= %d ",sayi,sayi*a);
	}
	else  
	printf("%d asaldi ve a ile toplandi= %d ",sayi,sayi+a);

}

 int main() {
 
  	 printf("Bir sayi girin: "); scanf("%d",&sayi);
	 asalmi(sayi);
	islemyap(sayi);
	printf("Bir sayi girin: "); scanf("%d",&sayi);
	islemyap(sayi);
    
}
