# algo-tri

<div align="center">
	<h1><img src="https://user-images.githubusercontent.com/71488204/229435036-373a8710-37f2-47c5-aceb-5afc66913b4e.png" width="100"><h1>
	<h1>Projet Algo Tri</h1>
	<h2>Projet EEL</h2>
	<h3>Product Owner : Mr Girard</h3>
	<p>Application d'algorithmes de tri</p>
</div>

***Developpeurs*** &rarr;UGO.PRSWR

## Contact

Pour plus d'informations sur ce site, contacter moi à l'adresse ``` ugo.prswr@eduge.ch ```

## Table des matières
1. [Description du projet](#description-du-projet)
2. [Pages de l'application](#pages-du-site)
4. [Dépendances du site](#dépendances-du-site)
5. [Trello](#trello)
6. [Tests](#tests)
7. [Cloner le projet](#cloner-le-projet)
		
## Description du projet


Ce projet est un site de cartes à collectionner dans le thème du foot, comme les panini. Il existe 4 raretés de cartes (commun, rare, épique, légende), chaque joueurs représentés sur les cartes on leur poste et leur nationalité.

<div style="display:flex">
	<img src="https://user-images.githubusercontent.com/71488267/227920955-ffac2850-b067-4724-bb06-d58ef01631d1.png" width="200">
	<img src="https://user-images.githubusercontent.com/71488267/227922403-37d18e0f-2da6-445a-9c10-418d6fccb2ef.png" width="200">
	<img src="https://user-images.githubusercontent.com/71488267/227922581-00d480e7-e324-4b1e-80ae-9a2a1e77ab48.png" width="200">
	<img src="https://user-images.githubusercontent.com/71488267/228754864-8a6155e5-0fa4-4cf1-b467-e83df10f8594.png" width="200">
</div>

<br>

Il existe également 5 packs (bronze, argent, or, diamant, légendes) tous avec des probabilités différentes.

<br>

<div style="display:flex">
	<img src="https://user-images.githubusercontent.com/71488267/227923489-bb2e6bac-dd0d-4c52-ba8d-3d5b5595d791.png" width="150">
	<img src="https://user-images.githubusercontent.com/71488267/227923536-da60997d-a65d-4824-b5f4-569e1515afe6.png" width="150">
	<img src="https://user-images.githubusercontent.com/71488267/227923579-55611e22-1d04-480f-913c-e20656ed6a7b.png" width="150">
	<img src="https://user-images.githubusercontent.com/71488267/227923898-b7f3e75a-940c-4ebf-823e-06135852b0b8.png" width="150">
	<img src="https://user-images.githubusercontent.com/71488267/227923956-19ddee35-08a6-4618-9154-ed81b25d5aa4.png" width="150">
</div>

Probabilités  | Bronze        | Argent        | Or            | Diamant       | Légendes      |
------------- | ------------- | ------------- | ------------- | ------------- | ------------- |
Commun        | 95%           | 67%           | 44%           | 0%            | 0%            |
Rare          | 5%            | 30%           | 50%           | 70%           | 0%            |
Epique        | 0%            | 3%            | 6%            | 30%           | 0%            |
Légendes      | 0%            | 0%            | 0%            | 0%            | 100%          |

<br>

## Pages de l'application

Le projet se compose des pages suivants:

- ``` Accueil ```: Cette page est la page de base de notre site. Elle montre une redirection vers quêtes, packs et affiche les 3 cartes les plus votées par les utilisateurs.
- ``` Boutique ```: Cette page permet à l'utilisateur d'acheter des packs. Dans ces packs, il y a une carte aléatoire en fonction des probabilités du pack acheté.
- ``` MarketPlace ```: Cette page permet de mettre en vente ou d'acheter des cartes aux autres utilisateurs. Elle contient un champ détaillé de recherche qui aide l'utilisateur à précisément chercher la carte qu'il souhaite.
- ``` Collection ```: Cette page permet de voir les cartes débloquées et manquantes de l'utilisateur. Il peut chercher une carte précise grâce à son nom ou / et trier par "possédée".
- ``` Détail ``` : Cette page est accessible quand on clique sur une carte possédée dans la collection. Elle permet de voir le nombre d'itération de la carte qu'on possède, mais également de vendre rapidement la carte en échange de quelques crédits, ou encore de mettre la carte sur le marketPlace.
- ``` Compte ```: Cette page permet de changer les informations de compte ou les préférences du site de l'utilisateur. Il peut uniquement changer son mot de passe s'il n'a pas créé de compte via google.
- ``` Quêtes ```: Cette page affiche 3 quêtes que l'utilisateur peut compléter afin de récupérer des crédits. Les quêtes se réinitialisent quand le compte à rebours en bas de la page arrive à 0.

## Dépendances du site

Le site travaille avec composer, SimpleRouter et un framework CSS appelé tailwind.

Il a été codé avec ``` HTML 5 ```, ``` CSS 3 ```, ``` PHP 8 ``` et ``` JavaScript ```. 

## Trello

Nous avons gérer le planning poker et l'attribution des tâches grâce au Trello disponible ci-dessous. Nous avons également utilisé l'extension chrome / firefox qui permet de voir les uniqId des cartes.

[Lien vers notre Trello](https://trello.com/b/mxvgeoCk/11-cards-trello)

[Lien vers l'extension firefox](https://addons.mozilla.org/en-US/firefox/addon/trello-card-id/)

## Tests
[Lien vers protocole de test](https://docs.google.com/spreadsheets/d/1IXE7gK2xK6GPds4v-WK3l6DkPNSRzRXO8DDbCnKhh8Y/edit?usp=sharing)

## Cloner le projet
Vous pouvez cloner le projet, aller d'abord dans le dossier html et ensuite cloner le projet :
Cette commande permet d'aller dans le dossier racine de WSL.
```
cd /var/www/html/
```
Ensuite, clonez le projet.

```
git clone git@github.com:GH-EE-CFPT-INFO/11Cards.git
```
