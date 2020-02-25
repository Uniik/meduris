# meduris

Assim Amenas
TP1 - Développement graphique 420-P45-BB

Meduris

Début de partie
Chaques joueurs possède:
1. 1 x de chaques ressources (bois, laine, cuivre, pierre)
2. 8 x huttes
3. 2 x temple
4. 2 x ouvriers

chaques joueurs commencent à la position 5 sur L’échelle des points de victoire

Le druide se situe sur son temple

à tour de rôle chaque joueurs placent un ouvrier à la fois sur l’un des 4 emplacement de leur choix, un haut de la pile

Partie ½ du tour
trois possibilités, au hasard:
1. chaques joueur produit une matière première par ouvrier(probabilité: ⅔)
2. chaque joueur doit se délaisser une de ses matières premières(probabilité: ⅙)
3. chaque joueur produisent une matière première de leur choix(probabilité: ⅙)


Partie 2/2 du tour
trois possibilités:
Grande exploitation: 
1. transférer un ouvrier, toujour le placer un haut de la pile, dans un emplacement
2. produire les matières premières
   1. les deux ouvriers produisent des matières première selon leur emplacement sur la carte et selon leur position en hauteur par rapport avec les autres ouvriers sur le même emplacement(1 matière première de l'élément correspondant +1 pour chaques ouvriers en dessous.)


Construire une hutte:
1. placer la hutte
   1. doit être construite sur une case non bâtie
   2. son coût de construction dépend des deux icônes visibles sur la case
      1. si une hutte occupe une case ceci crée une colonie (coût de construction = x * le coût initial, où x est le nombre de huttes composant la colonie, incluant celle sur le point de s’ajouter)
      2. si deux colonies entourent la case, le coût correspond aux deux pans de la grande colonie formée(coût de construction = coût initial( x + y), où x est le nombre de huttes composant la colonie de gauche et y est le nombre de huttes composant la colonie de droite).
2. Le joueur reçoit la pierre runique correspondant au districte 
   1. si un autre joueur possède déjà la pierre runique, celle-ci lui est prise.
3. Le druide se déplace


Édifier un temple:
1. placer le temple
   1. doit être construite sur une case non bâtie
   2. son coût de construction dépend des deux icônes visibles sur la case
2. Le druide se déplace
        

Le druide se déplace
1. avance d’une case pavé
2. s’il n’y a plus de cases pavés, avance jusqu’à la prochaine hutte
   1. il s’agit d’une hutte isolée
      1. le propriétaire paye une des deux matières première correspondant à sa case et reçoit un point de victoire
      2. le propriétaire ne donne rien et perd un point de victoire.
   2. il s’agit d’une colonie
      1. le propriétaire paye une des deux matières première correspondant à sa case et reçoit un point de victoire
      2. le propriétaire paye les deux matières première correspondant à sa case et reçoit un point de victoire pour chaques huttes composant la colonie
      3. le propriétaire ne donne rien et perd un point de victoire.
      4. le druide avance à la prochaine hutte de la colonie, reprendre à b)
3. s’il traverse le grand fleuve, chaque joueur obtient un point de victoire par pierre runique possédées.


Tour final
Survient lorsqu'un joueur a placé toutes ses huttes et temples


1. tous les autres joueurs jouent un dernier tour.
2. le druide fait un dernier tour complet, pas d'événement si le fleuve est traversé
3. Pour chaque temple, son propriétaire reçoit le nombre de points de victoire correspondant au nombre de huttes accolées au temple
4. Les joueurs reçoivent n(n+1)/2 points de victoire, où n correspond au nombre de runes possédées
5. Le joueur qui a le plus de points de victoire remporte la partie ! En cas d’égalité, le joueur qui a construit le plus de huttes et temples ressort gagnant. S’il y a également égalité, celui à qui il reste le plus de matières premières est le gagnant. S’il y a encore égalité, c’est égalité!
