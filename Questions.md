#### Question 1 
###### Combien y a-t-il de façons de gagner, de perdre ? À quel endroit dans le code déclenche-t-on la victoire et la défaite ?
La seule façon de gagner est d'activer le Graal. Il y a cependant plusieurs manières de perdre comme être en crise Mordred ou avoir une dette financière insurmontable.

C'est dans la fonction : 
```c#
NextTurn() 
```
de WorldState.cs que l'on test si une crise déclenche la défaite, ou si le Graal a été activé. Si c'est le cas on appelle la méthode LoseDialog() ou WinDialog() de GameController pour l'indiquer au joueur.

#### Question 2
##### À quoi correspond la propriété DefaultCommand de la classe GameController ?
Elle correspond à la commande par défaut si jamais aucune commande de l'utilisateur n'est entrée. C'est la commande "aide" qui affiche la liste des commandes disponibles.

#### Question 3 
##### Comment la difficulté est-elle choisie et pourquoi le choix Difficile ne fonctionne-t-il pas ?
La difficulté est chosie grâce à l'attribut *Difficulty* de DifficultyView qui est mis à jour lorsque que l'évènement *Click* sur un des boutons de la fenêtre est effectué.
Le choix **Difficile** ne fonctione pas car aucun évènement du boutton en question n'est associé dans le code. En effet, il y a marqué "0 references" au-dessus de la méthode de réponse à l'évènement. Il faut la relier.

#### Question 4 
##### Comment la boîte de dialogue se ferme-t-elle et pourquoi le bouton Difficile ne permet-il pas de la fermer ?
Cette fenêtre est fermé grâce au fait que les boutons ont la propriété *DialogResult* mis à *OK*, ce qui n'est pas le cas du botuton **Difficile**.
Le fait d'activer cette propriété permet de mettre fin au
```c#
ShowDialog();
```
. La valeur de la difficulté sera donc stockée et on pourra charger la partie avec la difficulté correspondante.

#### Question 5
##### Lors du passage au tour suivant (la commande tapée est suivant), comment GameView et GameController interagissent-elles pour faire le passage au tour suivant (quelles sont les méthodes appelées, quels sont leurs effets) ?

Dès lors que l'on appuie sur la touche entrée, l'évènement est pris en compte dans le *GameView.cs* et appelle :
```c#
GameController.Interpret(inputTextBox.Text);
```
qui va donc interpréter la commande tapée. Si elle est valide, c'est-à-dire qu'elle est présente en tant que clé du dictionnaire de commandes, alors il execute l'action associée à la clé. Dans le cas de "suivant", il appelle :
```c#
theWorld.NextTurn();
```
qui s'occupe de faire passer le tour et mettre à jour les données de la partie.