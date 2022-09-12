# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

## Ejercicio de testing de DateFormat

Se crearon casos de prueba para comprobar el funcionamiento de la función 'ChangeFormat' y se obtuvieron los siguientes resultados.

1. Utilizando el formato que la función espera que ingresemos:
![Screenshot](Screenshots/TestPassed.png)

2. Utilizando un formato diferente al que la función espera recibir.
![Screenshot](Screenshots/TestFailed_WrongFormat.png)

3. Pasando como parámetro una string vacía
![Screenshot](Screenshots/TestFailed_EmptyString.png)

En base a estos resultados se optó por actualizar dicha función para prever todas estas situaciones.

Ahora la función retorna "Error, ingrese el formato correcto." si se ingresa una fecha incorrecta.