#include <stdio.h>
#include <stdlib.h>
#include <iostream>

using namespace std;

main(){
	string nom, ape, resp;
	
	do{
		int a=0,b=0;
		printf("Ingrese un nombre: \n");
		cin>>nom;
		printf("Ingrese un Apellido: \n");
		cin>>ape;
		
		if(nom=="Eduardo"){
			a=1;
		}
		
		if(ape=="Shimoyama"){
			b=1;
		}
		
		if(a==1 && b==1){
			printf("El nombre y apellido ingresado SI esta en nuestra base de datos: \n\n");
		} else {
			printf("El nombre y apellido ingresado NO esta en nuestra base de datos: \n\n");
		}
		
		printf("Desea buscar otro nombre y apellido: \n");
		cin>>resp;
		
		while(resp != "si" && resp != "no"){
			printf("\n Por favor ingrese si o no: ");
			cin>>resp;
		}
	}while(resp == "si");
	
	system("PAUSE");
	return 0;
}
