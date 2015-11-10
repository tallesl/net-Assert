# Assert

[![][build-img]][build]
[![][nuget-img]][nuget]

Little helper on assertion.

## Usage

I got tired of writing the same boilerplate code for checking unexpected values over and over again, such as:

```cs
public Tile[] PaintTiles(Color color, Tile[] tiles)
{
    if (color == default(Color))
        throw new ArgumentException("color shouldn't be the default one");
    
    if (!Enum.IsDefined(typeof(Color), value))
        throw new ArgumentException("invalid color");

    if (tiles == null)
        throw new ArgumentNullException("tiles");

    if (!tiles.Any())
        throw new ArgumentException("tiles wasn't supposed to be empty");

    foreach (var tile in tiles)
    {
        // Paint the tile
    }
}
```

So now I do:

```cs
public Tile[] PaintTiles(Color color, Tile[] tiles)
{
    AssertThat.IsNotDefault(color);
    AssertThat.IsInEnum<Color>(color);

    AssertThat.IsNotNull(tiles);
    AssertThat.HasElements(tiles);

    foreach (var tile in tiles)
    {
        // Paint the tile
    }
}
```

The helper can check unexpected [nulls], [places reach], [enum values], [default values], and [empty]/[small]/[large]/[single]/[not single] collections.
They all use [Debug.Assert] under the hood.

[build]:          https://ci.appveyor.com/project/TallesL/Assert
[build-img]:      https://ci.appveyor.com/api/projects/status/github/tallesl/Assert
[nuget]:          http://badge.fury.io/nu/Assert
[nuget-img]:      https://badge.fury.io/nu/Assert.png
[nulls]:          Library/Public%20Methods/IsNotNull.cs
[places reach]:   Library/Public%20Methods/DoesNotReachHere.cs
[enum values]:    Library/Public%20Methods/IsInEnum.cs
[default values]: Library/Public%20Methods/IsNotDefault.cs
[empty]:          Library/Public%20Methods/HasElements.cs
[small]:          Library/Public%20Methods/HasLess.cs
[large]:          Library/Public%20Methods/HasMore.cs
[single]:         Library/Public%20Methods/IsSingle.cs
[not single]:     Library/Public%20Methods/IsNotSingle.cs
[Debug.Assert]:   https://msdn.microsoft.com/library/System.Diagnostics.Debug.Assert
