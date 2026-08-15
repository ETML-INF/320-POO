# Drones

## Etape 6

> Dans laquelle les clients ont soudainement une envie de pizza
> et nous, nous améliorons nos compétences en modélisation et gestion de liste.

- Si ce n'est pas déjà fait, déplacer le code de rendu (= affichage graphique) des pizzerias et des clients dans leurs classes respectives
- Ajouter un modèle Order dans le dossier Model. Une commande est caractérisée par :
  - un objet de type Pizza
  - un objet de type Pizzeria
- Ajouter une liste de commandes (`Orders`) dans le modèle `Client`. Cette liste doit être lisible publiquement pour que le drone puisse savoir quoi faire.
- Ajouter une méthode `Update` dans le modèle `Client`. Faire en sorte que cette méthode soit appelée pour tous les clients à partir de `AirSpace.Update`
- Dans la méthode Client.Update, ajouter un branchement conditionnel peu probable, genre:

```
if (alea.Next(0,10000) < 3)
```

- Si on passe dans ce if (trois chances sur 10 000!), on choisit une pizza, on trouve une pizzeria qui propose cette pizza et on ajoute une commande dans la liste
- Chaque nouvelle commande est affichée dans la console.
- Si la pizza choisie n'est proposée par aucune pizzeria, le client abandonne sa commande
