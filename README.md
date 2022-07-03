# .NET_Core_REST_API
[CommanderApi]

Site Link: commanderapi.eastus.azurecontainer.io (If the site is down, it is because I ran out of Microsoft Azure credits)

**The purpose building this API is to employ concepts and code related to:**
--.NET Core
--MVC Architectural Pattern
--C#
--SQL Server Express & SSMS
--Entity Framework Core Object Relation Mapper(DBContext and Migration)
--Data Transfer Objects and AutoMapper
--REST API guidelines
--HTTP/S (GET,POST,PUT,PATCH,DELETE, status codes, CRUD Operations) tested with Postman

**Application Architecture:**

![image](https://user-images.githubusercontent.com/77661117/176105298-82087f31-efb5-4d03-b227-6557482417fe.png)

**API End Points:**

![image](https://user-images.githubusercontent.com/77661117/176108672-1e6aa1be-20ae-44d5-a351-9655f80dba2d.png)

**End points using Postman**

[HttpGet] reads a resource(s) and returns a "200 OK" success status code, and a "400 Bad Request" and "404 Not Found" failure status codes.

![HttpGet](https://user-images.githubusercontent.com/77661117/154824264-c8ee00bd-9db6-4e85-affe-c7057d36361b.png)

[HttpPost] creates a new resources and returns a "201 Created" success status code, and a "400 Bad Request" and "405 Not Allowed" failure status codes.

![HttpPost](https://user-images.githubusercontent.com/77661117/154824270-7437786e-57ad-4bf1-bcba-4068f61e4f85.png)

[HttpPut] updates an entire resource and returns a "204 No Content" success status code.

![HttpPut](https://user-images.githubusercontent.com/77661117/154824277-a14d4873-f3f3-4dec-be4a-7f525da1e568.png)

[HttpPatch] updates a patrial resource and returns a "204 No Content" success status code.

![HttpPatch](https://user-images.githubusercontent.com/77661117/154824280-1f3ec698-dc8b-4c84-9a00-f85b8663b047.png)

[HttpDelete] deletes a resource(s) and returns either a "200 OK" or "204 No Content" success status code.

![HttpDelete](https://user-images.githubusercontent.com/77661117/154824282-20fed155-c9dd-4782-9a76-9eb643fe53cc.png)
