Créer une libraire pour faciliter l’utilisation d’éléments aléatoire afin d’éviter des bogues liés au générateur C#.
La librairie doit fournir au moins les services suivants :

Élements de base:

char Next();
string Next();
Date Next();
int Next();

Versions personnalisées
char Next(string dictionary);
string Next(int length);
Date Next(Date min, Date max);
int Next(int min, int max);
int Next(int[] dictionary);

SetSeed(int seed);//pour rejouer une série...

Pour faciliter le travail en équipe, la hiérarchie suivante est demandée :

class Generator<T>{}
class StringGenerator:Generator<string> => contiendra la méthode Next(string dictionary)...
class IntGenerator:Generator<int>
class ...


AJOUTER un projet test unitaire pour valider chacun de ces éléments

PUBLIER la libraire dans un repo NUGET LOCAL

