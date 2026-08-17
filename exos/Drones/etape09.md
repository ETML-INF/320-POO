# Drones

## Etape Bonus

> Dans laquelle on se rend compte que un seul drone, ça va pas le faire, surtout que les clients ne commandent pas une seule pizza à la fois, et qu'un drone ne peut porter qu'une seule pizza.

- Ajouter deux drones supplémentaires. Constater le problème auquel on est maintenant confronté : chacun des trois drones, va vouloir gérer la même commande!
- Il faut ajouter un champ `Drone` à la commande pour dire quel drone fait la livraison. Ce champ est naturellement `null` à la création.
- Lorsqu'un drone a trouvé une commande avec `Drone == null` dans une pizzeria il s'inscrit lui-même dans la commande pour qu'elle ne soit pas reprise par un de ses collègues.
