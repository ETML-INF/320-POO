# Drones

## Etape 3 : Production

Dans cette étape, les usines (`Factory`) vont se mettre à produire des biens: des smarties.

Les usines produisent par cartons. Chaque carton est caractérisé par:
- Un numéro de carton unique
- Le nombre de kilos de smarties qu'il contient : entre 5 et 10 kilos
- La couleur des smarties (ils sont tous de la même couleur dans un carton): Rouge, Jaune, Bleu, Brun ou Orange

A chaque fois qu'une usine produit un carton, elle l'annonce à la centrale de distribution (`Dispatch`) pour que plus tard un drone puisse venir le prendre.  
La centrale est caratérisée par:
- La liste des cartons produits

### Marche à suivre

Faites un commit à chaque pas.

1. Créez une classe `Box` qui modélise le carton de smarties.
2. Ajoutez une propriété `Id` à votre `Factory`, cela permettra de l'identifier.
3. Ajoutez une méthode `Update` au modèle `Factory`, veillez à ce que le moteur l'appelle pour toutes les usines à chaque cycle (frame), parce que maintenant il va se passer des choses dans votre usine quand le temps passe:
   - Incrémentez un "compteur de temps"
   - Si ce compteur représente plus que 5 secondes
     - Fabriquez un carton de smarties
     - Annoncez-le dans la console, genre : "L'usine 3 a produit un carton de 5kg de smarties rouges"
     - Enregistrez-le dans le stock de l'usine (déclarée ainsi: `private List<Box> _stock;`)
4. Dans votre dossier `Model`, ajoutez l'interface `IDispatchable`, mettez-y le code suivant:
      ```csharp
      namespace Drones
      {
          public interface IDispatchable
          {
              // Dépose d'une boîte de smarties 
              public void DropBox(Box box);
      
              // Prise d'une boîte de smarties
              // Retourne `null` s'il n'y a pas de boîte en stock
              public Box? Pickup();
      
          }
      }
      ```
    
5. Créez la classe `Dispatch`, qui modélise la centrale de distribution (un endroit qui centralise la liste de toutes les boîtes produites et qui décide à quel magasin chaque boîte doit aller).
   Déclarez-la comme ceci:
   ```csharp
   namespace Drones
   {
       public class Dispatch : IDispatchable
       {
           ...
   ```
   Cela indique que la classe `Dispatch` implémente l'interface `IDispatchable`

6. Faites faire l'implémentation de base de l'interface à Visual Studio (Actions rapides...)
7. Implémentez réellement les méthodes.
8. Ajoutez une centrale de distribution (`Dispatcher`) dans votre `AirSpace`:
   ```csharp
   public static Dispatch Dispatcher = new Dispatch();
   ```
10. Modifiez votre factory pour qu'elle annonce les cartons produits à la centrale.
11. La centrale affiche l'annonce d'un carton dans la console. A partir de là, chaque fois qu'un carton est produit, on a deux messages dans la console:
    - Message de fabrication (par la `Factory`)
    - Message de réception (par la centrale)
12. Ecrivez un test unitaire qui valide les deux méthodes implémentée par `Dispatch`

N'hésitez pas à valider le contenu de vos commits avec votre prof ou un de ses assistants.
