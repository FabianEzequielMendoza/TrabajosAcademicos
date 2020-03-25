// entradasEstadio.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>
#include "entradasEstadio.h"
using namespace std;

int main()
{
	int opcion, numTribuna, valorTrib[4], cantidadDeVentas, cantidadEntradas1 = 10, cantidadEntradas2 = 15, cantidadEntradas3 = 20, montoAcobrar, acumTotal1 = 0, acumTotal2 = 0, acumTotal3 = 0,
		acumVentas1 = 0, acumVentas2 = 0, acumVentas3 = 0;
	valorTrib[1] = 100;valorTrib[2] = 200;valorTrib[3] = 250;
	cout << "1 - Ingresar venta" << endl << "2 - Salir y totalizar" << endl<< "Ingrese Opcion:" << endl;
	cin >> opcion;
	if (opcion == 1) 
	{	

		while (opcion != 2) 
		{
			cout << "Disponible: " << endl;
			cout << "Tribuna 1: " << "cantidad: " << cantidadEntradas1 << " Precio entrada: " << "$100" << endl;
			cout << "Tribuna 2: " << "cantidad: " << cantidadEntradas2<< " Precio entrada: " << "$200" << endl;
			cout << "Tribuna 3: " << "cantidad: " << cantidadEntradas3 << " Precio entrada: " << "$250" << endl << "" << endl;
			cout << "Ingrese la tribuna <1,2,3> : ";
			cin >> numTribuna;
			valorTrib[numTribuna];
			cout << "Ingrese cantidad de entradas : ";
			cin >> cantidadDeVentas;
			montoAcobrar = valorTrib[numTribuna] * cantidadDeVentas;
			cout << "" << endl;
			switch (numTribuna)
			{
			case 1: 
				if (cantidadEntradas1>=cantidadDeVentas)
				{
					acumTotal1 = acumTotal1 + montoAcobrar;
					cantidadEntradas1 = cantidadEntradas1 - cantidadDeVentas;
					acumVentas1 = acumVentas1 + cantidadDeVentas;
				}
				else
				{
					cout << "Disponible : " << cantidadEntradas1 << " disponible/s "<<endl;
					montoAcobrar = 0;
				}
			break;
			case 2:
				if (cantidadEntradas2>=cantidadDeVentas)
				{
					acumTotal2 = acumTotal2 + montoAcobrar;
					cantidadEntradas2 = cantidadEntradas2 - cantidadDeVentas;
					acumVentas2 = acumVentas2 + cantidadDeVentas;
				}
				else
				{
					cout << "Disponible : " << cantidadEntradas2 << " disponible/s " << endl;
					montoAcobrar = 0;
				}
			break;
			case 3:
				if (cantidadEntradas3>=cantidadDeVentas)
				{
					acumTotal3 = acumTotal3 + montoAcobrar;
					cantidadEntradas3 = cantidadEntradas3 - cantidadDeVentas;
					acumVentas3 = acumVentas3 + cantidadDeVentas;
				}
				else
				{
					cout << "Disponible : " << cantidadEntradas3 << " disponible/s " << endl;
					montoAcobrar = 0;
				}
			break;
			default: cout << "Usted a ingresado en una opción incorrecta." << endl;
			}
			cout << "Debe abonar : " << "$" << montoAcobrar << endl<< ""<<endl;
			system("pause");//Presione tecla para continuar
			system("cls");//Limpiar pantalla
			cout << "Ingrese nueva Opcion para continuar: " << endl<< "1 - Ingresar venta" << endl<< "2 - Salir y totalizar" << endl;
			cin >> opcion;
		}
	}	
	cout << "" << endl<< "Total de ventas"<<endl<< "" << endl;
	cout << "Tribuna 1: " << "cantidad: " << acumVentas1 << " Total: " << "$"<<acumTotal1<<endl;
	cout << "Tribuna 2: " << "cantidad: " << acumVentas2 << " Total: " << "$"<<acumTotal2<<endl;
	cout << "Tribuna 3: " << "cantidad: " << acumVentas3 << " Total: " << "$"<<acumTotal3<<endl;
	cout << "" << endl;
	cout << "Vuelvas prontos" << endl;
	system("pause");
	return 0;
}
// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
