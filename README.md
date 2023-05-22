# algo-tri

<div align="center">
	<h1><img src="https://user-images.githubusercontent.com/71488204/229435036-373a8710-37f2-47c5-aceb-5afc66913b4e.png" width="100"><h1>
	<h1>Projet 11Cards</h1>
	<h2>Projet EEL</h2>
	<h3>Product Owner : Mme Mota / Mr Gabrielle</h3>
	<p>Site de cartes à collectionner sur le thème du foot</p>
</div>

## Auteurs
***Scrum master*** &rarr; LEO.TRN
<br>
***Developpeurs*** &rarr; EMIR.AHMTV, UGO.PRSWR et KEVIN.FLPLM

## Contact

Pour plus d'informations sur ce site, contacter le support 11Cards par mail grâce à l'adresse ``` cards11.supp@gmail.com ```

## Table des matières
1. [Description du projet](#description-du-projet)
2. [Pages du site](#pages-du-site)
3. [Base de données](#base-de-données)
4. [Dépendances du site](#dépendances-du-site)
5. [Trello](#trello)
6. [Tests](#tests)
7. [Cloner le projet](#cloner-le-projet)
8. [Installer Composer](#installer-composer)
	1. [Serveur web integré](#serveur-web-integré)
	2. [Apache2](#apache2)
10. [Dépendance](#dépendance)
11. [Lancer le serveur](#lancer-le-serveur)

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

## Pages du site

Le projet se compose des pages suivants:

- ``` Accueil ```: Cette page est la page de base de notre site. Elle montre une redirection vers quêtes, packs et affiche les 3 cartes les plus votées par les utilisateurs.
- ``` Boutique ```: Cette page permet à l'utilisateur d'acheter des packs. Dans ces packs, il y a une carte aléatoire en fonction des probabilités du pack acheté.
- ``` MarketPlace ```: Cette page permet de mettre en vente ou d'acheter des cartes aux autres utilisateurs. Elle contient un champ détaillé de recherche qui aide l'utilisateur à précisément chercher la carte qu'il souhaite.
- ``` Collection ```: Cette page permet de voir les cartes débloquées et manquantes de l'utilisateur. Il peut chercher une carte précise grâce à son nom ou / et trier par "possédée".
- ``` Détail ``` : Cette page est accessible quand on clique sur une carte possédée dans la collection. Elle permet de voir le nombre d'itération de la carte qu'on possède, mais également de vendre rapidement la carte en échange de quelques crédits, ou encore de mettre la carte sur le marketPlace.
- ``` Compte ```: Cette page permet de changer les informations de compte ou les préférences du site de l'utilisateur. Il peut uniquement changer son mot de passe s'il n'a pas créé de compte via google.
- ``` Quêtes ```: Cette page affiche 3 quêtes que l'utilisateur peut compléter afin de récupérer des crédits. Les quêtes se réinitialisent quand le compte à rebours en bas de la page arrive à 0.

## Base de données

Voici le modèle de notre base de données :
![image](https://user-images.githubusercontent.com/71488267/227929572-40e0cfb0-760d-4e58-a0ce-0c3b2f6d8537.png)


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

## Installer Composer
```
composer install
```
Les dépendances du projet sont installées et vous verrez apparaître un dossier ``` vendor ``` ainsi qu'un fichier ``` composer.lock ``` à la racine du projet.

## Dépendance

Ce projet utilise une unique dépendance, un router PHP nommé [simple-php-router](https://github.com/skipperbent/simple-php-router) qui s'occupe de gérer le routing.

## Lancer le serveur

Vous pouvez accéder au site de deux manières : avec le serveur web intégré à PHP, ou avec Apache2

Tout d'abord, pour les deux étapes il faut lancer les serveurs Apache2 et Mysql depuis la racine de WSL :
```
cd # Se déplacer dans la racine de WSL
sudo service apache2 start # Ensuite entrer votre mot de passe
sudo service mysql start
```

### Serveur web integré

Ensuite, lancer le serveur web integré à PHP, placez-vous à la racine du projet puis :

```
cd public # Se déplacer dans le dossier public du projet
php -S localhost:8080 # Démarrez le serveur, le site est accessible depuis http://localhost:8080
```
### Apache2

Pour tester le projet depuis Apache2, il faut d'abord activer le module mod_rewrite d'Apache :

```
sudo a2enmod rewrite
sudo service apache2 restart
```

Il faut ensuite créer un nouveau vhost dans Apache2 :

```
sudo touch /etc/apache2/sites-available/11Cards.com.conf
```

Copiez ensuite le contenu ci-dessous dans le fichier nouvellement créé :

```
<VirtualHost *:80>
	ServerName 11Cards.com.loc

	ServerAdmin webmaster@localhost
	DocumentRoot /var/www/html/11Cards/public

	<Directory /var/www/html/11Cards/public>
	    Options -Indexes +FollowSymLinks
	    AllowOverride All
	</Directory>

	ErrorLog ${APACHE_LOG_DIR}/11Cards.com.loc-error.log
	CustomLog ${APACHE_LOG_DIR}/11Cards.com.loc-access.log combined
</VirtualHost>
```

Veillez à adapter le nom du fichier (ici 11Cards.com.conf) de l'url du site (ici 11Cards.com.loc) et du chemin vers le projet (ici /var/www/html/11Cards/public) à vos besoins !

Vérifiez que vous n'avez pas d'erreur de syntaxe :

```
sudo apache2ctl -t
```

Avant d'activer le vhost :

```
sudo a2ensite 11Cards.com.conf
sudo service apache2 restart
```

Le vhost est maintenant activé, il reste à rendre disponible l'url depuis Windows :

1. Ouvrez le bloc notes **en mode administrateur** ;
2. Ouvrez le fichier ```C:\Windows\System32\drivers\etc\hosts``` (le fichier n'a pas d'extension) ;
3. Copiez les 2 lignes suivantes, en prenant soin de faire correspondre l'url avec celle de votre vhost :
```
127.0.0.1       11Cards.com.loc
::1             11Cards.com.loc
```
Votre site est maintenant accessible.
