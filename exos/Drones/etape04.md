# Drones

## Etape 4

> Dans laquelle on installe des pizzerias dans les bâtiment, on place des clients en faisant bien attention de ne pas se marcher les uns sur les autres.
> Cela nous fera pratiquer le concept d'exception, ainsi que la refactorisation

- Renommer la classe `Building` en `Pizzeria`. Faire en sorte que le mot `building` n'apparaisse plus du tout dans le code.
- Ajouter une propriété Name dans la classe
- Ajouter une nouvelle classe `Client` dans le dossier `Model`. Un client et caractérisé par un nom et une position dans l'espace aérien.
- Ajouter la liste statique `Clients` dans l'espace aérien
- Dans le constructeur de `AirSpace`, initialiser cette liste avec quinze clients (=instances de `Client`), disposés de manière aléatoire
- Ajouter le code nécessaire à l'affichage des noms des pizzerias et des clients dans la méthode `Render`

À ce stade, il est fort probable que l'on observe un chevauchement entre certains éléments visuels (pizzeria et/ou client)
