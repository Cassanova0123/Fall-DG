# Fall-DG
This is repo has been made for my final exam for concept and programming
Plumet Game est un dynamique dans lequel le joueur doit éviter des obstacles.Le joueur contrôle un personnage qui avance sur un tableau et rencontre des murs qui peuvent être 
détruits par des collisions.Chaque collision affecte la barre d'énergie en là fesant descendre chaque hit.À la fin du niveau, le score est calculé en fonction de certains critère.Le nombres de collisions,
la quantité dans la barre d'énergie et le nombre d'obstacles restants sur le jeu.Le jeu propose l'utlisation du mode AI basé sur l'alogorithme de Dijkistra pour orienter le personnage sur le parcours.
Les points du jeu sont calculés en fonction des différentes actions effectuer par le joueur : Score = (Nombre des victoires - nombres de fois tomber)
 La fonctionnement :
- Les Perfommances du joueur affecte le score à la fin de la  partie
- Une gestion d'énergie en fonction des collisions 
- Optimisation des chemins à suivre et mode AI de l'algorithme Dijkstra
## Hiérarchie de la classe :
# Joueur(classe A)
Attributs:
- Mouvement Speed
- Direction
- Position
- Collision
- Mode AI
# Door (classe B)
- Représente le multiple obstacles présent sur le parcours du joueur.
# DoorManager ( classe C)
- Gère les différentes portes du jeu
# CameraPosition (classe D)
- Une synchronisation de la caméra par rapport au joueur pour avoir une vision plus fluide
# PlayerData ( classe E)
- Stocke les données comme les collisions avec les portes , le nombre de fois qu'il est tombé , son score etc..
# Méthode Utilisée : 
-Dijistra : Cette méthode cherche le chemin à prendre et heuristique d'optimisation pour évaluer chaque position à parcourir 
