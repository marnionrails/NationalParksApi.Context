# Web API for US National Parks

#### Epicodus Code Review: Web APIs in C#/.NET

#### By Marni Sucher

#### _Table of Contents_

1. [Description](#description)
2. [Technologies Used](#technologies)
3. [Setup/Installation Requirements](#setup)
4. [Endpoints](#endpoints)
5. [Known Bugs](#bugs)
6. [License](#license)
7. [Contact Information](#contact)


## Description <a id="description"></a>

This is a web API of a database for national parks in the United States. It was made using C#, .Net 5, MySQL, and Entity. It makes use of Swagger UI to provide documentation for the endpoints. 

## Technologies Used <a id="technologies"></a>

* C#
* .NET 5
* Entity
* Swagger
* MySQL
* Git
* VS Code

## Setup/Installation Requirements <a id="setup"></a>
* If [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) and [.NET](https://docs.microsoft.com/en-us/dotnet/) are not installed on your local device, follow the instructions [here](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-c-and-net)
* If [MySQL Community Server](https://dev.mysql.com/downloads/mysql/) and [MySQL Workbench](https://www.mysql.com/products/workbench/) are not installed on your local device, follow the instructions [here](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-and-configuring-mysql)
* Open the terminal on your local machine
* Clone this repository to your machine `$ git clone https://github.com/marnionrails/NationalParksApi.Solution`
* Create `appsettings.json` file:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=national_parks;uid=root;pwd=<YOUR PASSWORD HERE>;"
  }
}
```
* Create local database from migration with `dotnet ef database update`
* Compile code by running command `$ dotnet build`
* Run server with command `$ dotnet run` 
* Navigate to desired endpoint as documented below

## Endpoints <a id="endpoints"></a>
The Swagger user interface will allow you to "try out" any of the endpoints.

To see Swagger documentation and utilize the feature (while server is running!), click [here](http://localhost:5000/swagger)

#### GET

* GETs all National Parks in the database: <br>
`http://localhost:5000/api/nationalparks/parks`
  
* GETs any National Parks with a name that matches your query: <br>
`http://localhost:5000/api/nationalparks/parks?name=<YOUR QUERY HERE>`

* GETs any National Parks with a region that matches your query: <br>
`http://localhost:5000/api/nationalparks/parks?region=<YOUR QUERY HERE>`

* GETs any National Parks with a state that matches your query: <br>
`http://localhost:5000/api/nationalparks/parks?state=<YOUR QUERY HERE>`

* GETs any National Parks that have a description containing your query: <br>
`http://localhost:5000/api/nationalparks/parks?description=<YOUR QUERY HERE>`

* GETs the National Park with the Id as specified in the request: <br>
`http://localhost:5000/api/nationalparks/parks/{ID}`

#### POST 
* POSTs a new National Park to the API: <br>
`http://localhost:5000/api/nationalparks/parks`

#### DELETE
* DELETEs the National Park with the Id as specified in the request: <br>
`http://localhost:5000/api/nationalparks/parks/{ID}`

#### PUT
* PUTs new data into the National Park entry with the Id as specified in the request: <br>
`http://localhost:5000/api/nationalparks/parks/{ID}`

## Known Bugs <a id="bugs"></a>
* None at this time

## License <a id="license"></a>
*[MIT](https://choosealicense.com/licenses/mit/)*

Copyright (c) 2021 Marni Sucher

## Contact Information <a id="contact"></a>
**_Marni Sucher <suchermarni@gmail.com>_**