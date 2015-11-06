# ThrowIf

[![][build-img]][build]
[![][nuget-img]][nuget]

Little helper on exception throwing.


## Usage

I got tired of writing the same boilerplate code for checking unexpected values over and over again, such as:

```cs
public Tile[] PaintTiles(Color color, Tile[] tiles)
{
    if (color == default(Color))
        throw new ArgumentException("color shouldn't be the default one");

    if (tiles == null)
        throw new ArgumentNullException("tiles");

    if (!tiles.Any())
        throw new ArgumentException("tiles wasn't supposed to be empty");
    
    if (!Enum.IsDefined(typeof(Color), value))
        throw new ArgumentException("invalid color");

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
    Throw.IfDefault(color);
    Throw.IfNull(tiles);
    Throw.IfEmpty(tiles);
    Throw.IfNotInEnum<Color>(color);

    foreach (var tile in tiles)
    {
        // Paint the tile
    }
}
```

The helper can check unexpected [default values], [empty]/[large]/[small] collections,
[enum values], [nulls], and [places reach].

Ah, and here's the thing, you aren't supposed to catch those exceptions.
They are assertions, but unlike with [Debug.Assert], I want my assertions easy to write, turned on when 
in production, and showing in error logs.

[build]:          https://ci.appveyor.com/project/TallesL/ThrowIf
[build-img]:      https://ci.appveyor.com/api/projects/status/github/tallesl/ThrowIf
[nuget]:          http://badge.fury.io/nu/ThrowIf
[nuget-img]:      https://badge.fury.io/nu/ThrowIf.png
[default values]: Library/IfDefault.cs
[empty]:          Library/IfEmpty.cs
[large]:          Library/IfMore.cs
[small]:          Library/IfLess.cs
[enum values]:    Library/IfNotInEnum.cs
[nulls]:          Library/IfNull.cs
[places reach]:   Library/IfReachHere.cs
[Debug.Assert]:   https://msdn.microsoft.com/library/System.Diagnostics.Debug.Assert
