# ThrowIf

[![][build-img]][build]
[![][nuget-img]][nuget]

Little helper on exception throwing.

[build]:     https://ci.appveyor.com/project/TallesL/ThrowIf
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/ThrowIf

[nuget]:     http://badge.fury.io/nu/ThrowIf
[nuget-img]: https://badge.fury.io/nu/ThrowIf.png

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

    switch (color)
    {
        case Colors.Blue:
            PaintInBlue(tiles);
            return tiles;

        case Colors.Yellow:
            PaintInYellow(tiles);
            return tiles;

        default:
            throw new SystemException("crazy color found: " + color);
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

    switch (color)
    {
        case Colors.Blue:
            PaintInBlue(tiles);
            return tiles;

        case Colors.Yellow:
            PaintInYellow(tiles);
            return tiles;

        default:
            throw new ShouldntReachHereException();
    }
}
```

The helper can check unexpected [default values], [empty collections], [large collections], [small collections],
[enum values], [nulls], and [places reach].

Ah, and here's the thing, you aren't supposed to catch those exceptions.
They are assertions, but unlike with [Debug.Assert], I want my assertions easy to write, turned on when 
in production, and showing in error logs.

[default values]:    Library/Throw.cs#L13-L23
[empty collections]: Library/Throw.cs#L25-L35
[large collections]: Library/Throw.cs#L37-L53
[small collections]: Library/Throw.cs#L55-L71
[enum values]:       Library/Throw.cs#L73-L86
[nulls]:             Library/Throw.cs#L88-L98
[places reach]:      Library/Throw.cs#L100-L107
[Debug.Assert]:      https://msdn.microsoft.com/library/System.Diagnostics.Debug.Assert
