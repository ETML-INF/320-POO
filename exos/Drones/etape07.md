# Drones

## Etape 7

> Dans laquelle le drone arrête de buller ! Il s'inquiète des éventuelles commandes de la part des clients et quand il en voit une, il va la chercher et il la livre au client
> nous, on va devoir en enrichir encore un peu le modèle `Drone` !

- Dans la méthode `Drone.Update`, on va parcourir la liste des clients. Pour chacun d'eux, on regarde si il a des commandes. Dès qu'une commande a été trouvée, on l'enregistre dans notre objet drone et on annonce dans la console la prise de la commande.
- Le drone se fixe la pizzeria qui est dans la commande comme objectif
- Quand le drone arrive au contact de la pizzeria, il appelle la méthode `Pizza Pizzeria.PickUp(string pizzaName)`. Il stocke l'objet de type Pizza qu'il reçoit en retour parmi ses attributs privés. Il annonce avoir pris la commande à la pizzeria dans la console.
- Il se fixe l'emplacement du client comme objectif.
- Quand il arrive au contact du client, il appelle la méthode `Client.AcceptDelivery`. Le client annonce dans la console à voir reçu sa commande. Il la supprime de sa liste.
- Le drone se remet en mode recherche de travail
