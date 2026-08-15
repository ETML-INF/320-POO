# Drones

## Etape 1

Reprendre l'asset [drones.zip](assets/Drones.zip). Dézippez-le dans le dossier personnel de votre repo. Exécuter le programme pour vérifier le bon fonctionnement.

1. Appliquer la technique de l'encapsulation pour qu'il n'y aie plus aucun attribut public dans la classe Drone
2. Créer une classe statique de helper pour la génération de valeurs aléatoires
3. Créer une classe statique Config. Y mettre les constantes:
   - Charge maximum de la batterie (MAX_LOAD)
   - Dimensions de l'espace aérien (AIRSPACE_WIDTH, AIRSPACE_HEIGHT)
4. Utiliser ces constantes:
   - Constructeur de Drone
   - Constructeur de AirSpace, après InitializeComponent()
5. Ajouter des attributs privés au Drone pour qu'il puisse se fixer un objectif (des coordonnées vers lesquelles le drone se dirige). Il est initialisé dans le constructeur.
6. Ajouter une constante SPEED = 10 dans Config. L'utiliser pour faire bouger le drone en direction de son objectif. Faites appel à vos connaissances des vecteurs en mathématiques pour écrire le code. Et si vous n'avez pas encore étudié ce thème,
<details><summary>voici la réponse</summary>
<p>

```
double deltaX = _targetX - X;
double deltaY = _targetY - Y;
double distance = Math.Sqrt(deltaX * deltaXdeltaY * deltaY);
double step = (double)Config.SPEED * interval/1000; // Distance parcourue pendant l'intervalle,vitesse constante
X += (int)(deltaX / distance * step);
Y += (int)(deltaY / distance * step);
```

</p>
</details>
7. Le drone s'immobilise dès qu'il a atteint son objectif

Veillez à mettre en oeuvre les bonnes [pratiques de codage de l'ETML](http://ici.section-inf.ch/cc).
