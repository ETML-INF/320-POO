# Fourmis en famille, le retour de Krohonde

Préparer la hiérarchie de classe pour un simulateur de fourmis.

 - Une colonie définit sa couleur et a une reine.
 - Une reine peut pondre et manger.
 - Il y a 2 types de fourmis:
    - farmer
    - soldier

- Dans le monde des fourmis, il y a des cases avec une adresse X et Y.
- Sur chaque case il peux y avoir soit de la nourriture, soit une autre fourmi, soit une araignée, soit rien.

## Version 1 du jeu
En mode console, on affiche juste les actions qui sont entreprises (par exemple: *La reine bleue a pondu 1 oeuf de type Farmer* ou *une fourmi est morte*, ...) et les statistiques du monde (rien de graphique, même sur la console).

Voir [déroulement](#déroulement) pour les détails.

# Aide pour commencer
## Combien de classes et lesquelles ?

D’après le cahier des charges, on doit gérer un monde composé de cases, donc déjà :

    1. World
    2. Square

Il y a 2 types de fourmis de bases:

    1. Scout
    2. Soldier

Et ainsi de suite pour la colonie, la nourriture,...

## Qui hérite de qui ?
Chaque type de fourmi de base est en fait une "fourmi"...
Une fourmi, comme une araignée sont des insectes.

## Attributs et méthodes ?

1. Une colonie a une couleur:
```csharp
class Colony
{
    string color;
}
```

2. Une reine peut manger et pondre:
```csharp
class Queen
{
    public void Eat();
    public int Lay();
}
```

### Déroulement V1

Démarrer un monde avec 
- 1 colonie bleue contenant 1 reine avec 50 points de nourriture. 
-  16 cases (4x4) et la reine est placée au point 0,0.
- 20% des cases contiennent de la nourriture
- 5% des cases contiennent des araignées fixes

À chaque seconde, la reine mange 2pt de nourriture et pond aléatoirement un oeuf (max 5 en même temps).

Après 2 secondes de vie, un oeuf éclot et sera aléatoirement d’une classe de fourmi parmi les 4 possibles.

À chaque seconde de vie, une fourmi se déplace aléatoirement sure une case libre de fourmi.

Si une fourmi fermière trouve de la nourriture, celle-ci est ajoutée à la réserve de manière magique.

Si une fourmi fermière arrive sure une case araignée, elle meurt.

Si une fourmi soldat arrive sur une case araignée, elle a 1 chance sur 10 de gagner la case et rester en vie.

S’il n’y a plus de nourriture, la partie se termine.
Si une fourmi ne peut pas avancer (pas de cases disponibles), elle meurt.

À chaque seconde, on affiche les statistiques:
```shell
[Nourriture: 15pts, Oeufs: 2, Soldats:3, Fermières:5, Cases libres: 10, Âge:25s]
```

## Version 2 du jeu (BONUS)
À choix , soit
-  arborer une version graphique minimale qui affiche les cases et une lettre représentant les éléments (Q=reine, S=soldat, N=nourriture, A=araignée, F=Farmer)

ou alors
- Ajouter 1 autre colonnie et gérer les combats inter-colonnies...
