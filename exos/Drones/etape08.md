# Drones

## Etape 8

> Dans laquelle le drone va se dépêcher d'aller livrer la pizza qu'il vient de récupérer pendant qu'elle est encore chaude

- Mettre le drone dans l'état `DELIVERING`
- Fixer l'objectif du drone sur le client
- Quand il arrive chez le client (distance < CLIENT_SIZE / 2), il appelle la méthode `void Client.Deliver(Pizza pizza)`
- Il réinitialise sa commande et sa pizza et se remet en état `ROAMING` dans l'attente (ou pas) de la prochaine commande.
- Le client annonce avoir reçu sa pizza dans la console.
- Attention : si la batterie du drone devient faible pendant qu'il se déplace en direction du client, il va devoir s'arrêter à la station de recharge et reprendre son travail une fois la batterie pleine
