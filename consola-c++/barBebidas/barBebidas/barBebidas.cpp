/*Realizar un programa para un bar de bebidas,
el mismo vende 10 productos y posee tres turnos (1-mañana 2-tarde y 3-noche).
El sistema debe ofrecer un menú con las siguientes opciones

 1- precio de un producto

a-Debe pedirle al usuario que ingrese el número de turno (1-2-3)
y que luego ingrese el nombre del producto. Buscará el producto y
si no existe informará que no se encuentra, y si existe
mostrará el precio del turno elegido.

2- Lista de precios

b-Debe mostrar una lista de precios con los tres precios por producto

3-Salir*/


#include <iomanip>
#include "string"
#include <cstdlib>
#include <iostream>

using namespace std;

int getPosicionEncontrada(string nombreProducto, string vectorProductos[])
{
	int posicion = -1;
	for (int i = 0; i < 10; i++)
	{
		if (nombreProducto == vectorProductos[i])
		{
			posicion = i;
			break;
		}
	}
	return posicion;
}

void mostrarListaPrecios(string vectorProductos[], float matrizPrecios[10][3], string vectorTurnos[])
{
	cout << setw(40) << vectorTurnos[0];
	for (int i = 1; i < 3; i++)
	{
		cout << setw(23) << vectorTurnos[i];
	}
	cout << endl;
	for (int i = 0; i < 10; i++)
	{
		cout << setw(20)<<vectorProductos[i];
		
		for (int j = 0; j < 3; j++)
		{
			cout << setw(17) << "$" << matrizPrecios[i][j]<<"   ";
		}
		cout <<endl;
	}
	
}

int main()
{
	string vectorProductos[10] = { "CERVEZA","VINO","WISKY","AGUA","FERNET","VODKA","GANCIA","LICOR","RON","TEQUILA" }, nombreProducto, 
		vectorTurnos[3] = {"MANANA","TARDE","NOCHE"};
	float matrizPrecios[10][3] = 
	{
		{120.00,130.00,150.00},
		{100.00,105.00,120.00},
		{200.00,200.00,230.00},
		{100.00,120.00,130.00},
		{200.00,230.00,250.00},
		{200.00,250.00,270.00},
		{150.00,160.00,200.00},
		{120.00,150.00,200.00},
		{200.00,250.00,300.00},
		{200.00,230.00,250.00}
	};
	int turnoIngresado, posicionEncontrada,opcion;
	
	do
	{
		cout << "1- Precio de Producto" << endl;
		cout << "2- Lista de Precios" << endl;
		cout << "3- Salir" << endl;
		cout << "Ingrese Opcion" << endl;
		cin >> opcion;

		switch (opcion)
		{
		case 1:
			do
			{
				cout << "Ingrese numero de turno (1- Manana, 2- Tarde,3- Noche)" << endl;
				cin >> turnoIngresado;
				if (!(turnoIngresado == 1 || turnoIngresado == 2 || turnoIngresado == 3))
				{
					cout << "Por favor, Ingresa una Opcion Valida" << endl;
					cout<<endl;
				}
			} while (!(turnoIngresado == 1 || turnoIngresado == 2 || turnoIngresado == 3));
				
			cout << "Ingrese el nombre del producto" << endl;
			cin >> nombreProducto;
			
			posicionEncontrada = getPosicionEncontrada(nombreProducto, vectorProductos);
			if (posicionEncontrada == -1)
			{
				cout << "No hubo coincidencias" << endl;
			}
			else
			{
				cout << "Se ha Encontrado una coincidencia" << endl;
				cout << endl;

				cout << "El precio del Producto " << vectorProductos[posicionEncontrada] << " del Turno " 
					<< vectorTurnos[turnoIngresado - 1] << " es: $" << matrizPrecios[posicionEncontrada][ turnoIngresado - 1] << endl;
			}
			system("pause");
			break;
		case 2:
			mostrarListaPrecios(vectorProductos, matrizPrecios, vectorTurnos);
			system("pause");
			break;
		case 3:
			opcion = 4;
			cout << "Bye Bye..."<< endl;
			break;
		default:
			cout << "Ingrese una Opcion valida" << endl;
			break;
		}
		system("cls");
	} while (opcion!=4);

	system("pause");
	return 0;
	
}

