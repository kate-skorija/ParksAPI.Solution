# _Parks API_

#### _API Building Code Review for Epicodus, 08.21.2020_

#### By _**Kate Skorija**_



## Description

This week I learned how to build an API with C#/ .Net Core, as well as how to build an MVC client with full CRUD functionality to interact with an API. This API I built contains national and state parks in the western United States. It allows users to GET, POST, PUT, and DELETE parks.



## Setup/Installation Requirements

*_These instructions are specifically for MySql Workbench, but should work similarly for or any generic SQL database manager._* 

1.  Navigate to the [ParksAPI.Solution respository](https://github.com/kate-skorija/ParksAPI.Solution) or open your terminal

2. Clone this project using the GitHub button or the command:
`$ git clone https://github.com/kate-skorija/ParksAPI.Solution.git`

3. Navigate to the `ParksAPI.Solution` directory in your editor of choice, or use [Visual Studio Code](https://code.visualstudio.com/)

4. Within the project, navigate to the ParksAPI directory, and type `dotnet restore`, then `dotnet build`. 

5. Return to your terminal for the ParksAPI directory, and run the command `dotnet ef database update`. This will create a `parks` database in MySql Workbench. Open or refresh MySql Workbench and confirm that the new database has been created.

6. Type `dotnet run` into the terminal. Click on the provided local host link in the terminal to view the web application in your browser. 



## User Stories

As a user, I want to GET and POST state and national parks.
As a user, I want to GET a list of parks by name, county, or state.
As a user, I want to PUT and DELETE reviews, but only if I wrote them. 
As a user, I want to look up random parks just for fun.



## Parks

### HTTP Request

```GET /api/parks
   POST /api/parks
   GET /api/parks/{id}
   PUT /api/parks/{id}
   DELETE /api/parks/{id}
```

### Path Parameters

| Parameter     | Type      | Default  | Required  | Description                |
| ------------- | --------- | -------- | ----------|-----------------           |
|   state       | string    | none     | false     | Return matches by state    |
|   type        | string    | national, state    | false     | Return matches by type   |

### Example Query

```
http://localhost:5000/api/parks?state=Oregon&type=state
```

### Sample JSON Response

```
{
  "parkId": 34,
  "name": "Smith Rock State Park",
  "state": "Oregon",
  "type": "state",
  "website": "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=36"
}
```



## Pagination

### HTTP Request

```GET /api/parks/page
```

### Path Parameters

| Parameter     | Type      | Default  | Required  | Description                |
| ------------- | --------- | -------- | ----------|-----------------           |
|   pageNumber       | int    | none     | false     | Returns all results on a specific page    |
|   pageSize       | int    | 10   | false     | Changes number of results per page, max of 10   |

```
http://localhost:5000/api/parks/page?pageNumber=2&pageSize=5
```

## Known Bugs

There are no known bugs at this time.



## Support and Contact Details

If there are any issues or questions, please reach out to me through [my GitHub account](https://github.com/kate-skorija).



## Technologies Used

*  [Visual Studio Code](https://code.visualstudio.com/)
*  [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
*  [.NET-Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
*  [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
*  [SQL/MySqlWorkbench](https://docs.microsoft.com/en-us/sql/?view=sql-server-ver15)
*  [Entity](https://docs.microsoft.com/en-us/ef/)



### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Kate Skorija_** 