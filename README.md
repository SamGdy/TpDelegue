# TpDelegue

Présentation du projet : l'objectif est D'utiliser les delegue. Un delegate est un type référence qui peut être utilisé pour encapsuler une méthode anonyme ou nommée. C'est un type qui ne contient pas de données mais qui pointe sur un objet.
On peut donc travaillé sur une variable en affectant les autres automatiquement.

Les outils mis en oeuvre :
* visual studio
* Delegue

On travail sur une classe : Calculatrice :

![Capture.png](https://github.com/SamGdy/TpDelegue/blob/master/Images/ClasseCalculatrice.PNG)

On crée le delegate :

![Capture.png](https://github.com/SamGdy/TpDelegue/blob/master/Images/ClasseCalculatriceDefDelegue.PNG)

Ce delegue va nous permettre d'encapsuler nos methodes on peut alors ajouter :
- addition
- soustraction 

au delegue avec la methode Choixoperations

![Capture.png](https://github.com/SamGdy/TpDelegue/blob/master/Images/AjoutDuDelegue.PNG)

La methode Calculer va parcourrir les methodes encapsulé dans le delegate et les appliquer.

![Capture.png](https://github.com/SamGdy/TpDelegue/blob/master/Images/CalculMethode.PNG)
