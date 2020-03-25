// ConsoleApplication4.cpp: define el punto de entrada de la aplicación de consola.
//

//#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;


int main()
{
	int cantPalabras, contador, numAleatorio, longitudPalabra;
	string vectorPalabras[100], palabra, palabraIncognita;
	
	cout << "ingrese cantidad de palabras" << endl;
	cin >> cantPalabras;
	contador = cantPalabras;
	system("cls");
	for (int i = 0; i < cantPalabras; i++)
	{
		cout << "ingrese " << contador << " palabra/s" << endl;
		cin >> vectorPalabras[i];
		contador--;
		system("cls");
	}
	//se selecciona una palabra al azar y se la guarda en la variable palabra
	numAleatorio = 1 + rand() % (cantPalabras - 1);
	palabra = vectorPalabras[numAleatorio];
    
	//Longitud de palabra
		
	longitudPalabra = palabra.length();
	//se carga la palabra incognita
	
	palabraIncognita.insert(longitudPalabra, '_');
	palabraIncognita.insert(0, palabra, 0, 1);
	palabraIncognita.insert(longitudPalabra, palabra, longitudPalabra, 1);
	/*for (int i = 1; i < longitudPalabra - 1; i++)
	{
	palabraIncognita.substr(i, 1) = "a";
	}
	palabraIncognita.substr(longitudPalabra, 1) = palabra.substr(longitudPalabra, 1);*/
	cout << "La palabra incognita es: " << palabraIncognita<<endl;
	return 0;
	system("pause");
}


