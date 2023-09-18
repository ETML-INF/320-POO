# Créer une libraire pour faciliter l’utilisation d’éléments aléatoire afin d’éviter des bogues liés au générateur C#.

## Avertissement
Sans donner plus d’explication, vous allez utiliser la *généricité*, si cela vous bloque, parlez-en à la personne qui vous encadre...

## La librairie doit fournir au moins les services suivants :

### Élements de base:

- char Next(); //Générer un caractère aléatoire
- string Next(); //Générer une chaîne aléatoire
- Date Next(); //Générer une date aléatoire
- int Next(); //Générer un entier aléatoire

### Versions personnalisées
Générer  un caractère parmi une liste de caractères possibles
- char Next(string dictionary); //Pour la classe CharGenerator:Generator\<char\>

Générer une chaîne de caractère d’une longueur défininie

- string Next(int length); //Pour la classe StringGenerator:Generator\<string\>

Générer une date comprise entre deux autres
- Date Next(Date min, Date max);

Génerer un entier compris entre deux bornes
- int Next(int min, int max);

Génerer un entier parmi un tableau de candidats (avec ou sans répétition)
- int Next(int[] dictionary,bool repeat=false);

Configurer le générateur aléatoire avec un seed défini
- SetSeed(int seed);//pour rejouer une série...

*Pour faciliter le travail en équipe (théorique), la hiérarchie suivante est demandée :*

class Generator\<T\>{}

class StringGenerator : Generator\<string\> // contiendra la méthode Next(string dictionary)...

class IntGenerator:Generator\<int\>

class ...

## Validation

### Basique
Pour valider la libraire, écrire un programme qui pose des questions à l’utilisateur, comme par exemple:

- Deviner le caractère tiré au hasard parmi "abcde"
- Deviner une date entre le 1er janvier et le 31 décembre de cette anné
- Deviner un chiffre entre 0 et 100

### Avancée
Si vous avez le temps, vous pouvez arborer un début de "mastermind" qui tire au sort 4 couleurs parmi 7 pour les faire deviner...

## Bonus

### Ajouter des méthodes en s’inspirant de librairie type "faker" pour le testing
Par exemple [fakerphp](https://fakerphp.github.io/)...

### Nuget
Publier la libraire dans un repo NUGET LOCAL

