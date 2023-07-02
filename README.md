## Project Description :ledger:

This is a project built on .Net Core MVC where it is possible to search and display the weather forecast for a city.

## Techs :man_technologist:

The following technologies were used in this project:

- [.Net 7](https://dotnet.microsoft.com/pt-br/download/dotnet/7.0)
- [Dotenv.net](https://github.com/bolorundurowb/dotenv.net)

## How to replicate this project :dvd:

- Make sure to have the necessary dependencies installed, such as .NET 7 SDK
- Follow the instructions to run the [WeatherForecast_API_CSharp](https://github.com/rodhenr/WeatherForecast_API_CSharp)
- Clone this repository
- Create a file named .env in the root directory of the project. Open the .env file and add the following line:

```
API_BASE_URL=http://localhost:5119/api/weatherForecast
```

- In the command prompt or terminal, navigate to the project's root directory. Then, run the following command to restore the project's dependencies:

```
dotnet restore
```

- Once the dependencies are installed, you can build and run the project using the following command:

```
dotnet run
```

- Open the link http://localhost:5276/ in your browser to use the application

## Questions or Suggestions? :grin:

If you have any questions or suggestions, feel free to reach out!
