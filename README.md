[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


UI
    Seed counter (planted and remaining)
    Planted text
        Every time something is planted, add 1 
    Remaining text
        Every time something is planted, subtract 1 to a limit of 0
Plant Prefab
    Plant sprite
        Can be planted if Seeds remaining counter >0
        Can only be created by the player
        Only 5 can exist
        Bunny (Player)
Bunny sprite
    Can move with WASD
    Plant seeds with Space bar
        Adds a plant prefab where the bunny is located IF there’s seeds remaining
            If no seeds remaining, cannot plant (nothing happens)
        Updates UI with changes to seed count and seeds planted

The variables tracking seeds planted are listed under the UI section in the original written plan, but they are actually located in the Player object. These variables are called _numSeedsLeft for how many seeds the player can plant and _numSeedsPlanted for how many seeds the player has planted. The plant prefab is created by the Player script on the Player object, which checks _numSeedsLeft after the PlantSeed() function is called by the space bar being pressed. It then instantiates a plant prefab at the player's position. The Player script also calls the UpdateSeeds() function on the PlantCountUI script as part of the PlantSeed() function, and it uses _numSeedsLeft and _numSeedsPlanted as the arguments to change the text of the UI.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
https://www.deviantart.com/sunnysun10/art/Sunflower-from-pvz1-and-no-background-png-994661095
-plant sprite for Sunflower from Plants vs Zombies