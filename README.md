Ej 1

Process.Start(). S'utilitza per llançar aplicacions externes des del teu programa, per exemple buscadors com en l'exercici 3.

Process.GetProcesses(). Serveix per veure i gestionar tots els processos actius.

Process.GetProcessesByName(string name). S'utilitza en els cassos on només vols treballar amb processos concrets, cosa que també hem fet a l'exercici 3.

Process.Kill(). Dorça a tancar aplicacions de forma programada o d'emergència. Però s'ha d'anar amb compte o podries quedar-te sense ordinador. 

Process.StartTime. T'indica l'hora i data en què va començar el procés.

-----------------------------------------------

Ej 3

No, s'obren la mateixa quantitat de fils

-----------------------------------------------

Ej 4

Thread.Start(). Comença l'execució d'un fil / llença una tasca perquè es faci en paral·lel al teu programa principal.

Thread.Sleep(). Atura el fil actual durant el tems que vulgis. (en milisegons).

Thread.Join(). Atura el programa prinicpal fins que el fil acabi, desprès continua amb normalitat el programa principal.

Thread.IsAlive. S'utilitza per veure l'estat del fil, si encara està en execució o ja ha finalitzat.

Thread.CurrentThread. Ens permet saber quin fil se està executant, útil per quan es fa debugg.

-----------------------------------------------

Ej 5

Ho he provat 30 vegades i quasi bè totes s'imprimia en l'ordre correcte escribint "Hola! Soc el fil número x".

Ho he provat 20 evgades i la meitat de vegades s'han imprimit en l'orde correcte, l'altre meitat s'ha imprimit en un orde aleatori escribint només el número "x".

Perquè cada fil va per lliure, i qui acaba priper és el que s'imprimeix prime, no te res a veure amb qui ha comenzat a executar-se primer.
Comença el programa y mentre un fil es comença a executar el programa principal segueix exevutant-se.
