# _Animal Shelter_

#### By _Joey Palchak, Jake Elsberry, Onur Kaymak_

#### _A C# / ASP.NET Core MVC application, integrating Entity Framework Core._

## Technologies Used

* C#
* .NET 6
* ASP.NET Core MVC
* Entity Framework Core
* MSTest
* MySQL

## Description

A web application for an animal shelter to track the animals in their facility based on animal type.

A user has options to add, edit, and delete animal entries.

## Setup/Installation Requirements

1. Copy the **[URL](#LINK)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:
```bash
$ git clone #URL
```
5. Open your terminal and navigate to this project's production directory called `AnimalShelter`.
6. Within the production directory of the project, create a file called `appsettings.json` and add the following code to it:
   ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=[USERNAME];pwd=[PASSWORD];"
      }
    }
   ```
7. Next, make sure to update the connection string with your own system's values for `[USERNAME]` and `[PASSWORD]`! Don't forget to replace the brackets `[]` as well.
8. In the command line, run the following command to compile and launch the web application:
   
```bash
$ dotnet run
```
> Optionally, you can run `dotnet build` to compile this console app without running it.

## Known Bugs

* If any bugs are discovered, please contact the author.

## License

MIT License

Copyright (c) _10/03/2023_ _Joey Palchak, Jake Elsberry, Onur Kaymak_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.