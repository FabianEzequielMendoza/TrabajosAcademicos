

//
/*Notas Alumnos

Crear un programa en el que se permita cargar los datos de alumnos(Máximo 20),
donde primero se pida la cantidad de alumnos a cargar.Luego el programa debe pedir por cada alumno nombre, apellido y tres notas.

Al finalizar la carga se mostrará un menú con las opciones

Listar Notas

Modificar notas alumno

La primera opción mostrará un listado con Nombre, apellido, nota1, nota2, nota3, promedio por cada alumno ingresado.

La segunda opción pedirá el ingreso de un nombre y lo buscará en los datos guardados,
al encontrarlo deberá pedir el ingreso de las tres notas y reemplazará las notas existentes por las ingresadas */


#include <string>
#include <iostream>

using namespace std;

int getNotaMenor(int vectorNotas[], int cantNotas) {
	int notaMenor = vectorNotas[0];

	for (int i = 0; i < cantNotas - 1; i++)
	{
		if (!(notaMenor < vectorNotas[i + 1]))
		{
			notaMenor = vectorNotas[i + 1];
		}
	}

	return notaMenor;
}

int getNotaMayor(int vectorNotas[], int cantNotas) {
	int notaMayor = vectorNotas[0];
	for (int i = 0; i < cantNotas - 1; i++)
	{
		if (!(notaMayor > vectorNotas[i + 1]))
		{
			notaMayor = vectorNotas[i + 1];
		}
	}

	return notaMayor;
}

int promediarNotas(int vectorNotas[20][3], int cantAlumnos,int i) {
	int acum = 0, cantNotas = 3;
		for (int j= 0; j < cantNotas;j++)
		{
			acum = acum + vectorNotas[i][j];
		}
	
		return acum / cantNotas;
}

void mostrarVector(string vectorNombre[], string vectorApellido[], int vectorNotas[20][3], int cantAlumnos) {
	cout << "La lista de nota es: " << endl;;
	for (int i = 0; i < cantAlumnos; i++)
	{
		cout << "N " << i + 1 << ", Nombre:" << vectorNombre[i] << ", Apellido: " << vectorApellido[i];
		for (int j=0;j < 3; j++)
		{
			cout << ", Nota " << j + 1 << ": " << vectorNotas[i][j];
		}
		cout << ", Promedio: " << promediarNotas(vectorNotas, cantAlumnos, i) << endl;
	}
}

int buscar(string apellidoAbuscar, string vectorApellido[], int cantAlumnos) {
	int posicion = -1;

	for (int i = 0; i < cantAlumnos; i++) {
		if (apellidoAbuscar == vectorApellido[i]) {
			posicion = i;
			break;
		}
	}
	return posicion;
}
void modificarNotas(int j, int vectorNotas[20][3]) {
	
	for (int i = 0; i < 3; i++)
	{
		do
		{
			cout << "Ingrese Nota " << i + 1 << " del alumno N " << j + 1 << ":" << endl;
			cin >> vectorNotas[j][i];
		} while (!(vectorNotas[j][i] <= 10 && vectorNotas[j][i] >= 0));
	}
}

int main()
{
	string vectorNombre[20], vectorApellido[20],apellidoAbuscar; 
	int vectorNotas[20][3], cantAlumnos, opt1,posicionEncontrada;

	do
	{
		cout << "Ingrese cantidad de Alumnos a cargar con un maximo de 20" << endl;
		cin >> cantAlumnos;
		system("cls");
	} while (!(cantAlumnos <= 20 && cantAlumnos >= 1));

	cout << "A continuacion ingrese el nombre,apellido y 3 notas de " << cantAlumnos << " alumnos..." << endl;
	system("pause");
	system("cls");
	for (int i = 0; i < cantAlumnos; i++)
	{

		cout << "Ingrese Nombre del alumno N " << i + 1 << ":" << endl;
		cin >> vectorNombre[i];
		cout << "Ingrese Apellido del alumno N" << i + 1 << ":" << endl;
		cin >> vectorApellido[i];
		system("cls");

		modificarNotas(i,vectorNotas);

		system("cls");

	}
	do
	{
		cout << "1 - Listar Notas" << endl;
		cout << "2 - Modificar Notas" << endl;
		cout << "3 - Salir" << endl;

		do
		{
			cout << "Elija una opcion" << endl;
			cin >> opt1;

		} while (!(opt1 == 1 || opt1 == 2 || opt1 == 3));

		system("cls");

		switch (opt1)
		{
		case 1://muesta la lista de nombres, apellidos, notas
			mostrarVector(vectorNombre, vectorApellido, vectorNotas, cantAlumnos);
			break;
		case 2: //buscar un apellido, y cambiar las 3 notas
			cout << "Ingrese Apellido a buscar" << endl;
			cin >> apellidoAbuscar;
			posicionEncontrada = buscar(apellidoAbuscar, vectorApellido, cantAlumnos);
			if (posicionEncontrada >= 0)
			{
				if (posicionEncontrada == -1)
				{
					cout << "No se ha encotrado coincidencias" << endl;
				}
				else
				{
					cout << "Ha Encontrado una coincendencia" << endl;
					cout << "A continuacion modifique las notas" << endl;
					system("pause");
					system("cls");
					modificarNotas(posicionEncontrada, vectorNotas);
				}
			}
			break;

		default:
			cout << "Bye Bye..." << endl;
			break;
		}
		system("pause");
		system("cls");
	} while (opt1!=3);

	return 0;
}