# Building Materials Store
Приложение,онлайн-магазин, который специлизуется на продаже стройматериалов. Для реализации проекта будет использован C# в связке с MySQL.
Для выполнения работы данного приложение мне понадабятся следующие таблицы:

Users Table
+ UserID (Primary Key)
+ FirstName
+ LastName
+ Email
+ PasswordHash
+ PhoneNumber
+ Address
  
Products Table
+ ProductID (Primary Key)
+ Name
+ Description
+ Price
+ CategoryID (Foreign Key)
+ ImageURL

Categories Table
+ CategoryID (Primary Key)
+ Name

Orders Table
+ OrderID (Primary Key)
+ UserID (Foreign Key)
+ OrderDate
+ TotalPrice
+ Status

OrderDetails Table
+ OrderDetailID (Primary Key)
+ OrderID (Foreign Key)
+ ProductID (Foreign Key)
+ Quantity
+ Price

ShoppingCarts Table
+ ShoppingCartID (Primary Key)
+ UserID (Foreign Key)
+ ProductID (Foreign Key)
+ Quantity
![image](https://github.com/5highest1/Building-Materials-Store/assets/154591207/499d37c2-9446-4ae8-83c9-25eebdb01f0d)
![image](https://github.com/5highest1/Building-Materials-Store/assets/154591207/07b44ee5-b197-4e73-93b4-2a197260e075)


