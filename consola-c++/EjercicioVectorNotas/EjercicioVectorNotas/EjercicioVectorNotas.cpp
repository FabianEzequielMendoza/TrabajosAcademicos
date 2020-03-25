// EjercicioVectorNotas.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <string>
#include <iostream>
using namespace std;

int devolverNotaMenor(int vectorNotas[],int cantNotas){
	int notaMenor= vectorNotas[0];

		for (int i = 0; i < cantNotas-1; i++)
		{
			if (!(notaMenor < vectorNotas[i + 1]))
			{
				notaMenor = vectorNotas[i+1];
			}
		}
		
	return notaMenor;
}

int devolverNotaMayor(int vectorNotas[],int cantNotas) {
	int notaMayor=vectorNotas[0];
		for (int i = 0; i < cantNotas-1; i++)
		{
			if (!(notaMayor > vectorNotas[i + 1]))
			{
				notaMayor = vectorNotas[i + 1];
			}
		}

	return notaMayor;
}

int promediarNotas(int vectorNotas[],int cantNotas) {
	int acum=0;
	for (int i = 0; i < cantNotas; i++)
	{
		acum = acum + vectorNotas[i];
	}
	return acum/cantNotas;
}

void mostrarVector(int vectorNotas[],int cantNotas) {
	cout << "La lista de nota es: " << endl;;
	for (int i = 0; i < cantNotas; i++)
	{
		cout << "n"<<i+1<<": "<<vectorNotas[i] << endl;
	}
}

int main()
{
	int vectorNotas[20], cantNotas;

	do
	{
		cout << "Ingrese cantidad de Notas de Examenes con un maximo de 20" << endl;
		cin >> cantNotas;
		system("cls");
	} while (!(cantNotas <= 20 && cantNotas >= 1));
	
	cout << "A continuacion ingrese la nota de examen de "<<cantNotas<<" alumnos..." << endl;
	system("pause");
	system("cls");
	for (int i = 0; i < cantNotas; i++)
	{
		do
		{
			cout << "Ingrese Nota de Examen del alumno n" << i + 1 << ":" << endl;
			cin >> vectorNotas[i];
			system("cls");
		} while (!(vectorNotas[i] <= 10 && vectorNotas[i] >= 0));
		
	}

	mostrarVector(vectorNotas,cantNotas);
	
	cout << "La nota menor es: " << devolverNotaMenor(vectorNotas,cantNotas)<< endl;
	cout << endl;
	cout << "La nota mayor es: " <<devolverNotaMayor(vectorNotas,cantNotas)<<endl;
	cout << endl;
	cout << "La nota promedio es: " << promediarNotas(vectorNotas,cantNotas) << endl;

	system("pause");
}
