# Créer une libraire pour faciliter l’utilisation d’éléments aléatoire afin d’éviter des bogues liés au générateur C#.

## La librairie doit fournir au moins les services suivants :

### Élements de base:

- char Next(); //Générer un caractère aléatoire
- string Next(); //Générer une chaîne aléatoire
- Date Next(); //Générer une date aléatoire
- int Next(); //Générer un entier aléatoire

### Versions personnalisées
- char Next(string dictionary); //Pour la classe CharGenerator:Generator\<char\>
- string Next(int length); //Pour la classe StringGenerator:Generator\<string\>
- Date Next(Date min, Date max);
- int Next(int min, int max);
- int Next(int[] dictionary);
- SetSeed(int seed);//pour rejouer une série...

*Pour faciliter le travail en équipe (théorique), la hiérarchie suivante est demandée :*

class Generator\<T\>{}

class StringGenerator : Generator\<string\> // contiendra la méthode Next(string dictionary)...

class IntGenerator:Generator\<int\>

class ...

## Tests
Ajouter un projet test unitaire pour valider chacun de ces éléments

## Bonus

### Ajouter des méthodes en s’inspirant de librairie type "faker" pour le testing
Par exemple [fakerphp](https://fakerphp.github.io/)...

### Nuget
Publier la libraire dans un repo NUGET LOCAL

