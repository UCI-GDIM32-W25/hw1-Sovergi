[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
- UI
    - Seed counter (planted and remaining)
    - Planted text
        - Every time something is planted, add 1 
    - Remaining text
        - Every time something is planted, subtract 1 to a limit of 0
- Plant Prefab
    - Plant sprite
    - Can be planted if Seeds remaining counter >0
    - Can only be created by the player
    - Only 5 can exist
- Bunny (Player)
  - Bunny sprite
  - Can move with WASD
  - Plant seeds with Space bar
      - Adds a plant prefab where the bunny is located IF there’s seeds remaining
      - If no seeds remaining, cannot plant (nothing happens)
      - Updates UI with changes to seed count and seeds planted

## Devlog
The variables tracking seeds planted are listed under the UI section in the original written plan, but they are actually located in the Player object. These variables are called _numSeedsLeft for how many seeds the player can plant and _numSeedsPlanted for how many seeds the player has planted. The plant prefab is created by the Player script on the Player object, which checks _numSeedsLeft after the PlantSeed() function is called by the space bar being pressed. It then instantiates a plant prefab at the player's position. The Player script also calls the UpdateSeeds() function on the PlantCountUI script as part of the PlantSeed() function, and it uses _numSeedsLeft and _numSeedsPlanted as the arguments to change the text of the UI.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
https://www.deviantart.com/sunnysun10/art/Sunflower-from-pvz1-and-no-background-png-994661095
-plant sprite for Sunflower from Plants vs Zombies

## Prof comments
Good job connecting your break-down to the code, especially describing something that you ended up changing. :)

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. Also, make sure to put your break-downs in the correct section. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
