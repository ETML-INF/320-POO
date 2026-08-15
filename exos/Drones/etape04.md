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

À ce stade, il est fort probable que l'on observe un chevauchement entre certains éléments visuels (pizzeria et/ou client).  
Faites l'essai.

Pour remédier à ce problème :

- Ajouter une méthode statique `RegisterPizzeria` qui permet d'ajouter une pizzeria (=objet de type Pizzeria) dans la liste. Avant d'insérer l'objet donné dans la liste, cette méthode vérifie que l'objet donné n'entre pas en collision (utiliser la hitbox) avec une pizzeria existante. Elle lance une exception si c'est le cas.
- Utiliser cette méthode pour initialiser la liste des pizzerias. Gérer correctement les exceptions lorsqu'elles sont lancées. Attention: on a toujours l'obligation d'avoir cinq pizzerias.
- Faire la même chose avec client, avec une vérification supplémentaire : on ne peut pas déposer un client sur une pizzeria
- Modifier les deux méthodes RegisterPizzeria pour s'assurer également que ni une pizzeria, ni un client ne se trouve à l'emplacement de la borne de recharge
