# Test unitaire sur la librairie aléatoire
Maintenant que vous savez faire des tests unitaires, il est temps de passer à la pratique.

## Guide pour commencer
1. Ajouter un projet de test au projet de librairie
1. Commencer par tester les méthodes faciles:
    - int RandomInt(int min, int max)
    
    => Tester 500x si le résultat est bien entre min et max

    - char RandomChar(string dictionary, bool withRepetition = false)

    => Tester 500x si le caractère retourné est bien dans le dictionnaire


## Qualité aléatoire
Pour vérifier si un générateur aléatoire est de bonne qualité, on peut s’intéresser à la fréquence de chaque élément.

Par exemple, si on appelle 500x *superRandom.NextInt(1,2)*, il devrait y à avoir un pourcentage similaire d’apparitions entre les chiffres 1 et 2 (environ 50% chacun).

On peut donc régler un pourcentage de tolérance et valider la distribution ainsi...

## Éléments difficilement testables
Pour les éléments difficiles à tester, on se bornera à faire un test qui appelle le code, par exemple pour la méthode *int RandomInt();*, il n’y aura que les étapes *Arrange* et *Act* puisqu’il est difficile de faire un *Assert* pertinent.

### Utile ou pas ?
Un test unitaire qui éxécute le code est déjà un premier pas vers une vérification qui sera effectuée avant de déployer l’application et cela pourrait révéler un bogue lié à un effet de bord en lien avec de la configuration, par exemple (pas visible par le compilateur)...