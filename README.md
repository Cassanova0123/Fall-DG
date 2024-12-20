# Fall-DG
This is repo has been made for my final exam for concept and programming
Les points du jeu sont calculés en fonction des différentes actions effectuer par le joueur : Score = (Nombre des victoires - nombres de fois tomber)
 Comment fonctionne les scores :
- Les Perfommances
- Les points
- Les parties gagnées
Hiérarchie de la classe :
Joueur(classe A)
Attributs:
- Mouvement Speed
- Direction
- Position
- Collision
Door (classe B)
- Représente le multiple obstacles présent sur le parcours du joeuer.
DoorManager ( classe C)
- Gère les différentes portes du jeu
CameraPosition (classe D)
- Une synchronisation de la caméra par rapport au joueur pour avoir une vision plus fluide
PlayerData ( classe E)
- Stocke les données comme les collisions avec les portes , le nombre de fois qu'il est tombé , son score etc..
Méthode Utilisée : 
-Dijistra : Cette méthode cherche le chemin à prendre et heuristique d'optimisation pour évaluer chaque position à parcourir 
