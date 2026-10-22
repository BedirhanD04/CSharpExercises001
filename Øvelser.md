## multiplikationstabel

I `Main`-metoden skal du udskrive en multiplikationstabel, som vist nedenfor:

```
   1   2   3   4   5   6   7   8   9  10
   2   4   6   8  10  12  14  16  18  20
   3   6   9  12  15  18  21  24  27  30
   4   8  12  16  20  24  28  32  36  40
   5  10  15  20  25  30  35  40  45  50
   6  12  18  24  30  36  42  48  54  60
   7  14  21  28  35  42  49  56  63  70
   8  16  24  32  40  48  56  64  72  80
   9  18  27  36  45  54  63  72  81  90
  10  20  30  40  50  60  70  80  90 100
```

For eksempel står der i række 4 og kolonne 9 tallet 4 · 9 = 36.

Brug to indlejrede `for`-løkker til at løse opgaven. Bemærk, at `Console.WriteLine` automatisk starter en ny linje efter teksten, mens `Console.Write` ikke gør:

csharp

```csharp
Console.Write("tekst");
Console.WriteLine("mere tekst");
```

```
tekstmere tekst
```

Udskriv tallene i et felt med bredden fire, så de står pænt på linje. Feltbredden kan angives direkte i en interpoleret streng, f.eks. `$"{tal,4}"`, som højrestiller `tal` i et felt på fire tegn. Læs mere om dette i Microsofts dokumentation under [Composite formatting – alignment](https://learn.microsoft.com/dotnet/standard/base-types/composite-formatting#alignment-component).