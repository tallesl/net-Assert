# Assert

[![][build-img]][build]
[![][nuget-img]][nuget]

Little helper on assertion.

[build]:     https://ci.appveyor.com/project/TallesL/net-assert
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/net-assert?svg=true
[nuget]:     https://www.nuget.org/packages/Assert
[nuget-img]: https://badge.fury.io/nu/Assert.svg

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
using AssertLibrary;

public Tile[] PaintTiles(Color color, Tile[] tiles)
{
    Assert.IsNotDefault(color);
    Assert.IsInEnum<Color>(color);

    Assert.IsNotNull(tiles);
    Assert.HasElements(tiles);

    foreach (var tile in tiles)
    {
        // Paint the tile
    }
}
```

The helper can check unexpected [nulls], [places reach], [types of values], [enum values], [default values],
[property existence], [true]/[false], [equal]/[not equal], [less]/[more] than, [positive]/[negative]/[not zero] numbers,
and [empty]/[small]/[large]/[single]/[not single]/[exactly] collections.

Call `Assert.UseDebug()` to make the library use [Debug.Assert], `Assert.UseTrace()` to use [Trace.Assert] and
`Assert.UseException()` to make it throw an [AssertException].

[nulls]:               Library/Public%20Methods/IsNotNull.cs
[places reach]:        Library/Public%20Methods/DoesNotReachHere.cs
[types of values]:     Library/Public%20Methods/IsOfType.cs
[enum values]:         Library/Public%20Methods/IsInEnum.cs
[default values]:      Library/Public%20Methods/IsNotDefault.cs
[property existence]:  Library/Public%20Methods/PropertyExists.cs
[true]:                Library/Public%20Methods/IsTrue.cs
[false]:               Library/Public%20Methods/IsFalse.cs
[equal]:               Library/Public%20Methods/IsEqual.cs
[not equal]:           Library/Public%20Methods/IsNotEqual.cs
[less]:                Library/Public%20Methods/IsLess.cs
[more]:                Library/Public%20Methods/IsMore.cs
[positive]:            Library/Public%20Methods/IsPositive.cs
[negative]:            Library/Public%20Methods/IsNegative.cs
[not zero]:            Library/Public%20Methods/IsNotZero.cs
[empty]:               Library/Public%20Methods/HasElements.cs
[small]:               Library/Public%20Methods/HasLess.cs
[large]:               Library/Public%20Methods/HasMore.cs
[single]:              Library/Public%20Methods/IsSingle.cs
[not single]:          Library/Public%20Methods/IsNotSingle.cs
[exactly]:             Library/Public%20Methods/HasExactly.cs
[Debug.Assert]:        https://msdn.microsoft.com/library/System.Diagnostics.Debug.Assert
[Trace.Assert]:        https://msdn.microsoft.com/library/System.Diagnostics.Trace.Assert
[AssertException]:     Library/Exceptions/AssertException.cs