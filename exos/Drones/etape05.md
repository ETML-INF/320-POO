# Drones

## Etape 5

> Dans laquelle les pizzerias proposent un menu
> Nous renforceons nos connaissances en modélisation objet ainsi qu'en gestion des listes
> Mais nous allons surtout introduire ou ajouter des tests unitaires

- Ajouter une nouvelle classe Pizza dans le dossier Model. Une pizza et caractérisée par:
  - un nom
  - une description
  - un prix
- Ajouter une liste de pizza dans la configuration:

```
public static readonly Pizza[] PIZZAS = new Pizza[]  // Pizzas prédéfinies pouvant être commandées
        {
            new Pizza("Margherita", "Tomate, mozzarella, basilic", 14.00),
            new Pizza("Reine", "Tomate, mozzarella, jambon, champignons", 16.00),
            new Pizza("Quatre Fromages", "Tomate, mozzarella, gorgonzola, parmesan, chèvre", 17.50),
            new Pizza("Calzone", "Pizza pliée garnie de jambon, mozzarella et champignons", 16.50),
            new Pizza("Végétarienne", "Tomate, mozzarella, légumes grillés", 15.50),
            new Pizza("Hawaïenne", "Tomate, mozzarella, jambon, ananas", 15.00),
            new Pizza("Napolitaine", "Tomate, mozzarella, anchois, câpres, olives", 16.00),
            new Pizza("Diavola", "Tomate, mozzarella, salami piquant", 16.50),
            new Pizza("Capricciosa", "Tomate, mozzarella, jambon, champignons, artichauts, olives", 17.00),
            new Pizza("Marinara", "Tomate, ail, origan, huile d'olive", 12.50),
            new Pizza("Prosciutto", "Tomate, mozzarella, jambon cru, roquette", 17.50),
            new Pizza("Tonno", "Tomate, mozzarella, thon, oignons", 16.00),
            new Pizza("Bufala", "Tomate, mozzarella di bufala, basilic", 17.00),
            new Pizza("Boscaiola", "Crème, mozzarella, champignons, saucisse", 17.50),
            new Pizza("Pepperoni", "Tomate, mozzarella, pepperoni", 16.00)
        };
```

(vous pouvez naturellement personnaliser cette liste)

- Au moment de sa création, chaque pizzeria choisit aléatoirement six de ces pizzas pour les mettre à son menu (attention à ne pas mettre deux fois la même pizza dans le menu). Il faut donc créer une liste d'objets de type `Pizza` dans la classe pizzeria. Cette liste doit naturellement être accessible en lecture seule.
- Chaque pizzeria annonce son menu dans la console
