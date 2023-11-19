# SunFinder
Desktop Application implementing the OpenWeatherMap API

## Objective
The project is developed using the C# language and NuGet packages to aid development.
The objective of this project is to create an application that is easy to use and 
informative about the current weather and air pollution levels.

## How it works
Upon opening the application, the user is presented with an interface and is prompted
to input a city name.
When a sensible city name has been inputted, and upon clicking the search button, two 
API calls will be invoked.
The first one uses the input from the user, searching current weather of the city.
The JSON output is then used to fill details about the weather in that city.
The second API call will use the results from the first call as it requires longitude
and latitude details.
The JSON output from the second call will display information about the air pollution
levels in those coordinates.
Light mode and dark mode have also been implemented for user preferences.
