struct stDireccion {

   char Calle[64];
   int Portal;
   int Piso;
   char Puerta[3];
   char CodigoPostal[6];
   char Poblacion[32];

};

struct stPersona {

   struct stNombre {
      char Nombre[32];
      char Apellidos[64];
   } NombreCompleto;

   stDireccion Direccion;

   char Telefono[10];

};
