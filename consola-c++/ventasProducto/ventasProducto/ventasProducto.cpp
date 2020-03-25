#include <iostream>
#include <string>
using namespace std;

string opcion, cantidad = "0"; 
int totalVenta = 0, totalVendido = 0, cantVendida = 0, precioArt = 150, miB = 0, acumTotal = 0, acumCant = 0, cantidadInt = 0;

int totalizar(int cantidad, int precio)
{
	if(cantidad>=10){
		cout << "Hay 10% de descuento" << endl;

		return (precio * cantidad) - (0.1 * (precio * cantidad));
	}
	else {
		return (precio * cantidad);
	}
}
void validaOpcion(string& opcion)
{
	miB = 0;
	while (miB == 0){
		if (opcion == "v" || opcion == "f"){
			miB = 1;
		}
		else{
			cout << "Ingresa v o f para continuar" << endl;
			cin >> opcion;
		}
	}
}
int validaCantidad(string& cantidadStr)
{
	miB = 0;
	while (miB == 0){
		cantidadInt = atoi(cantidadStr.c_str());//la funcion atoi convierte string a numeros, si el string es un caracter return 0
		if (cantidadInt <= 0){
			cout << "Por favor, Ingresa solo numeros mayores a 0" << endl;
			system("pause");
			system("cls");
			cout << "Ingrese cantidad de ventas, si es igual o mayor a 10 hay 10% desc" << endl;
			cin >> cantidadStr;
		}
		else{
			miB = 1;
		}
	}
	return cantidadInt;
}


int main()
{
	cout << "v-ingresar ventas y f-totalizar y salir" << endl;
	cout << "Ingrese Opcion" << endl;
	cin >> opcion;
	validaOpcion(opcion);

	while (opcion == "v"){
		system("cls");

		cout << "Ingrese cantidad de ventas, si es igual o mayor a 10 hay 10% desc"<< endl;
		cin >> cantidad;
		cantVendida = validaCantidad(cantidad);
		totalVendido = totalizar(cantVendida, precioArt);
		cout << "El total es: $" << totalVendido << endl;
		acumCant = acumCant + cantVendida;
		acumTotal = acumTotal + totalVendido;

		system("pause");
		system("cls");

		cout << "v-ingresar ventas y f-totalizar y salir" << endl;
		cout << "Ingrese Opcion" << endl;
		cin >> opcion;
		validaOpcion(opcion);
	}
	system("cls");
	cout << "Cantidad vendida: " << acumCant << endl;
	cout << endl;
	cout << "Total vendido: $" << acumTotal << endl;

	system("pause");

	return 0;
}
