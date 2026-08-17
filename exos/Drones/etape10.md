# Drones

## Etape 9

> Dans laquelle on essaye d'inverser la logique de travail des drones.
> Au lieu que ce soit les drones qui recherchent du travail, ce seront les pizzerias qui chercheront un drone pour livrer une commande.
> Cela nous permettra d'exercer l'utilisation d'une interface

- Créer l'interface `IPizzaDeliverable`. Elle contient la méthode :

```
public bool HandleOrder(Order order);
```

- Déclarer le fait que la classe `Drone` implémente l'interface `IPizzaDeliverable`. Coder l'implémentation.
- Rendre la liste de drones (`_fleet`) visible publiquement pour que les pizzerias puissent y accéder
- Lorsqu'elle reçoit une commande, une pizzeria établis la liste des drones qui sont dans l'état `ROAMING`
- Elle transmet sa commande au premier drone de cette liste en appelant `HandleOrder`. Si la réponse est positive, la pizzeria retire la commande de sa liste, sinon elle essaye les drones suivants.
- Rendre la liste des commandes de la pizzeria privée, étant donné qu'il n'y a plus de raison que cette liste soit consultée de l'extérieur
