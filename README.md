# in-class-activities
## Devlogs
### W1
Move the cat from the start platform（red） to end platform（green） . After，we did the web build.

https://jelenaaa233.itch.io/kitty

### W2
1. Why are the r, g, and b variables floats instead of ints, bools, or strings?
The r, g, and b variables are floats because they represent color values that can include decimals. Floats allow more precise values and smoother color changes. Integers only store whole numbers, booleans only store true or false, and strings store text rather than numbers we can directly use in calculations.
2. Why is the _bounce variable an int instead of a float, bool, or string?
The _bounce variable is an integer because it uses whole-number values. A float is unnecessary because it does not need decimal precision. A boolean only represents two logical states, and a string represents text, so neither is suitable for the numerical calculations involving _bounce.
3. What useful information did the error after Step 4 of Part 2 provide?
The error told me that the calculation produced a double, but the variable required a float. In C#, a decimal literal like 0.1 is a double by default. Adding the f suffix makes it a float, so the corrected line is g -= 0.1f;.

### W3 
table number: 16
Activity 1:
1. GetResponse
- Parameters: `float friendshipLevel`, `bool knowsSecret
- Return type: `string`
The method uses the friendship level and whether the player knows the character's secret to decide what the character will say.
2. SetLightDimness
- Parameter: `float sanityLevel`
- Return type: `void`
The method changes the brightness of the lights based on the player's sanity level. It does not need to return anything.
3. DidPlayerHitBeat
- Parameter: `float keyPressTime`
- Return type: `bool`
The method checks whether the player pressed the key at the correct time and returns true or false.
Activity 2:
I think a class is like a person, and a component is like a job that the person takes. The class is the template that defines what the person can do. Member variables are the person's traits, such as their speed, strength, or health. Methods are the person's abilities or actions, such as walking, jumping, or talking. Different components can give a GameObject different functions, just like people can have different jobs and responsibilities.
Activity 3:
I believe the balls become so bright due to the 1.5 scaling of their color values when they bounce at a certain speed. As the balls bounce enough times, the RGB values continue to increase and the balls become brighter until they become nearly white. The reason for this is that the color value is scaled per bounce rather than being reset per bounce.

### W4 
table 16
I learned about the roles of Colliders, Rigidbodies, and the "Is Trigger" setting in Unity.
First, I assigned different Colliders to the Cat, the SoccerBall, and the Goal. Then, I used a MadeGoal() method to handle goal events.
I also implemented a scoring system—adding one point for every goal—and included a timer to track the time elapsed since the last goal.

I ran into some issues—indicated by exclamation mark icons—because parts of my code were placed outside the method's curly braces. By checking the placement of these braces and the variable declarations, I was able to resolve the compilation errors. This process has deepened my understanding of collision detection, method invocation, and UI updates in Unity.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
