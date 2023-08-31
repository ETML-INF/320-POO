# L'escargot

Le but de cet exercice est de découvrir les concepts de classe et d'objet au travers de la réalisation puis de la transformation d'un programme simple.

## Etape 1

Voici [un programme](../../assets/01-01-snail.zip) en mode console qui fait bouger un escargot sur l'écran.

L'escargot `_@_ö` part à gauche de l'écran avec 50 points de vie. Chaque déplacement vers la droite lui coûte un point de vie. A zéro points de vie, il est mort `____` et le programme s'arrête.

Etablissons ensemble son pseudo-code.

Réalisez-le ensuite avec vos connaissances actuelles et l'aide ces quelques liens:

[Console.Clear](https://learn.microsoft.com/en-us/dotnet/api/system.console.clear?view=net-6.0)  
[Console.CursorVisible](https://learn.microsoft.com/en-us/dotnet/api/system.console.cursorvisible?view=net-6.0)  
[Console.SetCursorPosition](https://learn.microsoft.com/en-us/dotnet/api/system.console.setcursorposition?view=net-6.0)  
[Console.ForegroundColor](https://learn.microsoft.com/en-us/dotnet/api/system.console.foregroundcolor?view=net-6.0)  
[Console.MoveBufferArea](https://learn.microsoft.com/en-us/dotnet/api/system.console.movebufferarea?view=net-6.0)  

## Etape 2

Discutons des différentes manières dont vous avez réalisé ce programme.

## Etape 3

Transformons votre code ensemble pour y introduire une **classe** `Snail` que l'on utilisera pour fabriquer (instancier) un **objet** `snail`

Assurez-vous que vous avez bien compris les concepts de classe et d'objet.  
**Rappel:** quand vous avez "bien compris" quelque chose, cela signifie que vous vous sentez capable de l'expliquer à quelqu'un.  

## Etape 4

Modifiez votre code pour réaliser une course à deux escargots. Pour mettre du suspense dans la course, faites en sorte qu'un escargot décide parfois de prendre une pause au lieu d'avancer.  
Sa décision sera aléatoire:
```
Random rand = new Random(); // à placer au bon endroit dans votre code !!!

if (rand.Next(1,10) == 1) ...

```
## Ensuite, si vous avez encore du temps à disposition

Réalisez l'un ou l'autre des défis suivants:

1. L'escargot fait demi-tour lorsqu'il atteint le bord de l'écran
1. Il fait demi-tour à chaque fois qu'on tape une touche
1. Il se déplace de plus en plus lentement au fur et à mesure que ses forces diminuent (attention: il ne peut toujours se déplacer que d'une case à la fois)
1. Il saute quand on frappe la barre d'espace
1. On le voit de dessus et il se déplace sur deux axes au lieu d'un. Il pourrait ressembler à ça:  
    `-@<` &nbsp; &nbsp; &nbsp; vers la droite  
    `>@-` &nbsp; &nbsp; &nbsp; vers la gauche   
      
    `v`    
    `@` &nbsp; &nbsp; &nbsp; vers le haut  
    `|`  
      
    `|`  
    `@` &nbsp; &nbsp; &nbsp; vers le bas  
    `^`    
1. Il a une apparence plus élaborée (comme [ça](https://art.ngfiles.com/thumbnails/923000/923088_full.png?f1560570321) par exemple)
1. ... ou toute autre idée qui vous vient