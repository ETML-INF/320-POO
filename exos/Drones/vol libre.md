# Drone

## Vol Libre

Dans cet exercice, nous allons nous intéresser à la simulation du vol du drone.  
Les principes qui contrôlent son vol sont les suivants:
- Le drone se fixe un but au hasard
- À chaque `Update`, il choisit une vitesse de déplacement qui le dirige vers ce but
- Dès qu'il attend son but il s'en fixe un nouveau, toujours au hasard
- Si son niveau de batterie est inférieur à 50 %, son but devient forcément la station de recharge (dont la position est définie de manière statique dans `AirSpace`)
- Dès qu'il atteint la station de recharge, sa vitesse devient nulle ; il reste donc sur place
- Tant qu'il est sur la station de recharge, son niveau de batterie remonte à chaque `Update`
- Dès que son niveau de recharge atteint les 100 %, il se fixe un but au hasard et le cycle reprend

### Indices

- La vitesse n'est pas juste un nombre. Elle a deux composantes: verticale est horizontale. À chaque `Update`, on ajoute la composante horizontale à la position X du drone et la composante verticale à la position Y.
- La classe existante `Point` permet de travailler avec des coordonnées (X,Y).
- Si la vitesse horizontale et/ou verticale du drone est plus grande que un pixel, il y a peu de chance qu'il atteigne sa cible de manière exacte. En effet, si il est à deux pixels du but et que sa vitesse est de trois pixels, il va dépasser sa cible et se retrouver à un pixel. La manière la plus propre de traiter ce cas, c'est de faire une méthode statique dans un helper, basée sur la distance entre les deux points : l'objectif est atteint si la distance entre la position et la cible est plus petite qu'un certain nombre (par exemple 4 pixels).
