# Rotten Tomatoes Portable #

## What is it? ##
Rotten Tomatoes Portable is a Portable Class Library that gives developers access to the Rotten Tomatoes film and Review aggregator ([www.rottentomatoes.com/](http://www.rottentomatoes.com/)).

## What targets does it have? ##
It targets ***everything***!!! So that's .NET 4.0.3+, Silverlight 5, Windows Store apps, Windows Phone 7.5, Windows Phone 8.

## Anything cool and unexpected? ##
Yeah, the main classes (Movie, Clip, Review, etc) all implement INotifyPropertyChanged to make it easier if you want to use them in an MVVM approach. There is also an `ICineworldClient` interface if you want to use it that way.

## How do I install it? ##
Nuget. Basically. 

PM> Install-Package RottenTomatoesPortable

