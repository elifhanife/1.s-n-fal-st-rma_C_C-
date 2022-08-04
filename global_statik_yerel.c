 #include <stdio.h>

x = 5;
int function() {
	static int x = 2;
	x *= x;
	return x;
}

int main() {
	int y;
	printf("Burada global degisken kullanildi: %d\n", x);
	printf("Burada yerel degisken kullanildi: %d\n", function());
	printf("Burada statik degisken kullanildi: %d", function());
}



