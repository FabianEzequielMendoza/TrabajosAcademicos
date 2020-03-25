#include <iostream>
using namespace std;


int totalizar(int cantidad, int precio)
{
	return (precio*cantidad);
}
int controlOpcion(string &opcion)
{
	int miB = 0;
	while(miB == 0)
	{
		if (opcion == "v" || opcion == "f")
		{
			miB = 1;
		}
		else
		{
			cout << "Ingrese v o f para continuar" << endl;
			cin >> opcion;
		}
	}
	return 0;
}
int controlCantidad(int &cantVendida)
{
	int miB = 0;
	while (miB == 0)
	{
		if (cantVendida >= 0)
		{
			miB = 1;
		}
		else
		{
			cout << "Ingrese una opcion valida" << endl;
			cin >> cantVendida;
		}
	}
	return 0;
}

int main()
{
	string opcion; int cantVendida = 0, totalVenta = 0, precioArt = 150, acumTotal = 0, acumCant = 0;

	cout << "v-ingresar ventas y f-totalizar y salir" << endl;
	cout << "Ingrese Opcion" << endl;

	cin >> opcion;
	controlOpcion(opcion);
	
	while (opcion == "v")
	{
		system("cls");

		cout << "Ingrese cantidad de ventas" << endl;
		cin >> cantVendida;
		controlCantidad(cantVendida);

		cout << "El total es: $" << totalizar(cantVendida, precioArt) << endl;
		acumCant = acumCant + cantVendida;
		acumTotal = acumTotal + totalizar(cantVendida, precioArt);
		system("pause");
		system("cls");

		cout << "v-ingresar ventas y f-totalizar y salir" << endl;
		cout << "Ingrese Opcion" << endl;
		cin >> opcion;
		controlOpcion(opcion);
	}
	system("cls");
	cout << "Cantidad total vendida es: " << acumCant << endl;
	cout << endl;
	cout << "Cantidad total ventas acumulada es: $" << acumTotal << endl;

	system("pause");

	return 0;
}
