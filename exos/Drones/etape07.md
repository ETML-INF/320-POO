# Drones

## Etape 7

> Dans laquelle le drone arrête de buller, parce qu'il y a des commandes qu'il faut livrer.
> Nous, on va devoir en enrichir encore un peu nos modèles !

- Dans la méthode `Drone.Update`, on va parcourir la liste des pizzerias. Pour chacune d'elles, on regarde si il y a des commandes. Dès qu'une commande a été trouvée, on l'enregistre dans notre objet drone et on annonce dans la console la prise de la commande.
- Le drone passe en état `PICKUP`, se fixe la pizzeria qui est dans la commande comme objectif
- Quand il arrive à la pizzeria (distance < PIZZERIA_SIZE / 2), il appelle la méthode `Pizza Pizzeria.PickUp(Order order)`. Il stocke l'objet de type Pizza qu'il reçoit en retour parmi ses attributs privés. Il annonce avoir pris la commande à la pizzeria dans la console.
- La pizzeria supprime la commande
- Attention : si la batterie du drone devient faible pendant qu'il se déplace en direction de la pizzeria, il va devoir s'arrêter à la station de recharge et reprendre son travail une fois la batterie pleine
