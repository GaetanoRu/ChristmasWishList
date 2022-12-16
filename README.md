# ChristmasWishList :christmas_tree: :santa: :gift:

This and a demonstration API for managing Christmas gifts

## Overview

In this project I built a REST CRUD API from scratch, using .NET 6. As you would expect, the backend system supports Creating, Reading, Updating and Deleting Christmas gifts.

## Technologies

- .NET6
- FluentValidation
- Swagger

## Swagger UI

The ChristmasWishList project will open up the Swagger UI once it starts. Here you can browse the documentation for each endpoint, making it easy to test all of the endpoints.

![Swagger UI](images/swagger.png)

# API Definition

## Get Gifts

## Get Gift Request

```js
GET /gifts
```

## Get Gift Response
```js
200 Ok
```
```json
{
  "total": 1,
  "totalAmount": 40
  "totalSpent": 0,
  "totalToSpent": 40,
  "result": [
    {
      "id": "e6a9bc8a-4707-4e1a-8380-7541ea0f1a4a",
      "firstName": "string",
      "nameGift": "string",
      "price": 1,
      "isPurchased": false,
      "createdDate": "2022-12-13T09:22:07.8675507+01:00",
      "lastModifiedDate": null
    }
  ]
}
```

## Get Gift


### Get Gift Request

```js
GET /gifts/{id}
```

### Get Gift Response

```js
200 Ok
```
or
```js
404 Not Found
```


```json
{
  "id": "e6a9bc8a-4707-4e1a-8380-7541ea0f1a4a",
  "firstName": "John",
  "nameGift": "Book C# 11 and .NET 7",
  "price": 40,
  "isPurchased": false,
  "createdDate": "2022-12-13T09:22:07.867550+01:00",
  "lastModifiedDate": null
}
```

## Create Gift

### Create Gift Request

```js
POST /Gifts
```

```json
{
  "firstName": "John",
  "nameGift": "Book C# 11 and .NET 7",
  "price": 40,
  "isPurchased": false,
}
```

### Create Gift Response
```js
201 Created
```
```yaml
Location: {{url}}/Breakfasts/{{id}}
```
or
```js
400 Bad Request
```

## Update Gift

### Update Gift Request
```js
PUT /gifts/{{id}}
```

```json
{
  "firstName": "John",
  "nameGift": "Book C# 11 and .NET 7",
  "price": 40,
  "isPurchased": true,
}
```


### Update Gift Response
```js
204 No Content
```
or
```js
404 Not Found
```
or
```js
400 Bad Request
```

## Delete Gift

### Delete Gift Request

```js
DELETE /gifts/{{id}}
```

### Delete Gift Response

```js
204 No Content
```
or
```js
404 Not Found
```
or
```js
400 Bad Request
```

## Delete All Gifts

### Delete All Gifts Request

```js
DELETE /gifts/
```

### Delete All Gifts Response

```js
204 No Content
```
or
```js
400 Bad Request
```