# **DaylightsStudio Rainbow Six Siege Character Reward**

Prendre note que le dossier `[DAY’S] OBS Stuff` doit être a la racine du lecteur `C:\` avant de commencer l'installation.
### Pré-requis.
#### Fonts
- FOT-Rodin Bokutoh pro B
- FOT-Rodin Bokutoh pro UB
- FOT-Rodin Bokutoh pro EB

Toutes téléchargeables ici: https://www.cufonfonts.com/font/fot-rodinbokutoh-pro

#### Plugins OBS

- [Move transition](https://obsproject.com/forum/resources/move-transition.913/ "Move transition") par Exeldro


- [OBS Shaderfilter](https://obsproject.com/forum/resources/obs-shaderfilter.775/ "OBS Shaderfilter") par Surn


- [OBS Websocket (v4.9.1)](https://github.com/obsproject/obs-websocket/releases/tag/4.9.1 "OBS Websocket 4.9.1") par TT2468 & dnaka91


- [Source Copy](https://obsproject.com/forum/resources/source-copy.1261/ "Source Copy") par Exeldro


- [StreamFX](https://github.com/Xaymar/obs-StreamFX/releases/tag/0.11.1 "StreamFX") par Xaymar (descendre au bas de la page et installer le fichier terminant par `.exe`)

### Installation StreamerBot (note au bas de la page)

1. Télécharger [StreamerBot](https://streamer.bot/ "StreamerBot")

2. Extraire l'archive .zip

3. Éxécuter le fichier (double clic) `Streamer.bot.exe`

4. Dans l'onglet Action, cliquez droit dans l'onglet action et choisissez *Import*.

5. Glissez le fichier `Day R6 ops.txt` dans la case `import string` et cliquez sur *Import*.

6. Dans l’onglet *Channel Point Rewards*, ajoutez deux nouveaux rewards et nommez les `R6 Att` et `R6 Def`
	**IMPORTANT** cochez la case `User Input Required` et dans l’onglet *Action* du bas sélectionnez `Ops att Filter`. Faites la même chose pour `Ops Def Filter`.

8. Dans l’onglet *Actions*, selectionnez `Ops att Filter` et dans l’onglet *Sub-Action*, faites un clic droit puis *Edit* sur `Reward Set Enabled State`. Assurez-vous que le Reward Actif soit bien `R6 Att` et que le *State* soit **Disabled**. Répetez pour le reward en défense avec `Ops def Filter` ainsi que `R6 Def`.

10. Dans l’onglet *Action*, selectionnez `Ops att Reset` et dans l’onglet *Sub-Action*, faites un clic droit puis *Edit* sur `Reward Set Enabled State`. Assurez-vous que le Reward Actif est bien `R6 Att`. Répetez pour le reward en défense avec `Ops def Reset` ainsi que `R6 Def`.

12. Dans l’onglet *Hot Keys*  faites un clic droit et créez un raccourci clavier de votre choix et dans l’onglet *Action* Sélectionnez `Ops att Reset`. Faites la même chose pour `Ops def Reset`.


Maintenant quand un Viewer redeem un personnage à jouer, le personnage s’affichera en attente. Une fois que vous avez joué le personnage, utilisez le shortcut pour effacer le personnage en attente et rendre actif le Redeem pour une autre sélection.

------------
#### note
 La configuration de base de StreamerBot tel que les liens avec votre compte Twitch, Obs, Streamelements ou Streamlabs doivent déjà été effectué avant l'installation de ce pack.
Installation OBS

Cliquez outils et selectionnez "source Copy" -> "Load Scene" et sélectionnez le fichier "R6 Overlay.JSON"
Ajoutez la scène "[DAY_S] R6 Overlay Ops" a chaque scène ou vous voulez voir l'alerte.*



