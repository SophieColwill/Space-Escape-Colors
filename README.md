# Space Escape Colors
## Sophie Colwill (100919358)

The main gameplay loop of Space Escape Colors is that, as soon as you load into the game you are thrusted into battle with space debris coming towards you. You use WASD to move around, and Left Shift to use your limited amount of boost to dodge the oncoming enemies. You keep going until you die, then try again to get a better highscore.

I think that my implementation of the Factory workflow was a rather good use of it as it makes my obstacle spawning code rather modular and easily expandable. All I have to do is create a new obstacle script, attach it to a prefab, then drag the prefab into my obstacle spawner script. Once that is done, I can repeat again and again until I have all the obstacles I want, and all I need to do is drag the prefab to the obstacle spawner to make it spawn in game. This would take more than double the lines of code to do, if I were to do it without the Factory design pattern.

## Factory Implementation
<img width="531" height="521" alt="Factory Implementation" src="https://github.com/user-attachments/assets/2415c9c9-a4ae-4f89-9366-97b235073c04" />

## Observer Implementation
My implementation of the Observer design pattern is used in a way that plays into the game's previous strengths. It is used for the time based actions of the game, primarily the score timer, but it also decreases the Boost value when the player presses the shift key. I used it here because I thought that adding a time based subscription would be benificial in case I wanted to add power ups in the future that have to go away after a set time. Also since alot of my project relies on time, I belive it was benifical to group them in subscribable and unsubscribable sections to make it easier to manage.
<img width="559" height="444" alt="Screenshot 2025-11-01 045735" src="https://github.com/user-attachments/assets/03af4a6b-6ce5-44fc-9f2d-89d437820c5f" />
