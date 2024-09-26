# Drones
## Interface

L'espace aérien est ouvert à tout types de drones. Il va donc y avoir potentiellement des dizaines de drones de marques et modèles différents, avec des caractéristiques différentes.

Cela ne pose aucun problème, mais il est nécessaire que tous respectent certaines consignes de sécurité communes.

C'est dans ce but que l'interface `IExpellable` a été conçue. Cette interface définit les commandes (=méthodes) dont un centre de contrôle a besoin pour gérer une zone d'exclusion, c'est-à-dire une zone dans laquelle aucun drone ne doit voler.

```csharp
public enum EvacuationState 
{
    Free,           // No limits applied
    Evacuating,     // Limits known, moving out of the zone
    Evacuated       // Limits known, out of the zone
}

public interface IExpellable
{
    // Signal the limits of the no-fly zone 
    // Return true if the drone is already outside the zone
    public bool Evacuate (Rectangle zone);

    // Terminate the no-fly zone
    public void FreeFlight();

    // Interrogate the drone
    public EvacuationState GetEvacuationState();
}
```

## Travail à effectuer

1. Créer l'interface `IExpellable` dans votre projet Drone 
2. Déclarer le fait que la classe Drone implémente cette interface
3. Ecrire les méthodes minimales (vides) pour que le code compile
4. Faire un commit
5. Ecrire le code qui rend l'interfcae vraiment réalisée:
  - Un drone qui reçoit un ordre d'évacuation enregistre la zone
  - `drone.GetEvacuationState()` retourne:
    - `Free` 