# Drones

## Etape 3

> Dans laquelle on ajoute des bâtiments dans l'espace aérien et on apprend à notre drone les éviter

- Ajouter une nouvelle classe `Building` dans le dossier `Model`
- Ajouter la liste statique `Buildings` dans l'espace aérien
- Dans le constructeur de `AirSpace`, initialiser cette liste avec cinq bâtiments (=instances de `Building`), disposés de manière aléatoire
- Ajouter le code nécessaire à l'affichage de ces bâtiments dans la méthode `Render`
- À chaque fois que le drone bouge (méthode Drone.Update), il faut regarder si on se retrouve à proximité d'un bâtiment. Attention : cela est plus compliqué qu'il ne peut y paraître au premier abord. En effet, le drone peut arriver à proximité d'un bâtiment de plusieurs directions.
- Lorsque le drone détecte un bâtiment, il se fixe un nouvel objectif pour éviter la collision.
