# SMT4A
Explore data on Shin Megami Tensei 4: Apocalypse

# Features
* Only a skill search currently.

## Usage
1. Apply filters to narrow down skills of interest.
  * Can filter by name to find skills containing the given text. Doing this, the app will ignore the rest of the filters. (Note this is not a powerful text filter, and names are case-sensitive.)
  * When found, double click to move them to your list of Saved Skills.
  * Can double click a saved skill to remove it.
  
2. Can sort skills found by in-game id, or name. 
  * Some skills don't have names and are represented by a number instead. This is not an error by the app and is just ignored by the game's localization team. They either work or may not.
  
3. Can find a _Random_ skill out of 500 that exist. Just for the heck of it only, so it doesn't always get what you want.

##Troubles?

Q. __I applied filters but find no, few, or unexpected skills...__

A. Check if the name is spelled correctly. Again, the name filter is not powerful, and is case-sensitive. If not using the name filter, leave it empty.

B. Part of this process involves understanding how (specific) skills work and are categorized in game.
  Also, most skills apply one (1) attack/move/effect, eg. Agi, Debilitate, et cetera. So some issues can be alleviated by setting the # of attacks rule to exactly 1.
  Whereas skills like "Rampage" which can hit 6-10 times, can be found by setting the # of attacks as 'range', and more specific, power=heavy, element=attack, et cetera.
  If you're still unsure, just ask anyone for a powerful skill and then enter its name into the app to dig more info on it.

Q. __My new skill does not work in game or is grayed out...__

A. It may be an enemy-exclusive/original skill, or a dummy, or it's simply uncoded in the game. One example is the skill "Hexagram", (can 1-hit). This often happens to me when I tried using an OP skill, only to find it doesn't work.
