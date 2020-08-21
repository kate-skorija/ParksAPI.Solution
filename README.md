# _Parks API_

#### _API Building Code Review for Epicodus, 08.21.2020_

#### By _**Kate Skorija**_

## Description

An API I built of state and national parks. It allows users to GET, POST, PUT, and DELETE parks.

## User Stories

As a user, I want to GET and POST state and national parks.
As a user, I want to GET a list of parks by name, county, or state.
As a user, I want to PUT and DELETE reviews, but only if I wrote them. 
As a user, I want to look up random parks just for fun.

## HTTP Request

```GET /api/parks
   POST /api/parks
   GET /api/parks/{id}
   PUT /api/parks/{id}
   DELETE /api/parks/{id}
```
## Path Parameters

| Parameter     | Type      | Default  | Required  | Description                |
| ------------- | --------- | -------- | ----------|-----------------           |
|   name        | string    | none     | false     | Return matches by name     |
|   county      | string    | none     | false     | Return matches by county   |
|   state       | string    | none     | false     | Return matches by state    |

## Example Query

```
https://localhost:5000/api/parks?county=multnomah&state=oregon
```

## Sample JSON Response

```
{
  "Id": 12
  "Name": "Crater Lake National Park"
  "State": "Oregon"
}
```

## Setup/Installation Requirements

<!-- There are multiple ways to query the API. To search by username or a specific rating(1-5), add the parameter(s) after `places?` like so: `http://localhost:5000/api/places?username=kate&rating=5`. Use an ampersand(&) to separate parameters.


To search by page and/or to limit the number of results per page, add `pages?` after `places/`, then specity the pageNumber (which page you would like to see) and pageSize (how many results you would like per page. Here is an example query:  `http://localhost:5000/api/places/pages?pageNumber=2&pageSize=8`. If pageSize is not specified, the default number of results per page is 10. -->

## Known Bugs

| Bug : Message | Situation | Resolved (Y/N) | How was the issue resolved? |
| ------------- | --------- | -------------- | --------------------------- |
|               |           |                |                             |

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