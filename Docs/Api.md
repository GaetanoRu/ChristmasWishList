# API Definition

- [Gift API](#api-definition)
  - [Get Gifts](#get-gift)
    - [Get Gifts Request](#get-gift-request)
    - [Get Gifts Response](#get-gift-response)
  - [Get Gift](#get-gift)
    - [Get Gift Request](#get-gift-request)
    - [Get Gift Response](#get-gift-response)
  - [Create Gift](#create-gift)
    - [Create Gift Request](#create-gift-request)
    - [Create Gift Response](#create-gift-response)
  - [Update Gift](#update-gift)
    - [Update Gift Request](#update-gift-request)
    - [Update Gift Response](#update-gift-response)
  - [Delete Gift](#delete-gift)
    - [Delete Gift Request](#delete-gift-request)
    - [Delete Gift Response](#delete-gift-response)
  - [Delete All Gift](#delete-all-gift)
    - [Delete Gift Request](#delete-all-gift-request)
    - [Delete Gift Response](#delete-all-gift-response)

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