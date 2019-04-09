# TpDelegue

Présentation du projet : l'objectif est d'utiliser les delegues. Un delegate est un type référence qui peut être utilisé pour encapsuler une méthode anonyme ou nommée. C'est un type qui ne contient pas de données mais qui pointe sur un objet.
On peut donc travailler sur une variable en affectant les autres automatiquement.

Les outils mis en oeuvre :
* visual studio
* Delegue

On travail sur une classe : Calculatrice :

![Capture.png](https://github.com/SamGdy/TpDelegue/blob/master/Images/ClasseCalculatrice.PNG)

On crée le delegate :

![Capture.png](https://github.com/SamGdy/TpDelegue/blob/master/Images/ClasseCalculatriceDefDelegue.PNG)

Ce delegue va nous permettre d'encapsuler nos méthodes on peut alors ajouter :
- addition
- soustraction 

au delegue avec la méthode Choixoperations

![Capture.png](https://github.com/SamGdy/TpDelegue/blob/master/Images/AjoutDuDelegue.PNG)

La méthode Calculer va parcourrir les méthodes encapsulées dans le delegate et les appliquer.

![Capture.png](https://github.com/SamGdy/TpDelegue/blob/master/Images/CalculMethode.PNG)
