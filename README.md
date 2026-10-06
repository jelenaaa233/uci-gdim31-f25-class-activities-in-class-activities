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

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
