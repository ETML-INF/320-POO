# Github

Ce document est une introduction à l’utilisation la plus simple qui soit de Git avec Github pour travailler seul à deux endroits distincts (au travail et à la maison).

## Repository

L’entité principale dans Git est le Repository (‘Dépôt’ en français), souvent abrégé ‘Repo’.  
Formellement, un repo Git est le dossier `.git/` qui se trouve dans le dossier d'un projet. Ce dépôt suit toutes les modifications apportées aux fichiers de votre projet (dossier et sous-dossiers), en construisant un historique au fil du temps. Autrement dit, si vous supprimez le dossier `.git/` vous supprimez l'historique de votre projet.  
Par abus de langage, on utilise souvent le terme de repo pour désigner l’ensemble formé du dossier de projet et du .git/ qu’il contient.

## Local vs Remote

Git est un système de gestion de version décentralisé. Cela veut dire qu’il peut exister de nombreuses copies du repo disséminées sur plusieurs machines.  
Il y a une et une seule copie d’un repo qui existe sur Github : on la nomme ‘Remote’ (ou ‘origin’).
Chaque copie du repo qui est faite sur une machine est un ‘repo local’ (à la machine en question).  
Ce système donne beaucoup de flexibilité de travail. Son inconvénient est qu’il faut bien gérer la synchronisation entre le remote et les repos locaux car elle n'est pas automatique (et c'est bien!!!).

## Commandes

Les principales commandes qui vous permettront de commencer à travailler avec Github sont illustrées dans la figure que voici:

![](Git.png)

- **Clone** : crée un repo local à partir du repo remote.
- **Pull** : met à jour le repo local à partir du remote
- **Push** : met à jour le repo remote à partir du local
- **Commit** : enregistre dans le repo tous les changements effectués dans le projet depuis le dernier Pull, Commit ou Clone

## Exemple d’utilisation

Sur mon poste de travail ETML et sur mon ordinateur personnel à la maison, j’ai installé Github Desktop et j’ai accès à Github.com.

1. Depuis l’ETML, je crée un nouveau repo sur Github. Je le nomme ‘flowers’. C’est le repo remote. (Il est très fortement recommandé de créer le repo avec un Readme)
2. Depuis le site Github.com, je lance l'opération de clonage avec Github Desktop:
   ![](githubdesktop.png)

Je peux mettre le repo local où je veux sur mon poste, cela n'a pas d'importance.
![](clone.png)

**Attention** : ne mettez pas vos repos locaux sur les lecteurs réseau. Cela ne sert à rien et ne peut que vous causer des problèmes.

3. Je travaille sur mon projet flowers dans le repo local: je crée du code, des documents, des images, …
4. J’ai terminé une tâche : je fais un **commit**. Cela a pour effet d’enregistrer tout mon travail dans le repo local.
5. Je fais un **push**. Cela a pour effet de mettre à jour le remote sur Github.
6. Je continue à travailler. Je crée de nouveaux fichiers, dossiers, … Je fais également certaines modifications à des fichiers que j’ai déjà commités/pushés précédemment.
7. J’ai terminé ma deuxième tâche : je fais un **commit**. Cela a pour effet d’enregistrer tout le travail que j’ai fait depuis le dernier **commit** dans le repo local.
8. Je fais un **push**. Cela a pour effet de mettre à jour le remote sur Github.
9. J’ai terminé ma journée, je rentre chez moi. Mais il y a encore une chose que j’aimerais bien terminer aujourd’hui…
10. Arrivé chez moi, je clone le repo sur mon ordinateur personnel. L’état de mon projet est alors exactement le même que celui sur mon poste à l’ETML.
11. Je fais cette fameuse chose que je voulais terminer dans le repo local de mon ordinateur.
12. Quand j’ai terminé, je fais un **commit**. Cela a pour effet d’enregistrer mon travail dans le repo local sur mon ordinateur personnel.
13. Je fais un **push**. Cela a pour effet de mettre à jour le remote sur Github.
14. Le lendemain, j’arrive à l’ETML. Mon projet dans le repo local de mon poste de travail est en retard puisqu’il ne contient pas mon travail d’hier soir.
15. Je fais un **pull**. Mon repo local est maintenant à jour, je peux continuer à travailler sur ce poste.
16. Je fais plusieurs **commit** / **push** pendant la journée.
17. Le soir chez moi, c’est cette fois le repo local de mon ordi qui est en retard. Je fais **pull**, il est mis à jour et je peux continuer (ou pas).

## Conflits

Il est très important de faire **pull** quand on commence à travailler sur un poste et **push** quand on a fini. Ne pas le faire peut mener à des conflits difficiles à résoudre.  
En effet, Git se rappelle de (presque) tout !  
Admettons que j’aie un fichier ‘tulipe.png’ qui est à jour partout (remote, local ETML, local maison).
Je le modifie à l’ETML et je fais commit / push. Le tulipe.png du local à la maison est en retard. Si j’oublie de faire pull à la maison, que je modifie le fichier et que je fais commit puis push, Github va refuser le push parce que mes modifications n’ont pas été faites sur la dernière version de tulipe.png.

## Nommage et contenu des commits

Pour profiter pleinement des avantages de l’outil, il convient de bien faire ses commits.
Il y a deux règles fondamentales à suivre :

1. Faire des commits **atomiques**, c'est-à-dire qui couvrent uniquement et entièrement une tâche.
   Exemple :
   Vous devez ajouter une information à saisir dans un formulaire de l’application que vous développez. Cela implique de modifier plusieurs fichiers : MLD, script de base de données, formulaire, SQL. Faites un seul commit qui contient tous ces fichiers et rien que ces fichiers.
2. Bien nommer vos commits. Un bon nom de commit est fait de trois parties:
   1. Un préfixe qui indique le type, généralement choisi parmi:
        - `feat` pour "feature", une fonctionnalité
        - `fix` pour "bugfix"
        - `chore` pour le résultat d'une tâche administrative
        - `doc` pour de la documentation
        - `refactor` pour une refactorisation
        - `test` pour des tests
        - `typo` pour des corrections mineures de fautes de frappe
   2. Le scope, c'est à dire à quoi il s'applique. On le met entre parenthèses.
   3. La description dans une forme active.
   Un bon moyen d’aide à la formulation est de compléter l’une des deux phrases suivantes
      1. « Si on l’applique, ce commit va … »
      2. « Si on applique ce commit, le système va … »

        La description de votre commit est ce que vous mettriez à la place des points de suspension.

    Exemples :  
        - feat(user): Allow to change the address of the user  
        - refactor(homepage): Use `<div>` instead of `<table>`  
        - chore(project): update the "journal de travail"
