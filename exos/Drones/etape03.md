# Drones

## Etape 3

> Dans laquelle on ajoute des pizzerias et des clients dans l'espace aérien
> Cela nous fera travailler avec des Listes

- Ajouter une nouvelle classe `Pizzeria` dans le dossier `Model`. Une pizzeria a un emplacement (coordonnées) et un nom.
- Ajouter la liste statique `Pizzerias` dans l'espace aérien
- Dans le constructeur de `AirSpace`, initialiser cette liste avec cinq pizzerias (=instances de `Pizzeria`), disposées de manière aléatoire
- Ajouter le code nécessaire à l'affichage de ces bâtiments dans la méthode `Render`. Une pizzeria est un carré plein de 50 pixels de côté et de couleur grise. Attention : la position indique le centre du carré.
- Répéter l'opération pour les clients. La différence principale, c'est que les clients sont représentés par des carrés plein de couleur verte, de 10 pixels de côté. Disposer 20 clients dans l'espace aérien.
