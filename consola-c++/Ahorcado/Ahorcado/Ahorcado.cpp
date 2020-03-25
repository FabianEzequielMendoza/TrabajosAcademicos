
#include<iostream>
#include<cstdlib>
#include<cctype>
using namespace std;

string mayusculas(string s);
void dibujoahorcado(int nintentos);
void encontrarcoincidencias(string letraingresada, string palabraazar, string guiones[], float& nintentos);
void palabraoculta(string palabraazar, string guiones[]);
void letrasacumuladas(string& acumletra, string& letraingresada);
void pantallabienvenido();

int main() {
	string acumletra;
	int cantpalabras;
	int i;
	string letraingresada;
	int nazar;
	float nintentos;
	string palabraazar;
	string palabracompleta;
	bool win;
	nintentos = 5;
	win = false;
	string vecpalabra[100];
	

	cout << "Ingrese cantidad de palabras" << endl;
	cin >> cantpalabras;
	
	
	
	for (i = 1; i <= cantpalabras; i++) {
		cout << endl;
		system("cls");
		cout << "Ingrese palabra N " << i << ", sin espacios y tildes..." << endl;
		cin >> vecpalabra[i - 1];
	}
	
	cout << endl; 
	pantallabienvenido();
	nazar = 1 + (rand() % cantpalabras);
	palabraazar = vecpalabra[nazar - 1];
	palabraazar = mayusculas(palabraazar);
	
	string guiones[sizeof(palabraazar)];
	
	dibujoahorcado(nintentos);
	cout << "" << endl;
	palabraoculta(palabraazar, guiones);
	cout << "" << endl;
	do {
		cout << "" << endl;
		cout << "" << endl;
		cout << "Ingrese una letra te quedan " << nintentos << " intento/s" << endl;
		cin >> letraingresada;
		letraingresada = mayusculas(letraingresada);
		letrasacumuladas(acumletra, letraingresada);
		cout << endl;
		system("cls");
		pantallabienvenido();
		cout << "Ingresaste estas Letras: >>> " << acumletra << endl;
		cout << "" << endl;
		encontrarcoincidencias(letraingresada, palabraazar, guiones, nintentos);
		cout << "" << endl;
		dibujoahorcado(nintentos);
		cout << "" << endl;
		for (i = 1; i <= palabraazar.size(); i++) {
			cout << guiones[i - 1];
		}
		palabracompleta = "";
		for (i = 1; i <= palabraazar.size(); i++) {
			palabracompleta = palabracompleta + guiones[i - 1];
			if (palabraazar == palabracompleta) {
				win = true;
			}
		}
	} while (!(nintentos == 0 || win == true));
	cout << "" << endl;
	cout << "" << endl;
	if (win == true) {
		cout << "BIEN AHI! Ganaste el famoso juego del ahorcado,la palabra completa es " << palabraazar << endl;
		cout << "Te esperamos pronto ^^ !" << endl;
	}
	else {
		cout << "Perdiste que lastima :( ,la palabra completa es " << palabraazar << endl;
		cout << "Volve a intentarlo nuevamente, Te esperamos pronto ^^ !" << endl;
	}
	cout << endl;
	system("pause");
	return 0;
}

void dibujoahorcado(int nintentos) {
	switch (nintentos) {
	case 5:
		cout << "" << endl;
		cout << "  #" << endl;
		cout << "" << endl;
		break;
	case 4:
		cout << "" << endl;
		cout << "  #" << endl;
		cout << "  |" << endl;
		cout << "  O" << endl;
		cout << "" << endl;
		break;
	case 3:
		cout << "" << endl;
		cout << "  #" << endl;
		cout << "  |" << endl;
		cout << "  O" << endl;
		cout << "  |" << endl;
		cout << "" << endl;
		break;
	case 2:
		cout << "" << endl;
		cout << "  #" << endl;
		cout << "  |" << endl;
		cout << "  O" << endl;
		cout << " /|\\" << endl;
		cout << "" << endl;
		break;
	case 1:
		cout << "" << endl;
		cout << "  #" << endl;
		cout << "  |" << endl;
		cout << "  O" << endl;
		cout << " /|\\" << endl;
		cout << " / \\" << endl;
		cout << "" << endl;
		break;
	case 0:
		cout << "" << endl;
		cout << "  #" << endl;
		cout << "  |" << endl;
		cout << "  O" << endl;
		cout << "" << endl;
		cout << "" << endl;
		cout << " /|\\" << endl;
		cout << " / \\" << endl;
		cout << "" << endl;
		break;
	}
}

void encontrarcoincidencias(string letraingresada, string palabraazar, string guiones[], float& nintentos) {
	float contador;
	int i;
	float mib;
	contador = 0;
	mib = 0;
	while (mib == 0) {
		for (i = 1; i <= palabraazar.size(); i++) {
			if (letraingresada == palabraazar.substr(i - 1, i - i + 1)) {
				guiones[i - 1] = letraingresada;
				contador = 1;
			}
			if (palabraazar == letraingresada) {
				guiones[i - 1] = letraingresada.substr(i - 1, i - i + 1);
				contador = 1;
			}
			if (palabraazar != letraingresada && letraingresada.size() > 1) {
				nintentos = 0;
				contador = 1;
			}
		}
		if (contador == 0) {
			nintentos = nintentos - 1;
		}
		mib = 1;
	}
}

void palabraoculta(string palabraazar, string guiones[]) {
	int i;
	guiones[0] = palabraazar.substr(0, 1);
	for (i = 2; i <= palabraazar.size(); i++) {
		guiones[i - 1] = " _ ";
	}
	for (i = 1; i <= palabraazar.size(); i++) {
		cout << guiones[i - 1];
	}
}

void letrasacumuladas(string & acumletra, string & letraingresada) {
	float contador;
	int i;
	float mib;
	mib = 0;
	while (mib == 0) {
		contador = 0;
		for (i = 1; i <= acumletra.size(); i++) {
			if (letraingresada == acumletra.substr(i - 1, i - i + 1)) {
				contador = 1;
				i = acumletra.size();
			}
		}
		if (contador == 0) {
			acumletra = acumletra + letraingresada + "-";
			mib = 1;
		}
		else {
			cout << "Atencion!! Ya Ingresaste esa Letra por favor Ingresa otra: " << endl;
			cin >> letraingresada;
			letraingresada = mayusculas(letraingresada);
		}
	}
}

void pantallabienvenido() {
	system("cls");
	cout << ">>>BIENVENIDO AL JUEGO DEL AHORCADO" << endl;
	cout << "" << endl;
	cout << "" << endl;
}


string mayusculas(string s) {
	for (unsigned int i = 0; i < s.size(); i++)
		s[i] = toupper(s[i]);
	return s;
}

