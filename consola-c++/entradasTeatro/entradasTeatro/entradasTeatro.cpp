// ConsoleApplication11.cpp: define el punto de entrada de la aplicación de consola.
//

//#include "stdafx.h"
#include <string>
#include <iomanip>
#include <iostream>

using namespace std;

const int _filas = 3;
const int _asientos = 6;

//muestra el menu y pide una opcion a ingresar ---> devuelve el valor de la opcion
int funcionMenu() {
	int opcion;
	system("cls");
	cout << "1- Venta de entradas" << endl;
	cout << "2- Anular Venta" << endl;
	cout << "3- Ver ocupacion" << endl;
	cout << "4- Salir" << endl;
	cout << endl;
	cout << "Ingrese la Opcion" << endl;
	cin >> opcion;

	return opcion;
}

//recibe la matriz de ocupacion, vendidas, una fila y un asiento ---> libera la ocupacion 
void liberarLocalidad(string ocupacion[_filas][_asientos],string vendidas[_filas][_asientos], int fila, int asiento) {
	fila = fila - 1;
	asiento = asiento - 1;
	ocupacion[fila][asiento] = "";
	vendidas[fila][asiento] = "";

}
// recibe la matriz ocupacion,vendidas ---> libera todos los asientos de ambas matrices
void limpiarLocalidad(string ocupacion[_filas][_asientos], string vendidas[_filas][_asientos]) {
	for (int i = 0; i < _filas; i++)
	{
		for (int j = 0; j < _asientos; j++)
		{
			liberarLocalidad(ocupacion,vendidas, i + 1, j + 1);
		}
	}

}

//recibe la matriz ocupacion, muestra la ocupacion del teatro con X
void mostrarOcupacion(string ocupacion[_filas][_asientos]) {
	system("cls");
	for (int i = 0; i < _filas; i++)
	{
		if (i==0)
		{
			cout << "*|";
		}
		else
		{
			cout << i << "|";
		}
		for (int j = 0; j < _asientos; j++)
		{
			if (i == 0)
			{
				if (j != 0)
				{
					cout << j << "|";
				}
				
			}
			else {
				cout << ocupacion[i][j] << "|";
			}
			
			
		}
		cout << endl;
	}
}

//recibe la matriz de ocupacion y devuelve true si hay lugar y false si no lo hay
bool hayLugar(string ocupacion[_filas][_asientos]){
	bool miB=false;
	for (int i = 0; i < _filas; i++)
	{
		for (int j = 0; j < _asientos; j++)
		{
			if (ocupacion[i][j]=="")
			{
				miB=true;
				break;
			}
		}
	}
	return miB;
}

//recibe ambaas matrices, una fila, un asiento y el nombre del cliente ---> debe registrar la ocupacion del asiento
void ocuparLocalidad(string ocupacion[_filas][_asientos], string vendidas[_filas][_asientos], int fila, int asiento, string nombreCliente) {
	ocupacion[fila-1][asiento-1] = " X";
	vendidas[fila-1][asiento-1] = nombreCliente;
}

//recibe la ocupacion y una fila y asiento --->si no esta libre devuelve el string "ASIENTO OCUPADO", si no existe el asiento (fuera de rango de la matriz)
//devuelve "NO EXISTE" y caso contrario devuelve un string
string validarVta(string ocupacion[_filas][_asientos], int fila, int asiento) {
	string mensaje;
	if (ocupacion[fila-1][asiento-1]!="")
	{
		return "ASIENTO OCUPADO";
	}else
	{
		return "ASIENTO VACIO";
	}
	if ((fila-1)>_filas || (asiento-1)>_asientos)
	{
		return "NO EXISTE";
	}
}

//no recibe nada y le pide al usuario ingresar el nombre del cliente y lo devuelve
string getCliente() {
	string nombreCliente;
	cout << "Ingrese el nombre del cliente" << endl;
	cin >> nombreCliente;

	return nombreCliente;
}

int main()
{
	int opcionIngresada;
	string ocupacion[_filas][_asientos];
	string vendidas[_filas][_asientos];
	string nombreCliente;

	
	do
	{
		opcionIngresada = funcionMenu();
		switch (opcionIngresada)
		{
		case 1:
			break;
		case 2:
			break;
		case 3:
			mostrarOcupacion(ocupacion);
			break;
		case 4:
			cout << "Bye Bye..." << endl;
			break;
		default:
			cout << "Ingrese una Opcion Valida" << endl;
			break;
		}
		system("pause");
	} while (opcionIngresada != 4 & opcionIngresada < 5);


	system("pause");
	return 0;
}

