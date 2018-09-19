# Unity_RandomEx

Include random's utility functions or any other logic like Xorshift.

## Import to Your Project

You can import this asset from UnityPackage.

- [RandomEx.unitypackage](https://github.com/XJINE/Unity_RandomEx/blob/master/RandomEx.unitypackage)

## How to Use

There are some methods to get random.


| Method           | Description                                        |
|:-----------------|:---------------------------------------------------|
| Value            | Return 0 ~ 1 value.                                |
| Index            | Return index from array of rates.                  |
| Sign             | Return -1 or 1.                                    |
| Range            | Return min ~ max value. (int type exclusive max)   |
| OnUnitCircle     | Return value on unit circle in x,y or Vector2.     |
| InsideUnitCircle | Return value inside unit circle in x,y or Vector2. |
| OnUnitSphere     | Return value on unit sphere in x,y or Vector3.     |
| InsideUnitSphere | Return value inside unit sphere in x,y or Vector3. |
| ColorHSV         | Return color which has random HSV parameter.       |

Almost basic class has these methos.
And ``System.~`` files are not dependent on Unity. These works on a native C#.

## Xorshift

You can make some instance of Xorshift random generator.
Xorshift is fast algorithm to make good random value.

But it has a problem. A Little biased is occurred in a small number of trials.