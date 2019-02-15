# Unity_RandomEx

Provides various random functions.

## Import to Your Project

You can import this asset from UnityPackage.

- [RandomEx.unitypackage](https://github.com/XJINE/Unity_RandomEx/blob/master/RandomEx.unitypackage)

## How to Use

There are some methods and properties to get random value.

| Property         | Description                                        |
|:-----------------|:---------------------------------------------------|
| Value            | Return 0 ~ 1 value.                                |
| Radian           | Return 0 ~ 360 angle value in radian.              |
| Sign             | Return -1 or 1.                                    |

| Method                                  | Description                                        |
|:----------------------------------------|:---------------------------------------------------|
| Index                                   | Return index from array of rates.                  |
| Range(int\|float\|Vector\|Rect\|Bounds) | Return min ~ max value. (int type exclusive max)   |
| OnUnitCircle(float\|Vector)             | Return value on unit circle in x,y or Vector2.     |
| InsideUnitCircle(float\|Vector)         | Return value inside unit circle in x,y or Vector2. |
| OnUnitSphere(float\|Vector)             | Return value on unit sphere in x,y or Vector3.     |
| InsideUnitSphere(float\|Vector)         | Return value inside unit sphere in x,y or Vector3. |

## Replace Random Value Generator

``ValueFunc`` field provides function which returns random value.
You could replace this function if you want. The function must be return 0 ~ 1 value.

One of the samples uses Xorshift as an example.

- https://github.com/XJINE/CS_Xorshift