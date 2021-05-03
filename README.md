# Operations
La globalité des variables sont initialisées en suivant la documentation de l'API de Walter, cependant en raison de variables et leurs valeurs qui ne correspondent pas exactement au simulateur, les variables sont aussi initialisées dépendamment du simulateur. Cela veut dire que si l'on veut seulement récupérer la vitesse de coupe,  

## Operation.cs
La classe Operation contient les paramètres communs à toutes les tâches.

## Drilling.cs
La classe Drilling contient les paramètres pour le forage.

## JsonOperation.cs
Cette classe sert principalement à crée le fichier json. Elle a seulement deux variables: un string AlternativeFlowMode et une instance de Drilling TaskInput.

## Program.cs
Ce fichier sert à exécuter le programme. C'est ici que des exemples de test ont été réalisés.

## MaterialClasses.cs
Regroupe différentes classes qui sont utilisées dans les paramètres communs. 

## usefulData.cs
Récupère les données renvoyées par l'API en fonction des variables déclarées dans la classe. Par exemple pour récupérer la vitesse de coupe il suffit de la récupérer en faisant json["TaskOutput"]["Results"]["Vc"]

© Janus Engineering
 
