# Introducción

![SVSXML](https://dl.dropboxusercontent.com/u/32724134/SVSXML.png)

SVSXML permite crear un archivo XML, necesario para informar a la **Super Intendencia de Valores y Seguros** en el proceso de **Registro Especial de Entidades Informantes, Información Continua**.
El archivo XML, con el formato válido aceptado proviene del input de un archivo Excel.

# Compilar

* (El programa fue desarrollado utilizando **Visual Studio 2010**)
* Abrir el archivo SVSXML.sln
* En "**Configuration Manager**", seleccionar la opción "**Release**"
* En el menú "**Build**", seleccionar la opción "**Build Solution**"

# Uso

El programa asume los siguientes datos en el archivo Excel de entrada:

* **Columna D**: RUT del fondo.
* **Columna E**: Dígito verificador del fondo.
* **Columna F**: Denominación del fondo.
* **Columna G**: Valor de activos.
* **Columna H**: Valor de pasivos.
* **Columna I**: Criterios contables
* **Columna J**: RUT de aportante.
* **Columna K**: Dígito verificador del aportante.
* **Columna L**: Extranjero (NO/SI).
* **Columna M**: Apellido paterno.
* **Columna N**: Apellido materno.
* **Columna O**: Primer nombre.
* **Columna P**: Segundo nombre.
* **Columna Q**: Monto participación.
* **Columna R**: Número de cuotas.

# Créditos

* Licencia: MIT